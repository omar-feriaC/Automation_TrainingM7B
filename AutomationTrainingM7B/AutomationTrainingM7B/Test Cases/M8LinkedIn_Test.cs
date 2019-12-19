﻿using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationTrainingM7B.Test_Cases
{
    class M8LinkedIn_Test : BaseTest
    {
        M8LinkedIn_Page objLoginPage;
        WebDriverWait _objDriverWait;


        [Test]

        public void M8LinkedIn_Login() {

            try
            {
                _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 30));

                objDriver.Manage().Window.Maximize(); 
                objLoginPage = new M8LinkedIn_Page(objDriver);
                objLoginPage.fnUsernameText(strUserName);
                objLoginPage.fnPasswordText(strPassword);
                objLoginPage.fnLoginButton();

                
                _objDriverWait.Until(ExpectedConditions.UrlContains("feed"));
                Assert.AreEqual("https://www.linkedin.com/feed/", objDriver.Url);


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
