using AutomationTrainingM7B.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class clsPHPTravels_LoginPage:BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "(//label[@class='input-outlined']//descendant::input)[1]";
        readonly static string STR_EMAIL_TXT2 = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STRREMEMBERME_LNK2 = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_DASHBOARD_HEADER = "//p[@class='serverHeader__title']";
        readonly static string STR_TOTALADMINS_HEADER = "(//div[@class='serverHeader__stats']//a)[1]";
        readonly static string STR_TOTALSUPPLIERS_HEADER = "(//div[@class='serverHeader__stats']//a)[2]";
        readonly static string STR_TOTALCUSTOMERS_HEADER = "(//div[@class='serverHeader__stats']//a)[3]";
        readonly static string STR_TOTALGUESTS_HEADER = "(//div[@class='serverHeader__stats']//a)[4]";
        readonly static string STR_TOTALBOOKING_HEADER = "(//div[@class='serverHeader__stats']//a)[5]";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 20));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => driver.FindElement(By.XPath(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => driver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => driver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => driver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objDashboardHeader => driver.FindElement(By.XPath(STR_DASHBOARD_HEADER));
        private static IWebElement objTotalAdminsHeader => driver.FindElement(By.XPath(STR_TOTALADMINS_HEADER));
        private static IWebElement objTotalSuppliers => driver.FindElement(By.XPath(STR_TOTALSUPPLIERS_HEADER));
        private static IWebElement objTotalCustomers => driver.FindElement(By.XPath(STR_TOTALCUSTOMERS_HEADER));
        private static IWebElement objTotalGuests => driver.FindElement(By.XPath(STR_TOTALGUESTS_HEADER));
        private static IWebElement objTotalBookings => driver.FindElement(By.XPath(STR_TOTALBOOKING_HEADER));

        /*METHODS/FUNCTIONS*/

        //Email
        public IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            //clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            //clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
            //clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }

        //Password
        private IWebElement GetPasswordField()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPass)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objRememberMeLnk;
        }

        public static void fnClickLoginButton()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        public static IWebElement fnGetDashboardHeader()
        {
            return objDashboardHeader;
        }

        public static IWebElement fnGetTotalAdminsHeader()
        {
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TOTALADMINS_HEADER));
            return objTotalAdminsHeader;
        }

        public static IWebElement fnGetTotalSuppliers()
        {
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TOTALSUPPLIERS_HEADER));
            return objTotalSuppliers;
        }

        public static IWebElement fnGetTotalCustomers()
        {
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TOTALCUSTOMERS_HEADER));
            return objTotalCustomers;
        }

        public static IWebElement fnGetTotalGuests()
        {
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TOTALGUESTS_HEADER));
            return objTotalGuests;
        }

        public static IWebElement fnGetTotalBookings()
        {
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TOTALBOOKING_HEADER));
            return objTotalBookings;
        }

    }
}
