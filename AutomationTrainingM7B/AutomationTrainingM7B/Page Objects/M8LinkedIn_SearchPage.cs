using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using OpenQA.Selenium;

namespace AutomationTrainingM7B.Page_Objects
{
    class M8LinkedIn_SearchPage : BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        public M8LinkedIn_SearchPage(IWebDriver objDriver)
        {

            _objDriver = objDriver;
        }

        /*ELEMENT LOCATORS*/

        private static readonly string STR_SEARCH_TEXTFIELD = "global-nav-typeahead";
        private static readonly string STR_SEARCH_BUTTON = "search-global-typeahead__controls";
        //private static readonly string STR_LOGIN_BUTTON = "//*[text()='Iniciar sesión' or text()='Sign in']";

        /*PAGE ELEMENT OBJECTS*/

        private static IWebElement objSearchTextField => _objDriver.FindElement(By.Id(STR_SEARCH_TEXTFIELD));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.ClassName(STR_SEARCH_BUTTON));
        //private static IWebElement objLoginButton => _objDriver.FindElement(By.XPath(STR_LOGIN_BUTTON));

        /*GET ELEMENT METHODS*/

        public IWebElement GetSearchTextField()
        {
            return objSearchTextField;
        }
        public IWebElement GetSearchButton()
        {
            return objSearchButton;
        }
        //public IWebElement GetLoginButton()
        //{
        //    return objLoginButton;
        //}

        /*PAGE ELEMENT ACTIONS*/

        public void fnSearchText(string pstrSearchString)
        {
            objSearchTextField.Clear();
            objSearchTextField.SendKeys(pstrSearchString);
        }

        public void fnSearchButton()
        {
            objSearchButton.Click();
        }

        //public void fnLoginButton()
        //{
        //    objLoginButton.Click();
        //}


    }
}
