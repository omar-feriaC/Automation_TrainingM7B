using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationTrainingM7B.Base_Files;
using System.Threading;

namespace AutomationTrainingM7B.Page_Objects
{
    class LinkedInSearchPagePOM:BaseTest
    {
        private static IWebDriver _objDriver;

        public LinkedInSearchPagePOM(IWebDriver driver)
        {
            _objDriver = driver;
        }

        /*ELEMENT LOCATORS*/
        private static readonly string str_search_textfield_Xpath = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        private static readonly string str_people_button_Xpath = "//button[@class='search-vertical-filter__filter-item-button artdeco-button artdeco-button--muted artdeco-button--2 artdeco-button--tertiary ember-view']";
        private static readonly string str_allFilters_button_Xpath = "//button[@class='search-filters-bar__all-filters flex-shrink-zero mr3 artdeco-button artdeco-button--muted artdeco-button--2 artdeco-button--tertiary ember-view']";
        private static readonly string str_Mexico_checkbox_Xpath = "//*[@class='search-s-facet__values search-s-facet__values--geoRegion']//descendant::li[2]//descendant::input//following::label[text()='Mexico']";
        private static readonly string str_Italy_checkbox_Xpath = "//*[@class='search-s-facet__values search-s-facet__values--geoRegion']//descendant::li[2]//descendant::input//following::label[text()='Italy']";
        private static readonly string str_Italy_ListOption_Xpath = "//div/id[contains(@id, 'triggered-expanded-ember')][text()='Italy']";
        private static readonly string str_Location_textbox_Xpath = "//input[@placeholder='Add a country/region']";
        private static readonly string str_English_Checkbox_Xpath = "//*[@class='search-s-facet__values search-s-facet__values--profileLanguage']//descendant::li[1]//descendant::input//following::label[1]";
        private static readonly string str_Spanish_Checkbox_Xpath = "//*[@class='search-s-facet__values search-s-facet__values--profileLanguage']//descendant::li[1]//descendant::input//following::label[2]";
        private static readonly string str_ApplyFilters_button_Xpath = "//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']//following::span[1][text()='Apply']";
        private static readonly string str_member_name_Xpath = "//span[@class='actor-name']";
        private static readonly string str_member_roles_Xpath = "//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']";
        private static readonly string str_member_urls_Xpath = "//div[@class='search-result__info pt3 pb4 ph0']//a[@href]";

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objSearchTextField => _objDriver.FindElement(By.XPath(str_search_textfield_Xpath));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(str_people_button_Xpath));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(str_allFilters_button_Xpath));
        private static IWebElement objMexicoCheckbox => _objDriver.FindElement(By.XPath(str_Mexico_checkbox_Xpath));
        private static IWebElement objItalyCheckbox => _objDriver.FindElement(By.XPath(str_Italy_checkbox_Xpath));
        private static IWebElement objItalyListOption => _objDriver.FindElement(By.XPath(str_Italy_ListOption_Xpath));
        private static IWebElement objLocationTextbox => _objDriver.FindElement(By.XPath(str_Location_textbox_Xpath));
        private static IWebElement objEnglishCheckBox => _objDriver.FindElement(By.XPath(str_English_Checkbox_Xpath));
        private static IWebElement objSpanishCheckBox => _objDriver.FindElement(By.XPath(str_Spanish_Checkbox_Xpath));
        private static IWebElement objApplyFiltersButton => _objDriver.FindElement(By.XPath(str_ApplyFilters_button_Xpath));
        private static IList<IWebElement> objMemberNames;
        private static IList<IWebElement> objMemberRoles;
        private static IList<IWebElement> objMemberUrls;

        /*GET ELEMENT METHODS*/
        public IWebElement GetSearchTextField()
        {
            return objSearchTextField;
        }

        public IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }

        public IWebElement GetAllFiltersButton()
        {
            return objAllFiltersButton;
        }
        
        public IWebElement GetMexicoCheckbox()
        {
            return objMexicoCheckbox;
        }

        public IWebElement GetItalyCheckbox()
        {
            return objItalyCheckbox;
        }

        public IWebElement GetItalyListOption()
        {
            return objItalyListOption;
        }

        public IWebElement GetLocationTextBox()
        {
            return objLocationTextbox;
        }

        public IWebElement GetEnglishCheckbox()
        {
            return objEnglishCheckBox;
        }

        public IWebElement GetSpanishCheckbox()
        {
            return objSpanishCheckBox;
        }

        public IWebElement GetApplyAllFiltersButton()
        {
            return objApplyFiltersButton;
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
            return objMemberUrls;
        }

        /*ELEMENT ACTIONS*/
        public void fnEnterDataInSearchTextField(string pstrSearchFieldData)
        {
            objSearchTextField.Clear();
            objSearchTextField.SendKeys(pstrSearchFieldData);
            objSearchTextField.SendKeys(Keys.Enter);
        }

        public void fnClickPeopleButton()
        {
            objPeopleButton.Click();
        }

        public void fnClickAllFiltersButton()
        {
            objAllFiltersButton.Click();
        }

        public void fnSelectMexicoCheckBox()
        {
            objMexicoCheckbox.Click();
        }

        public void fnSelectItalyCheckBox()
        {
            objItalyCheckbox.Click();
        }

        public void fnSelectItalyListOption()
        {
            objItalyListOption.Click();
        }

        public void fnAddValueToLocationTextBox(string pstrLocationTextBox)
        {
            objLocationTextbox.SendKeys(pstrLocationTextBox);
            Thread.Sleep(500);
            objLocationTextbox.SendKeys(Keys.ArrowDown);
            objLocationTextbox.SendKeys(Keys.Enter);
        }

        public void fnSelectEnglishCheckBox()
        {
            objEnglishCheckBox.Click();
        }

        public void fnSelectSpanishCheckBox()
        {
            objSpanishCheckBox.Click();
        }

        public void fnClickApplyAllFiltersButton()
        {
            objApplyFiltersButton.Click();
        }

        public void fnMultipleSearch()
        {
            string[] arrTechnologies = { "Java", "C", "Phyton", "Pega", "C#" };

            for (int i = 0; i < arrTechnologies.Length; i++)
            {
                fnEnterDataInSearchTextField(arrTechnologies[i]);

                Thread.Sleep(1000);

                objMemberNames = _objDriver.FindElements(By.XPath(str_member_name_Xpath));
                objMemberRoles = _objDriver.FindElements(By.XPath(str_member_roles_Xpath));
                objMemberUrls = _objDriver.FindElements(By.XPath(str_member_urls_Xpath));

                for (int j = 0; j < objMemberNames.Count; j++)
                {
                    Console.WriteLine("Name: {0}", objMemberNames[j].Text);
                    Console.WriteLine("Role: {0}", objMemberRoles[j].Text);
                    Console.WriteLine("URL: {0}", objMemberUrls[j].GetAttribute("href"));
                    Console.WriteLine();
                }
            }
        }
    }
}
