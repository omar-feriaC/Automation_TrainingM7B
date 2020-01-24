using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationTrainingM7B.Reporting;

namespace AutomationTrainingM7B.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        public static clsPHPTravels_LoginPage objPHP;
        public static clsReportManager objManager;

        [Test]
        public void Test_M9Exercise()
        {
            objTest = objTest.CreateNode("Login", "Login to PHP Travels");//Creating node on the actual report
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();

            /*Part 1*/
            objManager = new clsReportManager(); //Object for Report Manager
            objTest = objTest.CreateNode("Part 1 - Exam", "Dashboard results - List");//Create a new step on actual test case
            objPHP.fnTotalDashboards();            
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            objTest.Pass("Dashboard results are displayed correctly.");//finaliza step
        }

    }
}
