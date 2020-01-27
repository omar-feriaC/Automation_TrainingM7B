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
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace AutomationTrainingM7B.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        string sreenPath;
        public static WebDriverWait _driverWait;
        


        [Test, Order(1)]
        public void Test_M9Exercise()
        {
            try
            {
                //**********************************************
                //  DASHBOARD ELEMENTS IN RED BOX             //
                //**********************************************
                objTest = exTestCase.CreateNode("DASHBOARD", "ELEMENTS IN RED BOX");
                //Init objects
                objPHP = new clsPHPTravels_LoginPage(driver);
                //Login Action
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
                clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
                clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
                clsPHPTravels_LoginPage.fnClickLoginButton();
                //_driverWait.Until(ExpectedConditions.UrlContains("admin"));

                objPHP.fnGoThroughListElments();
                objPHP.fnDashboardElementsInRedBoxForReport();
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
        
        [Test, Order(2)]
        public void Test_SideBarMenu()
        {

            Test_M9Exercise();
            try
            {   //***********************************************
                //   METHOD PARAMETERS: Updates -- General     //
                //***********************************************
                objTest = exTestCase.CreateNode("SIDE BAR MENU", "MENU OPTION");               
                objPHP.fnSideBarMenuElementOptions("Updates");
                objPHP.fnDashboardElementButton();               
                //Screenshot
                sreenPath = objRM.fnCaptureImage(driver, "SSMenuOption.png");
                objTest.Log(AventStack.ExtentReports.Status.Pass, "Step ScreenShot :", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
            }
            catch (Exception e)
            {
                if (!driver.Title.Equals("Updates")) { 

                Assert.AreEqual(true, driver.Title.Contains("https://www.phptravels.net/admin/updates/ "), "Page was not loaded correctly.");
                _driverWait.Until(ExpectedConditions.UrlContains("Updates"));
                sreenPath = objRM.fnCaptureImage(driver, "Screenshot.png");
                Console.WriteLine(e.Message);
                Console.WriteLine("Test Case Failed");
                exTestCase.Fail($"Test Case Failed Erro: {e.Message}");
                }

                if (!driver.Title.Equals("Application Settings")) { 
                Assert.AreEqual(true, driver.Title.Contains("https://www.phptravels.net/admin/settings/"), "Page was not loaded correctly.");
                _driverWait.Until(ExpectedConditions.UrlContains("Updates"));
                sreenPath = objRM.fnCaptureImage(driver, "Screenshot.png");
                Console.WriteLine(e.Message);
                Console.WriteLine("Test Case Failed");
                exTestCase.Fail($"Test Case Failed Erro: {e.Message}");
                }                
            }
        }
        [Test, Order(3)]
        public void Test_SortAccountsOption()
        {
            Test_M9Exercise();
            try
            {
                //***********************************************
                //      ACCOUNT-SUBMENU OPTION -SORTING        //
                //***********************************************
                objTest = exTestCase.CreateNode("ACCOUNT", "CUSTOMERS SUB-MENU TO SORT");
                objPHP = new clsPHPTravels_LoginPage(driver);
                objPHP.fnSortAccountSubMenu();
                //Screenshot
                sreenPath = objRM.fnCaptureImage(driver, "SSMenuOption.png");
                objTest.Log(AventStack.ExtentReports.Status.Pass, "Step ScreenShot :", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, driver.Title.Contains("Customer Management"), "The Dashboard was not loaded correctly.");
                objTest.Log(AventStack.ExtentReports.Status.Error, "Step has failed with SS", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test Case Failed");
                exTestCase.Fail($"Test Case Failed Erro: {ex.Message}");
            }
        }

    }
    
}
