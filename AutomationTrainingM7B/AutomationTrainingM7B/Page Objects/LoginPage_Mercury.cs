using AutomationTrainingM7B.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class LoginPage_Mercury : BaseTest
    {
        /*DRIVER REFERENCE FOR THIS PARTICULAR POM*/
        private static IWebDriver _driver;

        /*LOCATORS FOR EACH AND EVERY ELEMENT IN PAGE*/
        readonly static string strUserName_Txt = "userName";
        readonly static string strPassword_Txt = "password";
        readonly static string strSignIn_Btn = "//input[@name='login']";
        
        /*POM FILE CONSTRUCTOR BY TAKING AS PARAMETER "DRIVER" FROM BASETEST CLASS*/
        public LoginPage_Mercury(IWebDriver pobjDriver)
        {
            _driver = pobjDriver;
        }

        /*LOCATORS VALUES STORED AS IWebElement OBJECTS TO BE USED IN FRAMEWORK THROUGH METHODS FROM THIS POM CLASS*/
        private static IWebElement objUserName_Txt => _driver.FindElement(By.Name(strUserName_Txt));
        private static IWebElement objPassword_Txt => _driver.FindElement(By.Name(strPassword_Txt));
        private static IWebElement objSignIn_Btn => _driver.FindElement(By.XPath(strSignIn_Btn));

    }
}
