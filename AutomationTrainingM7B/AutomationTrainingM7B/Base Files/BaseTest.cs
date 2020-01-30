using AutomationTrainingM7B.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Base_Files
{
    class BaseTest
    {
        //**************************************************
        //*                V A R I A B L E S
        //**************************************************

        /*Webdriver Instance*/
        public static clsDriver objclsDriver;
        public static IWebDriver driver;
        public string url;
        public string email;
        public string password;


        /*Extent Reports Framework*/
        public static clsReportManager objRM;
        public static ExtentV3HtmlReporter objHtmlReporter; //Add information in HTML
        public static ExtentReports objExtent; //Extent Reports Object

        public static ExtentTest exTestSuite;
        public static ExtentTest objTest; // Test object for Extent Reports
        public static ExtentTest exTestStep;

        //public static ExtentHtmlReporter objHtmlReporter; //Old Version of HTML



        //**************************************************
        //                  M E T H O D S 
        //**************************************************
        //OneTimeSetUp before each class test
        [OneTimeSetUp]
        public void fnBeforeAllTest()
        {
            email = ConfigurationManager.AppSettings.Get("email");
            password = ConfigurationManager.AppSettings.Get("password");
            url = ConfigurationManager.AppSettings.Get("url");

            objRM = new clsReportManager();

            /*Init ExtentHtmlReporter object*/
            if (objHtmlReporter == null)
            {
                objHtmlReporter = new ExtentV3HtmlReporter(objRM.fnReportPath());
            }
            /*Init ExtentReports object*/
            if (objExtent == null)
            {
                objExtent = new ExtentReports();
                
            }
            objRM.fnReportSetUp(objHtmlReporter, objExtent);
        }

        [SetUp]
        //SetUp Before each test case
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = url;
            driver.Manage().Window.Maximize();
            objclsDriver = new clsDriver(driver);
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

        }

        [TearDown]
        //TearDown After each test case
        public static void AfterTest()
        {
            objRM.fnTestCaseResult(objTest, objExtent, driver);
            driver.Close();
            driver.Quit();
        }

        //OneTimeTearDown after each class test
        [OneTimeTearDown]
        public void fnAfterClass()
        {
            objExtent.Flush();
        }


        /*Clear and Send text to specific field*/
        public static void FnSendkeyAndClear(By by, string pstrText)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
        }


    }
}
