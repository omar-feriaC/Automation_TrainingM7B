using AutomationTrainingM7B.Base_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AutomationTrainingM7B.Page_Objects
{
    class M8LinkedIn_Page_POM : BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        public M8LinkedIn_Page_POM(IWebDriver objDriver)
        {

            _objDriver = objDriver;
        }

        /*ELEMENT LOCATORS*/

        private static readonly string STR_USERNAME_TEXTFIELD = "username";
        private static readonly string STR_PASSWORD_TEXTFIELD = "password";
        private static readonly string STR_LOGIN_BUTTON = "//*[text()='Iniciar sesión' or text()='Sign in']";

        /*PAGE ELEMENT OBJECTS*/

        private static IWebElement objUsername => _objDriver.FindElement(By.Id(STR_USERNAME_TEXTFIELD));
        private static IWebElement objPasswrod => _objDriver.FindElement(By.Id(STR_PASSWORD_TEXTFIELD));
        private static IWebElement objLoginButton => _objDriver.FindElement(By.XPath(STR_LOGIN_BUTTON));

        /*GET ELEMENT METHODS*/

        public IWebElement GetUsername()
        {
            return objUsername;
        }
        public IWebElement GetPassword()
        {
            return objPasswrod;
        }
        public IWebElement GetLoginButton()
        {
            return objLoginButton;
        }

        /*PAGE ELEMENT ACTIONS*/

        public void fnUsernameText(string pstrUsername)
        {
            objUsername.Clear();
            objUsername.SendKeys(pstrUsername);
        }

        public void fnPasswordText(string pstrPassword)
        {
            objPasswrod.Clear();
            objPasswrod.SendKeys(pstrPassword);
        }

        public void fnLoginButton()
        {
            objLoginButton.Click();
        }

    }
}
