using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;



namespace AutomationTrainingM7B.Test_Cases
{
    class LinkedIn_LoginTest : BaseTest
    {
        public static LinkedIn_LoginPOM objLogin;
        public static LinkedInSearchPagePOM objSearch;
        WebDriverWait _objDriverWait;
        string strScreenshotPath;

        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                _objDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                exTestStep = exTestCase.CreateNode("Login", "Login to LinkedIn");
                objLogin = new LinkedIn_LoginPOM(driver);

                driver.Manage().Window.Maximize();
                objLogin.fnEnterUsername(username);
                objLogin.fnEnterPassword(password);
                objLogin.fnClickLoginButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("feed"));
                Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);
                exTestStep.Pass("User has logged successfully");

            }
            catch (Exception ex)
            {
                manager.fnCaptureImage(driver);
                exTestStep.Log(AventStack.ExtentReports.Status.Error, "Step has failed", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test Case Failed.");
                exTestStep.Fail($"Test Case failed with error: {ex.Message}");
                //Assert.Fail();
            }
            //catch(AssertionException x)
            //{
            //    Console.WriteLine("Exception due to assert.");
            //}
            finally
            {
                Console.WriteLine("Test case successfully executed");
            }
        }

            [Test]
        public void LinkedIn_SearchData()
        {
            try
            {
                _objDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
                objLogin = new LinkedIn_LoginPOM(driver);
                objSearch = new LinkedInSearchPagePOM(driver);


                driver.Manage().Window.Maximize();
                objLogin.fnEnterUsername(username);
                objLogin.fnEnterPassword(password);
                objLogin.fnClickLoginButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("feed"));
                
                Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);
                objSearch.fnEnterDataInSearchTextField("4th Source");
                _objDriverWait.Until(ExpectedConditions.UrlContains("results"));
                objSearch.fnClickPeopleButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("people"));
                objSearch.fnClickAllFiltersButton();
                _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[@class='t-20 t-20--open t-black--light t-normal']")));
                objSearch.fnSelectMexicoCheckBox();
                objSearch.fnAddValueToLocationTextBox("Italy");
                objSearch.fnSelectEnglishCheckBox();
                objSearch.fnSelectSpanishCheckBox();
                _objDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']")));
                objSearch.fnClickApplyAllFiltersButton();
                objSearch.fnMultipleSearch();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test Case Failed.");
                Assert.Fail();
            }
            //catch(AssertionException x)
            //{
            //    Console.WriteLine("Exception due to assert.");
            //}
            finally
            {
                Console.WriteLine("Test case successfully executed");
            }
        }
    }
}
