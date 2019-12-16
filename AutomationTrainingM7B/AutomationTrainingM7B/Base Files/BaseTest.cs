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
        /*ATTRIBUTES*/
        public static IWebDriver objDriver;
        protected static string strUserName = Environment.GetEnvironmentVariable("username", EnvironmentVariableTarget.User);
        protected static string strPassword = Environment.GetEnvironmentVariable("password", EnvironmentVariableTarget.User);
        protected static string strUrl = Environment.GetEnvironmentVariable("url", EnvironmentVariableTarget.User);

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
            objDriver.Close();
            objDriver.Quit();
        }



    }
}
