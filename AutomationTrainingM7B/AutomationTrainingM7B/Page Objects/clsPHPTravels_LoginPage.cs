using AutomationTrainingM7B.Base_Files;
using NUnit.Framework;
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
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        //**Locators for Exam part 1**//
        readonly static string STR_DASHBOARD_LST = "//*[@class='serverHeader__statsList']//a";

        /*Locators for Exam Part 2*/
        static string STR_MenuOption = "settings";
        static string STR_SubMenuOption = "widgets";
        static int INT_i = 0;
        readonly static string STR_SIDEBARMENU_LST = "//*[@id='social-sidebar-menu']//a";
        readonly static string STR_SIDEBARMENUOPTN_LST = $"(//ul[@id='social-sidebar-menu']//a)[{INT_i}]";
        readonly static string STR_DASHBOARDOPTION_LNK = "//ul[@id='social-sidebar-menu']//*[@href='https://www.phptravels.net/admin']";
        static string STR_MENUOPTION_LNK = "//ul[@id='social-sidebar-menu']//*[contains(@href,'https://www.phptravels.net/admin/"+$"{STR_MenuOption}')]";
        static string STR_SUBMENUOPTION_LNK = "//ul[@id='social-sidebar-menu']//*[contains(@href,'https://www.phptravels.net/admin/"+$"{STR_MenuOption}/{STR_SubMenuOption}')]";


        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        //*Object definition for Exam Part 1**//
        private static IList<IWebElement> objDashboardLST => _objDriver.FindElements(By.XPath(STR_DASHBOARD_LST));

        /*Object definition for Exam Part 2*/
        private static IList<IWebElement> objSideBarMenuLST => _objDriver.FindElements(By.XPath(STR_SIDEBARMENU_LST));
        private static IWebElement objSideBarMenuSelectedLST => _objDriver.FindElement(By.XPath(STR_SIDEBARMENUOPTN_LST));
        private static IWebElement objDashboardLNK => _objDriver.FindElement(By.XPath(STR_DASHBOARDOPTION_LNK));
        private static IWebElement objSingleMenuOptionLNK => _objDriver.FindElement(By.XPath(STR_MENUOPTION_LNK));
        private static IWebElement objSubMenuOptionLNK => _objDriver.FindElement(By.XPath(STR_SUBMENUOPTION_LNK));

        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
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

        /*Part 1 - Methods and functions for Dashboard*/
        
        private IList<IWebElement> GetListDashboard()
        {
            return objDashboardLST;
        }

        public void fnTotalDashboards()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LST)));
            for (int i = 0; i < objDashboardLST.Count(); i++)
            {
                Console.WriteLine(objDashboardLST[i].Text);
                objTest.Log(AventStack.ExtentReports.Status.Info, $"{i+1} .- {objDashboardLST[i].Text}\n");
            }

        }

        /*Part 2 - Methods and functions for Side Bar Menu*/
        private IList<IWebElement> GetElementsOnMenu()
        {
            return objSideBarMenuLST;
        }

        public void fnElementsOnMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SIDEBARMENU_LST)));
            for (int i = 0; i < objSideBarMenuLST.Count(); i++)
            {
                Console.WriteLine($"{i} .- {objSideBarMenuLST[i].Text}");
                objTest.Log(AventStack.ExtentReports.Status.Info, $"{i + 1} .- {objSideBarMenuLST[i].Text}\n");
                //objSideBarMenuLST[i].Click();
            }
        }
        //En el punto 12 es validar que sí se redirecciona a la página como Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

        public IWebElement GetLinkDashboaard()
        {
            return objDashboardLNK;
        }
        public IWebElement GetMenuOption()
        {
            return objSingleMenuOptionLNK;
        }
        public IWebElement GetSubMenuOption()
        {
            return objSubMenuOptionLNK;
        }
        public IWebElement GetOptionMenuSelected()
        {
            return objSideBarMenuSelectedLST;
        }

        public void fnClickBashboardOption()
        {
            objSingleMenuOptionLNK.Click();
        }

        public void fnClickMenuOption(string pstrMenuOption)
        {
            STR_MENUOPTION_LNK = "//ul[@id='social-sidebar-menu']//*[contains(@href,'https://www.phptravels.net/admin/" + $"{pstrMenuOption.ToLower()}')]";
            switch (pstrMenuOption.ToUpper())
            {
                case "DASHBOARD":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARDOPTION_LNK)));
                    objDashboardLNK.Click();
                    Console.WriteLine($"Selected option: {objSingleMenuOptionLNK.Text}");
                    Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Link was not loaded correctly.");
                    break;
                case "UPDATES":
                    STR_MenuOption = "updates";
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENUOPTION_LNK)));
                    objSingleMenuOptionLNK.Click();
                    Console.WriteLine($"Selected option: {objSingleMenuOptionLNK.Text}");
                    break;
                case "MODULES":
                    STR_MenuOption = "modules";
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENUOPTION_LNK)));
                    objSingleMenuOptionLNK.Click();
                    break;
                case "COUPONS":
                    STR_MenuOption = "coupons";
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENUOPTION_LNK)));
                    objSingleMenuOptionLNK.Click();
                    break;
                case "NEWSLETTER":
                    STR_MenuOption = "newsletter";
                    Console.WriteLine($"Selected option: {objSingleMenuOptionLNK.Text}");
                    fnClickBashboardOption();
                    break;
                case "BOOBKINGS":
                    STR_MenuOption = "bookings";
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENUOPTION_LNK)));
                    objSingleMenuOptionLNK.Click();
                    break;
                case "PAYOUTS":
                    STR_MenuOption = "payouts";
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENUOPTION_LNK)));
                    objSingleMenuOptionLNK.Click();
                    break;
                default:
                    Console.WriteLine("The option: " + pstrMenuOption + " is not correct.");
                    break;
            }

        }
        public void fnClickMenuOption(string pstrMenuOption, string pstrSubMenuOption)
        {
            objSideBarMenuLST.Count();
            STR_SUBMENUOPTION_LNK = "//ul[@id='social-sidebar-menu']//*[contains(@href,'https://www.phptravels.net/admin/" + $"{pstrMenuOption.ToLower()}/{pstrSubMenuOption.ToLower()}')]";
            switch (pstrMenuOption.ToUpper())
            {
                case "GENERAL":
                    pstrMenuOption = "settings";
                    INT_i = 3;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "SETTINGS":
                            pstrMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            objSideBarMenuLST[4].Click();
                            break;
                        case "CURRENCIES":
                            pstrSubMenuOption = "currencies";
                            objSideBarMenuLST[INT_i].Click();
                            STR_SUBMENUOPTION_LNK.ToString();
                            objSubMenuOptionLNK.Click();
                            Console.WriteLine($"Selected option: {objSingleMenuOptionLNK.Text}/{objSubMenuOptionLNK.Text}");
                            break;
                        case "PAYMENT GATEWAYS":
                            pstrSubMenuOption = "paymentgateways";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "SOCIAL CONNECTIONS":
                            pstrSubMenuOption = "social";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "WIDGETS":
                            pstrSubMenuOption = "widgets";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "HOMEPAGE SLIDERS":
                            pstrSubMenuOption = "sliders";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "EMAIL TEMPLATES":
                            pstrMenuOption = "templates";
                            pstrSubMenuOption = "email";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "SMS API SETTINGS":
                            pstrMenuOption = "templates";
                            pstrSubMenuOption = "sms_settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "BACKUP":
                            pstrMenuOption = "backup";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                        case "BAN IP":
                            pstrMenuOption = "banip";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "ACCOUNTS":
                    pstrMenuOption = "accounts";
                    INT_i = 14;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "ADMINS":
                            pstrSubMenuOption = "admins";
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='social-sidebar-menu']//a")));
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "SUPPLIERS":
                            pstrSubMenuOption = "suppliers";
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='social-sidebar-menu']//a")));
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "GUESTCUSTOMERS":
                            pstrSubMenuOption = "guest";
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='social-sidebar-menu']//a")));
                            objSideBarMenuLST[INT_i].Click();
                            objSideBarMenuLST[14].Click();
                            break;
                    }
                    break;
                case "CMS":
                    pstrMenuOption = "cms";
                    INT_i = 19;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "PAGES":
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                        case "MENU":
                            pstrSubMenuOption = "menus";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "TRAVELHOPE HOTELS":
                    pstrMenuOption = "thhotels";
                    INT_i = 22;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "BOOKINGS":
                            pstrSubMenuOption = "bookings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "TRAVELHOPE FLIGHTS":
                    pstrMenuOption = "thflight";
                    INT_i = 25;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "BOOKINGS":
                            pstrSubMenuOption = "bookings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "TOURS":
                    pstrMenuOption = "tours";
                    INT_i = 28;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "TOURS":
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                        case "EXTRAS":
                            pstrSubMenuOption = "extras";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "REVIEWS":
                            pstrSubMenuOption = "reviews";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "CARS":
                    pstrMenuOption = "cars";
                    INT_i = 33;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "CARS":
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                        case "EXTRAS":
                            pstrSubMenuOption = "extras";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "CARS SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "VISA":
                    pstrMenuOption = "ivisa";
                    INT_i = 37;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "BOOKINGS":
                            pstrSubMenuOption = "bookings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "BLOG":
                    pstrMenuOption = "blog";
                    INT_i = 40;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "POSTS":
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                        case "BLOG CATEGORIES":
                            pstrSubMenuOption = "category";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                        case "BLOG SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "LOCATIONS":
                    STR_MENUOPTION_LNK = "//ul[@id='social-sidebar-menu']//*[contains(@href,'https://www.phptravels.net/supplier/"+$"{pstrMenuOption.ToLower()}')]";
                    INT_i = 44;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "LOCATIONS LISTS":
                            pstrMenuOption = "locations";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                    }
                    break;
                case "OFFERS":
                    pstrMenuOption = "offers";
                    INT_i = 46;
                    switch (pstrSubMenuOption.ToUpper())
                    {
                        case "MANAGE OFFERS":
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSingleMenuOptionLNK.Click();
                            break;
                        case "OFFERS SETTINGS":
                            pstrSubMenuOption = "settings";
                            objSideBarMenuLST[INT_i].Click();
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENUOPTION_LNK)));
                            objSubMenuOptionLNK.Click();
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("The option selected is not correct.");
                    break;

            }
        }
    }
}
