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
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        /*DRIVER REFERENCE*/
        //private static IWebDriver driver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_EMAIL_TXT2 = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STRREMEMBERME_LNK2 = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_HOME_PAGE_DASHBOARD_TXT= "//p[text()='DASHBOARD']";
        /*DASHBOUARD ELEMENTS IN RED BOX*/
        readonly static string STR_TOTAL_ADMINS_TXT = "(//i[@class='fa fa-user']/following-sibling::b)[1]";
        readonly static string STR_TOTAL_SUPPLIERS_TXT = "(//i[@class='fa fa-user']/following-sibling::b)[2]";
        readonly static string STR_TOTAL_CUSTOMERS_TXT = "(//i[@class='fa fa-users']/following-sibling::b)[1]";
        readonly static string STR_TOTAL_GUEST_TXT = "(//i[@class='fa fa-users']/following-sibling::b)[2]";
        readonly static string STR_TOTAL_BOOKINGS_TXT = "(//i[@class='fa fa-tag']/following-sibling::b)[1]";
        /*SIDE BAR ELEMENTS*/
        readonly static string STR_DASHBOARD_LB_BTN = "//ul[@id='social-sidebar-menu']/li[1]/a[1]";
        readonly static string STR_UPDATES_LB_BTN = "//span[text()='Updates']";
        readonly static string STR_MODULES_LB_BTN = "//a[@href='https://www.phptravels.net/admin/settings/modules/']";
        readonly static string STR_GENERAL_DROPDOWN_BTN = "//a[@href='#menu-ui']";
        readonly static string STR_SETTINGS_DROPDOWN_BTN = "//ul[@id='menu-ui']/li[1]/a[1]";

        readonly static string STR_TOTAL_TXT = "(//i[@class='fa fa-tag']/following-sibling::b)[1]";


        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            //driver = pobjDriver;
            _objDriver = pobjDriver;  
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        //private static IWebElement objRememberMeLnk = _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        //private static IWebElement objForgotPassLnk = _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        //Exercise Secction 1
        private static IWebElement objTotalAminsInt => _objDriver.FindElement(By.XPath(STR_TOTAL_ADMINS_TXT));
        private static IWebElement objTotalSuppliersInt => _objDriver.FindElement(By.XPath(STR_TOTAL_SUPPLIERS_TXT));
        private static IWebElement objTotalCustomersInt => _objDriver.FindElement(By.XPath(STR_TOTAL_CUSTOMERS_TXT));
        private static IWebElement objTotalGuestInt => _objDriver.FindElement(By.XPath(STR_TOTAL_GUEST_TXT));
        private static IWebElement objTotalBookingsInt => _objDriver.FindElement(By.XPath(STR_TOTAL_BOOKINGS_TXT));
        //Exercise Secction 2
        private static IWebElement objDashboardLabelBtn => _objDriver.FindElement(By.XPath(STR_DASHBOARD_LB_BTN));
        private static IWebElement objUpdatesBtn => _objDriver.FindElement(By.XPath(STR_UPDATES_LB_BTN));
        private static IWebElement objModulesBtn => _objDriver.FindElement(By.XPath(STR_MODULES_LB_BTN));
        private static IWebElement objGeneralDropDownBtn => _objDriver.FindElement(By.XPath(STR_GENERAL_DROPDOWN_BTN));

        private static IWebElement objSettingsDropDownBtn => _objDriver.FindElement(By.XPath(STR_SETTINGS_DROPDOWN_BTN));


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
           // return objRememberMeLnk;
            return objLoginBtn;
        }

        //Elements values in red box
        public IWebElement GetTotalAminsTxt()
        {
            return objTotalAminsInt;      

        }
        public IWebElement GetTotalSuppliersTxt()
        {
            return objTotalSuppliersInt;
        }
        public IWebElement GetTotalCustomersTxt()
        {
            return objTotalCustomersInt;
        }
        public IWebElement GetTotalGuest()
        {
            return objTotalGuestInt;
        }
        public IWebElement GetTotalBookings()
        {
            return objTotalBookingsInt;
        }
        //SIDE BAR ELEMENTS
        private IWebElement GetDashboardButton()
        {
            // return objRememberMeLnk;
            return objDashboardLabelBtn;
        }        
        private IWebElement GetUpdatesButton()
        {
            // return objRememberMeLnk;
            return objUpdatesBtn;
        }
        private IWebElement GetModulesButton()
        {
            // return objRememberMeLnk;
            return objModulesBtn;
        }
        private IWebElement GetGeneralDropDownButton()
        {
            // return objRememberMeLnk;
            return objGeneralDropDownBtn;
        }
        private IWebElement GetSettingsDropDownButton()
        {
            // return objRememberMeLnk;
            return objSettingsDropDownBtn;
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
        public void fnDashboardElementsInRedBox()
        {
            string strTotalAdmins = objTotalAminsInt.GetAttribute("innerHTML").ToString();
            string strTotalupplier = objTotalSuppliersInt.GetAttribute("innerHTML").ToString();
            string strTotalCustomers = objTotalCustomersInt.GetAttribute("innerHTML").ToString();
            string strTotalGuest = objTotalGuestInt.GetAttribute("innerHTML").ToString();
            string strTotalBookings = objTotalBookingsInt.GetAttribute("innerHTML").ToString();

            Console.WriteLine("****************Dashboard Element Valus In Red Box*****************");
            Console.WriteLine(""); 
            Console.WriteLine("");            
            Console.WriteLine("Total Admins:    " + strTotalAdmins);            
            Console.WriteLine("Total Suppliers: " + strTotalupplier);
            Console.WriteLine("Total Customers: " + strTotalCustomers);
            Console.WriteLine("Total Guest:     " + strTotalGuest);
            Console.WriteLine("Total Bookings:  " + strTotalBookings);

            objTest.Log(AventStack.ExtentReports.Status.Info, "Total Admin : " + strTotalAdmins);
            objTest.Log(AventStack.ExtentReports.Status.Info, "Total Suppliers : " + strTotalupplier);
            objTest.Log(AventStack.ExtentReports.Status.Info, "Total Customers : " + strTotalCustomers);
            objTest.Log(AventStack.ExtentReports.Status.Info, "Total Guest : " + strTotalGuest);
            objTest.Log(AventStack.ExtentReports.Status.Info, "Total Bookings : " + strTotalBookings);
        }
        public void fnDashboardElementButton()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_DASHBOARD_LB_BTN)));
            
        }
        public void fnClickUpdatesLbBtn()
        {
            
           // objUpdatesBtn.Click();
            _driverWait.Until(ExpectedConditions.TitleContains("Updates"));//.ElementExists.(By.XPath()));
        }
        public static void fnClickModulesLbBtn()
        {

            //objModulesBtn.Click();
            _driverWait.Until(ExpectedConditions.TitleContains("Modules"));//.ElementExists.(By.XPath()));
        }
        //public static void fnClickSettingsBtn()
        //{

        //    objSettingsDropDownBtn.Click();
        //    //_driverWait.Until(ExpectedConditions.TitleContains("Modules"));//.ElementExists.(By.XPath()));
        //}
        public void fnSideBarElements()
        {
            //fnDashboardElementButton();
            //objDashboardLabelBtn.Click();
            fnDashboardElementButton();
            //_driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LB_BTN)));
            //_driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_LB_BTN)));
            //_driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_DASHBOARD_LB_BTN)));
            fnClickUpdatesLbBtn();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_UPDATES_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_UPDATES_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_UPDATES_LB_BTN)));
            fnClickModulesLbBtn();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MODULES_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MODULES_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_MODULES_LB_BTN)));
            //objDashboardLabelBtn.Click();

        }
        public void fnSideBarMenuElementOptions(string strMenuOptionCriteria)
        {
              
            //string[] arrMenu = new string[2] { "Updates", "General" };
            //foreach (string strMenuOptionCriteria1 in arrMenu)
            //{
                //Option without submenu
                if (strMenuOptionCriteria == "Updates")
                {
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LB_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_LB_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_DASHBOARD_LB_BTN)));
                    objUpdatesBtn.Click();
                }
                //Option without submenu
                else if (strMenuOptionCriteria == "General")
                {
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LB_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_LB_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_DASHBOARD_LB_BTN)));
                    objGeneralDropDownBtn.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SETTINGS_DROPDOWN_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SETTINGS_DROPDOWN_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SETTINGS_DROPDOWN_BTN)));
                    objSettingsDropDownBtn.Click();

                }
                else { }        
        }


    }
}
