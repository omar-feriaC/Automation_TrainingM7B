using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationTrainingM7B.Base_Files;

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
        private static readonly string str_Mexico_checkbox_Xpath = "//*[@class='search-s-facet__values search-s-facet__values--geoRegion']//descendant::li[2]//descendant::input//following::label";

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objSearchTextField => _objDriver.FindElement(By.XPath(str_search_textfield_Xpath));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(str_people_button_Xpath));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(str_allFilters_button_Xpath));
        private static IWebElement objMexicoCheckbox => _objDriver.FindElement(By.XPath(str_Mexico_checkbox_Xpath));

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
    }
}
