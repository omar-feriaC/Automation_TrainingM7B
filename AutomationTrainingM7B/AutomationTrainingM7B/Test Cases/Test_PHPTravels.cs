using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace AutomationTrainingM7B.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;

        [Test]
        public void Test_M9Exercise()
        {
            try
            {
                //Init objects
                objPHP = new clsPHPTravels_LoginPage(driver);
                exTestStep = objTest.CreateNode("Login", "Login to PHPTravels");
                //Login Action
                Assert.AreEqual(true, driver.Url.Contains("https://www.phptravels.net/admin"), "The Login Page was loaded correctly.");
                //clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
                clsPHPTravels_LoginPage.fnEnterEmail(email);
                clsPHPTravels_LoginPage.fnEnterPassword(password);
                clsPHPTravels_LoginPage.fnClickLoginButton();
                //clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Dashboard was not loaded correctly."); //Preguntar por este assert
                Console.WriteLine(clsPHPTravels_LoginPage.fnGetTotalAdminsHeader().Text);
                exTestStep.Log(Status.Info, clsPHPTravels_LoginPage.fnGetTotalAdminsHeader().Text);
                Console.WriteLine(clsPHPTravels_LoginPage.fnGetTotalSuppliers().Text);
                exTestStep.Log(Status.Info, clsPHPTravels_LoginPage.fnGetTotalSuppliers().Text);
                Console.WriteLine(clsPHPTravels_LoginPage.fnGetTotalCustomers().Text);
                exTestStep.Log(Status.Info, clsPHPTravels_LoginPage.fnGetTotalCustomers().Text);
                Console.WriteLine(clsPHPTravels_LoginPage.fnGetTotalGuests().Text);
                exTestStep.Log(Status.Info, clsPHPTravels_LoginPage.fnGetTotalGuests().Text);
                Console.WriteLine(clsPHPTravels_LoginPage.fnGetTotalBookings().Text);
                exTestStep.Log(Status.Info, clsPHPTravels_LoginPage.fnGetTotalBookings().Text);
                objRM.fnCaptureImage(driver, exTestStep);
                exTestStep.Pass("User login successfully");
            }
            catch (Exception ex)
            {
                objRM.fnCaptureImage(driver, exTestStep);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test Case Failed.");
                exTestStep.Fail($"Test Case failed with error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Test case successfully executed");
            }
        }

    }
}
