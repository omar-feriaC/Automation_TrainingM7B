using AutomationTrainingM7B.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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
        private static readonly string strBuscarBTN_XPath = "//*[contains(@class,'search-global-typeahead__button')]";//"//*[contains(@class,'search-typeahead-v2__button')]";
        private static readonly string strFiltersBTN_Xpath = "//*[contains(@class,'search-filters-bar__all-filters')]";

        //Elements for filter section
        readonly static string strPeopleDRP_Xpath = "//*[contains(@class,'search-vertical-filter__dropdown-trigger-text')]";
        readonly static string strSelectPeople_Xpath = "//*[contains(@class,'search-vertical-filter__filter-item-button') and @aria-label='Ver solo resultados de Gente.' or @aria-label='View only People results']";
        private readonly static string strLocationInputTxt_Xpath = "//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región']";
        private static readonly string strCountryMxCHK_Xpath = "//*[contains(@class,'search-s-facet-value__label') and contains(@for,'sf-geoRegion-mx:0')]";
        
        //private static readonly string strCountryItCHK_Xpath = "//*[contains(@class,'search-s-facet-value__label') and contains(@for,'sf-geoRegion-it:0')]";
        private static readonly string strCountryItCHK_Xpath = "//*[contains(@class,'search-facet__value ')]";
        private static readonly string strApplyFilterBTN_Xpath = "//*[contains(@class,'search-advanced-facets__button--apply')]";
        
        //Filter for technologies
        private static readonly string strFilterTechnologiesBTN_Xpath = "//*[contains(@class,'search-global-typeahead__controls')]";
        private static readonly string strResultsSearch_Xpath = "//*[contains(@class,'search-result__occluded-item')]";//Container of list of results
        private static readonly string strGetName_Xpath = "//*[contains(@class,'actor-name')]";//Get Name
        private static readonly string strGetRole_Xpath = "//*[contains(@class,'subline-level-1')]";//Get Role
        private static readonly string strGetLink_Xpath = "//*[contains(@class,'search-result__result-link')]";//Get Link

        //Objects for elements
        private static IWebElement objBuscarText => _objDriver.FindElement(By.XPath(strBuscarTxt_XPath));
        private static IWebElement objSearchActionBTN => _objDriver.FindElement(By.XPath(strBuscarBTN_XPath));
        private static IWebElement objFiltersBTN => _objDriver.FindElement(By.XPath(strFiltersBTN_Xpath));
        
        //Objects for filter
        private static IWebElement objSelectPeopleDRP => _objDriver.FindElement(By.XPath(strPeopleDRP_Xpath));
        private static IWebElement objSelectPeopleBTN => _objDriver.FindElement(By.XPath(strSelectPeople_Xpath));
        private static IWebElement objLocationInputText => _objDriver.FindElement(By.XPath(strLocationInputTxt_Xpath));
        private static IWebElement objCountryMxCHK => _objDriver.FindElement(By.XPath(strCountryMxCHK_Xpath));
        private static IWebElement objCountryLocationjCHK => _objDriver.FindElement(By.XPath(strCountryItCHK_Xpath));
        private static IWebElement objApplyFilterBTN => _objDriver.FindElement(By.XPath(strApplyFilterBTN_Xpath));
        
        //Filter for technologies
        private static IWebElement objApplyFilterTechnologyBTN => _objDriver.FindElement(By.XPath(strFilterTechnologiesBTN_Xpath));
        private static IList<IWebElement> objResultSearchTechnologyLST => _objDriver.FindElements(By.XPath(strResultsSearch_Xpath));
        private static IWebElement objResultNameLST => _objDriver.FindElement(By.XPath(strGetName_Xpath));
        private static IWebElement objResultRoleLST => _objDriver.FindElement(By.XPath(strGetRole_Xpath));
        private static IWebElement objResultLinkLST => _objDriver.FindElement(By.XPath(strGetLink_Xpath));


        //GET element methods
        public IWebElement GetBuscarText()
        {
            return objBuscarText;
        }

        public IWebElement GetSearchAction()
        {
            return objSearchActionBTN;
        }

        public IWebElement GetBropDownElementPeople()
        {
            return objSelectPeopleDRP;
        }
        public IWebElement GetButtonElementPeople()
        {
            return objSelectPeopleBTN;
        }

        public IWebElement GetFiltersButton()
        {
            return objFiltersBTN;
        }

        public IWebElement GetLocationInputText()
        {
            return objLocationInputText;
        }

        public IWebElement GetCountryMxButton()
        {
            return objCountryMxCHK;
        }

        public IWebElement GetCountryItButton()
        {
            return objCountryLocationjCHK;
        }

        public IWebElement GetApplyFilterButton()
        {
            return objApplyFilterBTN;
        }

        public IList<IWebElement> GetResultsSearchTechnology()
        {
            return objResultSearchTechnologyLST;
        }

        public IWebElement GetResultName()
        {
            return objResultNameLST;
        }

        public IWebElement GetResultRole()
        {
            return objResultRoleLST;
        }

        public IWebElement GetResultLink()
        {
            return objResultLinkLST;
        }

        //Actions for each element

        public void fnClickSearchTextBox()
        {
            //objBuscarText.Submit();
            objBuscarText.Click();
        }

        public void fnInsertSearch(string pstrInsertSearch)
        {
            objBuscarText.Clear();
            objBuscarText.SendKeys(pstrInsertSearch);
            objBuscarText.SendKeys(Keys.Enter);
        }

        public void fnPerformSearch()
        {
            objSearchActionBTN.Click();
        }

        public void fnSelectPeopleBTN()
        {
            objSelectPeopleDRP.Click();
            objSelectPeopleBTN.Click();
        }

        public void fnClickFiltersButton()
        {
            objFiltersBTN.Click();
        }

        public void fnInsertSearchLocation(string pstrLocation)
        {
            objLocationInputText.Clear();
            objLocationInputText.SendKeys(pstrLocation);
            Thread.Sleep(2000);
            objLocationInputText.SendKeys(Keys.ArrowDown);
            objLocationInputText.SendKeys(Keys.Enter);
        }

        public void fnSelectMex()
        {
            objCountryMxCHK.Click();
        }

        public void fnSelectItaly(string pstrLocation)
        {
            objCountryLocationjCHK.Click();
            objCountryLocationjCHK.Clear();
            objCountryLocationjCHK.SendKeys(pstrLocation);            
        }

        public void fnApplyFilter()
        {
            objApplyFilterBTN.Click();
        }

        public void fnSearchByTechnologies()
        {
            //****Search for each technology
            fnClickSearchTextBox();
            string[] arrTechnologies = new string[] { "Java", "C Program", "Phyton", "Pega", ".NET" };
            //string[] arrTechnologies = new string[] { "Java" };
            //foreach (string Technologies in arrTechnologies)
            //{
            //    strSearch = Technologies;
            //    fnInsertSearch(strSearch);
            //    //objApplyFilterTechnologyBTN.Click();
            //    Thread.Sleep(2000);

            //}

            for (int i = 0; i < arrTechnologies.Count(); i++)
            {
                strSearch = arrTechnologies.ElementAt(i);
                fnInsertSearch(strSearch);
                //objApplyFilterTechnologyBTN.Click();
                
                Console.WriteLine(strSearch +" With a total of = "+ objResultSearchTechnologyLST.Count() +" results");                
                //for ( int e=0; e<= 5; e++)
                //foreach(char psrtResult in objResultSearchTechnologyLST.ToString())
                //{
                    Console.WriteLine("Link: " + objResultLinkLST.Text.ToString());
                    Console.WriteLine("Name: "+ objResultNameLST.Text.ToString());
                    Console.WriteLine("Role: " + objResultRoleLST.Text.ToString());                    
                //}
                Thread.Sleep(2000);

            }
        }

    }
}