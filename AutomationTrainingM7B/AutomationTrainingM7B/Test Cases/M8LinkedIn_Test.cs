using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Test_Cases
{
    class M8LinkedIn_Test : BaseTest
    {
        M8LinkedIn_Page objLogin;
        WebDriverWait _objDriverWait;

        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                objLogin = new M8LinkedIn_Page(driver);

                objLogin.fnEnterUsername(strUsername);
                objLogin.fnEnterPassword(strPassword);
                objLogin.fnClickSignInButton();

                Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test case failed.");
                Assert.Fail();
            }
            finally
            {
                //Closing connections, etc...
            }
        }
    }
}
