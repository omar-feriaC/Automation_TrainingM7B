using AutomationTrainingM7B.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class M8LinkedIn_SearchPage : BaseTest
    {
        private static IWebDriver _objDriver;

        public M8LinkedIn_SearchPage(IWebDriver objDriver)
        {
            _objDriver = objDriver;
        }

        public static readonly string STR_SEARCH_BAR_XPath = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        public static readonly string STR_SEARCH_BUTTON_XPath =  "//div[@class='search-global-typeahead__controls']";
        public static readonly string STR_PEOPLE_BUTTON_XPath = "//button[span[text()='People' or text()='Gente']]";
        public static readonly string STR_ALLFILTERS_BUTTON_XPath = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        public static readonly string STR_SEARCH_COUNTRY_XPath = "//input[@placeholder='Add a country/region']";
        public static readonly string STR_MEXICO_CHECKBOX_XPath = "//label[text()='Mexico' or text()='México']";
        public static readonly string STR_ENGLISH_CHECKBOX_XPath = "//label[text()='English' or text()='Ingles']";
        public static readonly string STR_SPANISH_CHECKBOX_XPath = "//label[text()='Spanish' or text()='Español']";
        public static readonly string STR_ITALY_OPTION_XPath = "//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";
        public static readonly string STR_APPLY_BUTTON_XPath = "//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']";
        public static readonly string STR_MEMBER_NAMES_XPath = "//span[@class='actor-name']";
        public static readonly string STR_MEMBER_ROLES_XPath = "//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']";
        public static readonly string STR_MEMBER_URLS_XPath = "//div[@class='search-result__info pt3 pb4 ph0']//a[@href]";

        private static IWebElement objSearchBar => _objDriver.FindElement(By.XPath(STR_SEARCH_BAR_XPath));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.XPath(STR_SEARCH_BUTTON_XPath));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BUTTON_XPath));
        private static IWebElement objAllFilterButton => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BUTTON_XPath));
        private static IWebElement objSearchCountryBar => _objDriver.FindElement(By.XPath(STR_SEARCH_COUNTRY_XPath));
        private static IWebElement objMexicoCheckbox => _objDriver.FindElement(By.XPath(STR_MEXICO_CHECKBOX_XPath));
        private static IWebElement objEnglishCheckbox => _objDriver.FindElement(By.XPath(STR_ENGLISH_CHECKBOX_XPath));
        private static IWebElement objSpanishCheckbox => _objDriver.FindElement(By.XPath(STR_SPANISH_CHECKBOX_XPath));
        private static IWebElement objItalyOption => _objDriver.FindElement(By.XPath(STR_ITALY_OPTION_XPath));
        private static IWebElement objApplyButton => _objDriver.FindElement(By.XPath(STR_APPLY_BUTTON_XPath));
        private static IList<IWebElement> objMemberNames;
        private static IList<IWebElement> objMemberRoles;
        private static IList<IWebElement> objMemberURLs;

        public IWebElement GetSearchBar()
        {
            return objSearchBar;
        }

        public IWebElement GetPeopleButton()
        {
            return objSearchButton;
        }

        public IWebElement GetAllFilterButton()
        {
            return objAllFilterButton;
        }

        public IWebElement GetSearchCountryBar()
        {
            return objSearchCountryBar;
        }

        public IWebElement GetMexicoCheckbox()
        {
            return objMexicoCheckbox;
        }

        public IWebElement GetEnglishCheckbox()
        {
            return objEnglishCheckbox;
        }

        public IWebElement GetSpanishCheckbox()
        {
            return objSpanishCheckbox;
        }

        public IWebElement GetItalyOption()
        {
            return objItalyOption;
        }

        public IWebElement GetApplyButton()
        {
            return objApplyButton;
        }

        public IList<IWebElement> GetMemberNames()
        {
            return objMemberNames;
        }

        public IList<IWebElement> GetMemberRoles()
        {
            return objMemberRoles;
        }

        public IList<IWebElement> GetMemberURLs()
        {
            return objMemberURLs;
        }

        public void fnEnterSearch(string strSearch)
        {
            objSearchBar.Clear();
            objSearchBar.SendKeys(strSearch);
            objSearchButton.Click();
        }

        public void fnClickPeopleButton()
        {
            objPeopleButton.Click();
        }

        public void fnClickAllFilterButton()
        {
            objAllFilterButton.Click();
        }

        public void fnEnterCountry(string strCountry)
        {
            objSearchCountryBar.Click();
            objSearchCountryBar.Clear();
            objSearchCountryBar.SendKeys(strCountry);      
        }

        public void fnSelectItalyOption()
        {
            objItalyOption.Click();
        }

        public void fnClickMexicoCheckbox()
        {
            objMexicoCheckbox.Click();
        }

        public void fnClickEnglishCheckbox()
        {
            objEnglishCheckbox.Click();
        }

        public void fnClickSpanishCheckbox()
        {
            objSpanishCheckbox.Click();
        }

        public void fnClickApplyButton()
        {
            objApplyButton.Click();
        }

        public void fnMultipleSearch()
        {
            string[] arrTechnologies = { "Java", "C", "Phyton", "Pega", "C#" };

             for (int i = 0; i < arrTechnologies.Length; i++)
            {
                fnEnterSearch(arrTechnologies[i]);

                Thread.Sleep(1000);

                objMemberNames = _objDriver.FindElements(By.XPath(STR_MEMBER_NAMES_XPath));
                objMemberRoles = _objDriver.FindElements(By.XPath(STR_MEMBER_ROLES_XPath));
                objMemberURLs = _objDriver.FindElements(By.XPath(STR_MEMBER_URLS_XPath));

                for (int j = 0; j < objMemberNames.Count; j++)
                {
                    Console.WriteLine("Name: {0}", objMemberNames[j].Text);
                    Console.WriteLine("Role: {0}", objMemberRoles[j].Text);
                    Console.WriteLine("URL: {0}", objMemberURLs[j].GetAttribute("href"));
                    Console.WriteLine();
                }
            }
        }
    }
}
