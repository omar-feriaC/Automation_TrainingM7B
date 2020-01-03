﻿using NUnit.Framework;
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
        /*ATTRIBUTES*/
        public static IWebDriver objDriver;
        protected static string strUserName = ConfigurationManager.AppSettings.Get("username");
        protected static string strPassword = ConfigurationManager.AppSettings.Get("password");
        protected static string strUrl = ConfigurationManager.AppSettings.Get("url");
        protected static string strSearch = ConfigurationManager.AppSettings.Get("search");
        protected static string strItaly = ConfigurationManager.AppSettings.Get("italy");
        protected static string strMex1 = ConfigurationManager.AppSettings.Get("mex1");
        protected static string strMex2 = ConfigurationManager.AppSettings.Get("mex2");
        protected static string strPeople = ConfigurationManager.AppSettings.Get("urlPeople");

        /*METHOD/FUNCTIONS*/
        [SetUp]
        public static void SetupDriver()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            objDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public static void ExitDriver()
        {
            //***Exit of Browser commented in order to avoid close and see results***

            //objDriver.Close();
            //objDriver.Quit();
        }



    }
}
