using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;


namespace AutomationTrainingM7B.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        string sreenPath;

        [Test]
        public void Test_M9Exercise()
        {
            try
            {
                objTest = exTestCase.CreateNode("Dashboard", "Elements in Red Box");
                //Init objects
                objPHP = new clsPHPTravels_LoginPage(driver);
                //Login Action
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
                clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
                clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
                clsPHPTravels_LoginPage.fnClickLoginButton();
                clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                //Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
                objPHP.fnDashboardElementsInRedBox();
                //Create to bring the screenshot, next step: 
                sreenPath = objRM.fnCaptureImage(driver, "Screenshot.png");

                objTest.Log(AventStack.ExtentReports.Status.Pass, "Step ScreenShot :", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
            }
            catch (Exception e)
            {
                Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
                objTest.Log(AventStack.ExtentReports.Status.Error, "Step has failed with SS", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
                Console.WriteLine(e.Message);
                Console.WriteLine("Test Case Failed");
                exTestCase.Fail($"Test Case Failed Erro: {e.Message}");
            }

        }
    }
}
