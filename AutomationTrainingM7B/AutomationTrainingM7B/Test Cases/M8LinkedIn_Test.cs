using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace AutomationTrainingM7B.Test_Cases
{
    class M8LinkedIn_Test : BaseTest
    {
        M8LinkedIn_LoginPage objLogin;
        M8LinkedIn_SearchPage objSearch;
        WebDriverWait _objDriverWait;

        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                objLogin = new M8LinkedIn_LoginPage(driver);

                objLogin.fnEnterUsername(strUsername);
                objLogin.fnEnterPassword(strPassword);
                objLogin.fnClickSignInButton();

                _objDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                _objDriverWait.Until(condition => driver.Url.Equals("https://www.linkedin.com/feed/"));

                Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);

                Console.WriteLine("Login done as expected");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test case failed.");
                Assert.Fail();
            }
        }

        [Test]
        public void LinkedIn_Search()
        {
            LinkedIn_Login();

            try
            {
                _objDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                objSearch = new M8LinkedIn_SearchPage(driver);

                objSearch.fnEnterSearch("Selenium");
                
                _objDriverWait.Until(ExpectedConditions.UrlContains("results"));
                _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='People' or text()='Gente']]")));

                objSearch.fnClickPeopleButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("people"));
                _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

                objSearch.fnClickAllFilterButton();      

                Thread.Sleep(1000);

                objSearch.fnEnterCountry("Italy");
                Thread.Sleep(500);
                objSearch.fnSelectItalyOption();
                Thread.Sleep(500);
                objSearch.fnClickMexicoCheckbox();
                objSearch.fnClickEnglishCheckbox();
                objSearch.fnClickSpanishCheckbox();
                objSearch.fnClickApplyButton();
                Thread.Sleep(1000);
                objSearch.fnMultipleSearch();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test case failed.");
                Assert.Fail();
            }
        }
    }
}
