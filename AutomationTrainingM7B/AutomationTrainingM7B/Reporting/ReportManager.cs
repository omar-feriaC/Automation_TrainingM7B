using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace AutomationTrainingM7B.Reporting
{
    class ReportManager
    {
        public string fnGetReportPath()
        {
            string strExecutingPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase; //Get DLL execution folder
            string strBaseDirectory = strExecutingPath.Substring(0, strExecutingPath.IndexOf("bin")); //Get Base Directory
            strBaseDirectory = new Uri(strBaseDirectory).LocalPath; //Transform Directory format to match local machine

            string strReportDirectory = strBaseDirectory + "ExtentReports";
            if(!Directory.Exists(strReportDirectory))
            {
                Directory.CreateDirectory(strReportDirectory);
            }

            string strReportPath = strReportDirectory + "\\ExtentReport_" + DateTime.Now.ToString("MMDDyyyy_HHmmss") + ".html";

            return strReportPath;
        }

        public void fnReportSetUp(ExtentV3HtmlReporter htmlReporter, ExtentReports extent)
        {
            htmlReporter.Config.DocumentTitle = "Automation Framework Report";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReporter.Config.ReportName = "LinkedIn";

            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Project Name", "LinkedIn");
            extent.AddSystemInfo("Application", "WebPage");
            extent.AddSystemInfo("Environment: ", "QA");
            extent.AddSystemInfo("Date:", DateTime.Now.ToShortDateString());
        }
        [Test]
        public string fnCaptureImage(IWebDriver pobjDriver)
        {
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objScreenshot = objITake.GetScreenshot();

            string strExecutingPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase; //Get DLL execution folder
            string strBaseDirectory = strExecutingPath.Substring(0, strExecutingPath.IndexOf("bin")); //Get Base Directory
            strBaseDirectory = new Uri(strBaseDirectory).LocalPath; //Transform Directory format to match local machine

            string strScreenshotDirectory = strBaseDirectory + "ExtentReports\\Screenshots";
            if (!Directory.Exists(strScreenshotDirectory))
            {
                Directory.CreateDirectory(strScreenshotDirectory);
            }

            string strScreenshotPath = strScreenshotDirectory + $"\\{TestContext.CurrentContext.Test.Name}_{DateTime.Now.ToString("HHmmss")}.png";
            objScreenshot.SaveAsFile(strScreenshotPath);

            return strScreenshotPath;
        }
    }
}
