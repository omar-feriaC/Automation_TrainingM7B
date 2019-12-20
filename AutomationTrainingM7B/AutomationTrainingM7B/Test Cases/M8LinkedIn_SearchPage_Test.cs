using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace AutomationTrainingM7B.Test_Cases
{
    class M8LinkedIn_SearchPage_Test : M8LinkedIn_Test
    {
        WebDriverWait wait;
        

        [Test]

        public void M8LinkedIn_SearchPage()
        {
            M8LinkedIn_Login();
            try
            {
                M8LinkedIn_SearchPage_POM objSearchPage = new M8LinkedIn_SearchPage_POM(objDriver);
                wait = new WebDriverWait(objDriver, new TimeSpan(0, 1, 0));
                string[] technologies = {"oracle", "java", "c#", "php", "html" };

                objSearchPage.fnSearchText("oracle");
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ember8")));
                objSearchPage.fnSearchButton();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='Gente' or text()='People']]")));
                objSearchPage.fnPeopleButton();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='Ubicaciones' or text()='Locations']]")));
                objSearchPage.fnAllFiltersButton();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[label[text()='Mexico' or text()='México']]")));
                objSearchPage.fnMexicoOpt();
                objSearchPage.fnEnglishOpt();
                objSearchPage.fnSpanishOpt();
                objSearchPage.fnApplyButton();

                for (int i = 0; i < technologies.Length; i++)
                {
                    objSearchPage.fnSearchText(technologies[i]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='Contactos' or text()='Connections']]")));
                    objSearchPage.fnSearchButton();

                }

            }

            catch (Exception x)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("TEST CASE FAILED on: ");
                Console.WriteLine(x.Message);
                Console.WriteLine("*************************************");
                Assert.Fail();
            }

            finally
            {

            }

        }
    }
}
