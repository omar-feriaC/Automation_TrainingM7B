using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;

        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");

        }

    }
}
