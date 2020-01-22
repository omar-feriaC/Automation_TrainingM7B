﻿using AutomationTrainingM7B.Reporting;
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

       

        public static ExtentTest exTestSuit;        
        public static ExtentTest exTestCase;

        /*Webdriver Intance*/
        public static clsDriver objclsDriver;
        public static IWebDriver driver;
        /*URL for Webdriver*/
        private static string strBrowserName = ConfigurationManager.AppSettings.Get("url");
        private static string strUserEmail = ConfigurationManager.AppSettings.Get("email");
        private static string strUserPassword = ConfigurationManager.AppSettings.Get("password");
        /*Extent Reports Framework*/
        public static clsReportManager objRM = new clsReportManager();
        public static ExtentV3HtmlReporter objHtmlReporter; //Add information in HTML
        public static ExtentReports objExtent; //Extent Reports Object
        public static ExtentTest objTest; // Test object for Extent Reports
        //public static ExtentHtmlReporter objHtmlReporter; //Old Version of HTML

        //**************************************************
        //                  M E T H O D S 
        //**************************************************
        //OneTimeSetUp before each class test
        [OneTimeSetUp]
        public static void fnBeforeClass()
        {
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
            exTestSuit = objExtent.CreateTest(TestContext.CurrentContext.Test.ClassName);
        }

        //OneTimeTearDown after each class test
        [OneTimeTearDown]
        public static void fnAfterClass()
        {
            objExtent.Flush();
        }

        [SetUp]
        //SetUp Before each test case
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = strBrowserName;
            driver.Manage().Window.Maximize();
            objclsDriver = new clsDriver(driver);
            //objTest = exTestSuit.CreateNode(TestContext.CurrentContext.Test.Name);
            exTestCase = exTestSuit.CreateNode(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        //TearDown After each test case
        public static void AfterTest()
        {
            //objRM.fnTestCaseResult(objTest, objExtent, driver);

            driver.Close();
            driver.Quit();
        }

        /*Clear and Send text to specific field*/
        public static void FnSendkeyAndClear(By by, string pstrText)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
        }


    }
}
