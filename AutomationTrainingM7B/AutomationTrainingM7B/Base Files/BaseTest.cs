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
        public IWebDriver driver;
        public string strUsername = ConfigurationManager.AppSettings.Get("username");
        public string strPassword = ConfigurationManager.AppSettings.Get("password");
        public string strUrl = ConfigurationManager.AppSettings.Get("url");

        /*METHOD/FUNCTIONS*/
        [SetUp]
        public void SetupDriver()
        {
            driver = new ChromeDriver();
            driver.Url = strUrl;
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void ExitDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
