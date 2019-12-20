using AutomationTrainingM7B.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class M8LinkedIn_Page : BaseTest
    {
        //Driver reference
        private static IWebDriver _objDriver;

        public M8LinkedIn_Page(IWebDriver objDriver)
        {
            _objDriver = objDriver;
        }

        //Element of login page
        private static readonly string strUserNameTXT_Id = "username";
        private static readonly string strPasswordTXT_Id = "password";
        private static readonly string strLoginBTN_XPath = "//*[text()='Iniciar sesión' or text()='Sign in']";

        //Objects for elements
        private static IWebElement objUsernameText => _objDriver.FindElement(By.Id(strUserNameTXT_Id));
        private static IWebElement objPasswordText => _objDriver.FindElement(By.Id(strPasswordTXT_Id));
        private static IWebElement objLoginButton => _objDriver.FindElement(By.XPath(strLoginBTN_XPath));

        //GET element methods
        public IWebElement GetUserNameField()
        {
            return objUsernameText;
        }

        public IWebElement GetPasswordField()
        {
            return objPasswordText;
        }

        public IWebElement GetLoginButton()
        {
            return objLoginButton;
        }

        //Actions for each element
        public void fnEnterUsername(string pstrUsername)
        {
            objUsernameText.Clear();
            objUsernameText.SendKeys(pstrUsername);

        }

        public void fnEnterPassword(string pstrPassword)
        {
            objPasswordText.Clear();
            objPasswordText.SendKeys(pstrPassword);
        }

        public void fnClickLogin()
        {
            objLoginButton.Click();
        }

    }
}
