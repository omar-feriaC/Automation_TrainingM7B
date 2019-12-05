using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.Page_Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {

            /*SetupDriver();
            
            LoginPage_Mercury objLogin = new LoginPage_Mercury(objDriver);
            LoginPage_Mercury.fnEnterUserNameTxt(strUserName);
            LoginPage_Mercury.fnEnterPasswordTxt(strPassword);
            LoginPage_Mercury.fnClickSignInBtn();

            ExitDriver();*/

            /*objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            Object Page
            objDriver.FindElement(By.Id("userName")).Clear();
            objDriver.FindElement(By.Name("userName")).SendKeys(strUserName);
            objDriver.FindElement(By.Name("password")).Clear();
            objDriver.FindElement(By.Name("password")).SendKeys(strPassword);

            objDriver.FindElement(By.Name("userName")).Clear();
            objDriver.FindElement(By.Name("userName")).SendKeys("admin123");
            objDriver.FindElement(By.Name("password")).Clear();
            objDriver.FindElement(By.Name("password")).SendKeys("5464564");

            objDriver.FindElement(By.XPath("//input[@name='login']")).Click();
            objDriver.FindElement(By.LinkText("REGISTER")).Click();


            //Driver Kill
            objDriver.Close();
            objDriver.Quit();
            */

            Console.ReadKey();
        }
    }
}
