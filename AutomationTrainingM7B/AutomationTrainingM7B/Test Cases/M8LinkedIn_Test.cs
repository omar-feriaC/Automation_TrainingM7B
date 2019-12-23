using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Test_Cases
{
    class M8LinkedIn_Test : BaseTest
    {
        //Declare Objects
        public static M8LinkedIn_Page objLogin;
        public static LinkedIn_SearchPage objSearch;
        public static WebDriverWait _objDriverWait;


        //Methods to use for test cases
        [Test]
        public void LinkedInLogin()
        {
            try //To Detect if it was a successfull test
            {
                //Initiate the object to use methods
                objLogin = new M8LinkedIn_Page(objDriver);

                //Calling methods to execute on the test
                objLogin.fnEnterUsername(strUserName);
                objLogin.fnEnterPassword(strPassword);
                objLogin.fnClickLogin();

                //Verifying that the Login was successfull
                //Assert.AreEqual("https://www.linkedin.com/feed/", objDriver.Url);

                /******************************* - EXAM PART 2 - *************************************/
                //Initiate the object to use methods -- Test Part2
                objSearch = new LinkedIn_SearchPage(objDriver);
                _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 10));

                //Calling methods to execute on the test                
                objSearch.fnInsertSearch(strSearch);
                objSearch.fnPerformSearch();

                _objDriverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(@class,'search-filters-bar')]")));
                objSearch.fnClickFiltersButton();

                _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(@class,'search-basic-typeahead')]")));
                objSearch.fnSelectMex();
                //objSearch.fnSelectItaly(strItaly);
                objSearch.fnApplyFilter();
                
            }
            catch (Exception ex)//To Detect if the test fails
            {
                Console.WriteLine("Test case failed. See Details Below:");
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }

        }
    }
}
