using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationTrainingM7B.Base_Files
{
    class BaseTest
    {
        /*ATTRIBUTES*/
        public IWebDriver driver;
        public string url;
        public string username;
        public string password;

        [OneTimeSetUp]
        public void BeforeAllTest()
        {
            username = ConfigurationManager.AppSettings.Get("username");
            password = ConfigurationManager.AppSettings.Get("password");
            url = ConfigurationManager.AppSettings.Get("url");
        }

        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Url = url;
        }

        [TearDown]
        public void AfterTest()
        {
            //driver.Close();
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            //driver.Quit();
        }
        /*METHOD/FUNCTIONS*/
        /*[SetUp]
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
        */


    }
}
