using AutomationTrainingM7B.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        //Driver reference
        private static IWebDriver _objDriver;


        public LinkedIn_SearchPage(IWebDriver objDriver)
        {
            _objDriver = objDriver;
        }

        //Element of Search page
        private static readonly string strBuscarTxt_XPath = "//*[contains(@class,'search-global-typeahead__input')]";
        private static readonly string strBuscarBTN_XPath = "//*[contains(@class,'search-typeahead-v2__button')]";
        private static readonly string strFiltersBTN_Xpath = "//*[contains(@class,'search-filters-bar__all-filters')]";
        //Elements for filter section
        private static readonly string strCountryMxCHK_Xpath = "//*[contains(@class,'search-s-facet-value__label') and contains(@for,'sf-geoRegion-mx:0')]";
        //private static readonly string strCountryItCHK_Xpath = "//*[contains(@class,'search-s-facet-value__label') and contains(@for,'sf-geoRegion-it:0')]";
        private static readonly string strCountryItCHK_Xpath = "//*[contains(@class,'search-facet__value ')]";
        private static readonly string strApplyFilterBTN_Xpath = "//*[contains(@class,'search-advanced-facets__button--apply')]";


        //Objects for elements
        private static IWebElement objBuscarText => _objDriver.FindElement(By.XPath(strBuscarTxt_XPath));
        private static IWebElement objSearchActionBTN => _objDriver.FindElement(By.XPath(strBuscarBTN_XPath));
        private static IWebElement objFiltersBTN => _objDriver.FindElement(By.XPath(strFiltersBTN_Xpath));
        //Objects for filter
        private static IWebElement objCountryMxCHK => _objDriver.FindElement(By.XPath(strCountryMxCHK_Xpath));
        private static IWebElement objCountryItCHK => _objDriver.FindElement(By.XPath(strCountryItCHK_Xpath));
        private static IWebElement objApplyFilterBTN => _objDriver.FindElement(By.XPath(strApplyFilterBTN_Xpath));


        //GET element methods
        public IWebElement GetBuscarText()
        {
            return objBuscarText;
        }

        public IWebElement GetSearchAction()
        {
            return objSearchActionBTN;
        }

        public IWebElement GetFiltersButton()
        {
            return objFiltersBTN;
        }

        public IWebElement GetCountryMxButton()
        {
            return objCountryMxCHK;
        }

        public IWebElement GetCountryItButton()
        {
            return objCountryItCHK;
        }

        public IWebElement GetApplyFilterButton()
        {
            return objApplyFilterBTN;
        }

        //Actions for each element
        public void fnInsertSearch(string pstrInsertSearch)
        {
            objBuscarText.Clear();
            objBuscarText.SendKeys(pstrInsertSearch);
        }

        public void fnPerformSearch()
        {
            objSearchActionBTN.Click();
        }

        public void fnClickFiltersButton()
        {
            objFiltersBTN.Click();
        }

        public void fnSelectMex()
        {
            objCountryMxCHK.Click();
        }

        public void fnSelectItaly(string pstrItaly)
        {
            objCountryItCHK.Click();
            objCountryItCHK.Clear();
            objCountryItCHK.SendKeys(pstrItaly);            
        }

        public void fnApplyFilter()
        {
            objApplyFilterBTN.Click();
        }

    }
}