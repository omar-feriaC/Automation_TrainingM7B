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
        private static readonly string strFiltersBTN_Xpath = "//*[contains(@class,'search-filters-bar__all-filters')]";
        //Elements for filter section
        private readonly static string strLocationInputTxt_Xpath = "//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región']";
        private static readonly string strApplyFilterBTN_Xpath = "//*[contains(@class,'search-advanced-facets__button--apply')]";       
        //Filter for technologies
        private static readonly string strResultsSearch_Xpath = "//*[contains(@class,'search-result__occluded-item')]";
        private static readonly string strGetName_Xpath = "//*[contains(@class,'actor-name')]";
        private static readonly string strGetRole_Xpath = "//*[contains(@class,'subline-level-1')]";
        private static readonly string strGetLink_Xpath = "//*[contains(@class,'search-result__result-link')]";

        //Objects for elements
        private static IWebElement objBuscarText => _objDriver.FindElement(By.XPath(strBuscarTxt_XPath));
        private static IWebElement objFiltersBTN => _objDriver.FindElement(By.XPath(strFiltersBTN_Xpath));     
        //Objects for filter
        private static IWebElement objLocationInputText => _objDriver.FindElement(By.XPath(strLocationInputTxt_Xpath));
        private static IWebElement objApplyFilterBTN => _objDriver.FindElement(By.XPath(strApplyFilterBTN_Xpath));        
        //Filter for technologies
        private static IList<IWebElement> objResultSearchTechnologyLST => _objDriver.FindElements(By.XPath(strResultsSearch_Xpath));
        private static IWebElement objResultNameLST => _objDriver.FindElement(By.XPath(strGetName_Xpath));
        private static IWebElement objResultRoleLST => _objDriver.FindElement(By.XPath(strGetRole_Xpath));
        private static IWebElement objResultLinkLST => _objDriver.FindElement(By.XPath(strGetLink_Xpath));


        //GET element methods
        public IWebElement GetBuscarText()
        {
            return objBuscarText;
        }

        public IWebElement GetFiltersButton()
        {
            return objFiltersBTN;
        }

        public IWebElement GetLocationInputText()
        {
            return objLocationInputText;
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

        public void fnInsertSearch(string pstrInsertSearch)
        {
            objBuscarText.Clear();
            objBuscarText.SendKeys(pstrInsertSearch);
            objBuscarText.SendKeys(Keys.Enter);
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

        public void fnApplyFilter()
        {
            objApplyFilterBTN.Click();
            Thread.Sleep(2000);
        }

        public void fnSearchByTechnologies()
        {
            string[] arrTechnologies = new string[] { "Java", "C Program", "Phyton", "Pega", "C#" };
            for (int i = 0; i < arrTechnologies.Count(); i++)
            {
                strSearch = arrTechnologies.ElementAt(i);
                fnInsertSearch(strSearch);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(strSearch + " Displaying = " + objResultSearchTechnologyLST.Count() + " results");
                Console.WriteLine("Name: " + objResultNameLST.Text.ToString());
                Console.WriteLine("Role: " + objResultRoleLST.Text.ToString());
                Console.WriteLine("Link URL Profile: " + GetResultLink().GetAttribute("href"));
                Thread.Sleep(3000);

            }
        }

    }
}