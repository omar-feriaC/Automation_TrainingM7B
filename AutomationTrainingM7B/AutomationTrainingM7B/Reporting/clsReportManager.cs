using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Reporting
{
    class clsReportManager
    {
        private DateTime time = DateTime.Now;

        public string fnReportPath()
        {
            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strPath.Substring(0, strPath.IndexOf("bin"));
            //            var strProjectPath = new Uri(strActualPath).LocalPath;
            strActualPath = new Uri(strActualPath).LocalPath;

            string strReportDirectory = strActualPath + "ExtentReports";
            if (!Directory.Exists(strReportDirectory))
            {
                Directory.CreateDirectory(strReportDirectory);
            }

            var strReportPath = strReportDirectory + "\\ExtentReports\\ExtentReports_" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".html";

            return strReportPath;
        }

        //public void fnReportSetUp(ExtentHtmlReporter phtmlReporter, ExtentReports pExtent)
        public void fnReportSetUp(ExtentV3HtmlReporter phtmlReporter, ExtentReports pExtent)
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            phtmlReporter.Config.DocumentTitle = "Automation Framework Report";

            pExtent.AttachReporter(phtmlReporter);

            pExtent.AddSystemInfo("Project Name:", "Automation Framework");
            pExtent.AddSystemInfo("Application:", "PHPTravels");
            pExtent.AddSystemInfo("Environment:", "QA");
            pExtent.AddSystemInfo("Browser:", ConfigurationManager.AppSettings.Get("browser"));
            pExtent.AddSystemInfo("Date:", time.ToShortDateString());
            pExtent.AddSystemInfo("Version:", "v1.0");
        }

        public string fnCaptureImage(IWebDriver pobjDriver, ExtentTest pstrScreenName)
        {
            /*Create SS directory*/
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objSS = objITake.GetScreenshot();

            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strPath.Substring(0, strPath.IndexOf("bin"));
            //            var strProjectPath = new Uri(strActualPath).LocalPath;
            strActualPath = new Uri(strActualPath).LocalPath;

            string strScreenshotDirectory = strActualPath + "ExtentReports";
            if (!Directory.Exists(strScreenshotDirectory))
            {
                Directory.CreateDirectory(strScreenshotDirectory);
            }

            ///////////////////////
            /*var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));
            strActualPath = new Uri(strActualPath).LocalPath;

            string strScreenshotDirectory = strActualPath + "ExtentReports\\Screenshots";
            if (!Directory.Exists(strScreenshotDirectory))
            {
                Directory.CreateDirectory(strScreenshotDirectory);
            }*/

            //Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");

            /*Save Image*/
            /*var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots\\" + pstrScreenName;
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strLocalPath;*/
            string strScreenshotPath = strScreenshotDirectory + $"\\{TestContext.CurrentContext.Test.Name}_{DateTime.Now.ToString("HHmmss")}.png";
            objSS.SaveAsFile(strScreenshotPath);

            pstrScreenName.Log(Status.Info, "Step Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());

            return strScreenshotPath;

        }

        public void fnTestCaseResult(ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
           ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    //DateTime time = DateTime.Now;
                    //string strFileName = "Screenshot_" + time.ToShortDateString() + ".png";
                    string strFileName = "Screenshot_" + time.ToString("hh_mm_ss") + ".png";
                    var strImagePath = fnCaptureImage(pobjDriver, pobjTest);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Fail("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    //pobjTest.Log(Status.Fail, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                case TestStatus.Passed:
                    logstatus = Status.Pass;
                    break;
                default:
                    logstatus = Status.Warning;
                    Console.WriteLine("The status: " + status + " is not supported.");
                    break;
            }
            pobjTest.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            pobjExtent.Flush();
        }

    }
}
