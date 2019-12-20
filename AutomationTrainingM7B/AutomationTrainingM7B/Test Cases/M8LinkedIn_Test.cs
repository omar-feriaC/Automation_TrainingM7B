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
        //Declare Objects
        public static M8LinkedIn_Page objLogin;


        //Methots to use for test cases
        [Test]
        public void LinkedInLogin()
        {
            try //To Detect if it was a successfull test
            {
                //Initiate the object to use methods
                objLogin = new M8LinkedIn_Page(objDriver);

                //Calling methos to execute on the test
                objLogin.fnEnterUsername(strUserName);
                objLogin.fnEnterPassword(strPassword);
                objLogin.fnClickLogin();

                //Verifying that the Login was successfull
                Assert.AreEqual("https://www.linkedin.com/feed/", objDriver.Url);
            }
            catch (Exception ex)//To Detect if the test fails
            {
                Console.WriteLine("Test case failed. Details:");
                Console.WriteLine(ex.Message);
                Assert.Fail();
            }

        }
    }
}
