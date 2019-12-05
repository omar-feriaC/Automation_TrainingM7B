using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Test_Cases
{
    class LoginTest_Mercury : BaseTest
    {
        LoginPage_Mercury objLoginPage;

        [Test]
        public void MercuryLoginTest()
        {
            objLoginPage = new LoginPage_Mercury(objDriver);
            LoginPage_Mercury.fnEnterUserNameTxt(strUserName);
            LoginPage_Mercury.fnEnterPasswordTxt(strPassword);
            LoginPage_Mercury.fnClickSignInBtn();
        }

        [Test]
        public void MercuryLoginTest2()
        {
            objLoginPage = new LoginPage_Mercury(objDriver);
            LoginPage_Mercury.fnEnterUserNameTxt(strUserName);
            LoginPage_Mercury.fnEnterPasswordTxt(strPassword);
            LoginPage_Mercury.fnClickSignInBtn();
        }

    }
}
