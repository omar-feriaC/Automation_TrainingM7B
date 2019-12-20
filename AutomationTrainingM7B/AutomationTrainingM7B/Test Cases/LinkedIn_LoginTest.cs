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


namespace AutomationTrainingM7B.Test_Cases
{
    class LinkedIn_LoginTest : BaseTest
    {
        public static LinkedIn_LoginPOM objLogin;
        public static LinkedInSearchPagePOM objSearch;
        WebDriverWait _objDriverWait;

        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                _objDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                objLogin = new LinkedIn_LoginPOM(driver);

                driver.Manage().Window.Maximize();
                objLogin.fnEnterUsername(username);
                objLogin.fnEnterPassword(password);
                objLogin.fnClickLoginButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("feed"));


                Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);
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
                objSearch.fnEnterDataInSearchTextField("4th Source\n");
                _objDriverWait.Until(ExpectedConditions.UrlContains("results"));
                objSearch.fnClickPeopleButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("people"));
                objSearch.fnClickAllFiltersButton();
                _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[@class='t-20 t-20--open t-black--light t-normal']")));
                objSearch.fnSelectMexicoCheckBox();

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
//*[@id="locations-facet-values"]/fieldset/ol/li[2]/label
