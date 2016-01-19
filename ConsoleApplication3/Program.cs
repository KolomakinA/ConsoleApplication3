using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication3
{

    /// class Program
    /// 
    class sbmLogin
    {
        static void Main(string[] args)
        {
            ///We will open that URL and will be performing test over it
            string siteToTest = "http://stl-alms-tst4/workcenter/tmtrack.dll?shell=swc";

            ///SBM credentials
            string sbmUserName = "admin";
            string sbmUserPass = "";

            /// Open the site and wait 5 second while the site is loaded
            IWebDriver drv = new FirefoxDriver();
            ///drv.Navigate().GoToUrl("http://stl-alms-tst4/workcenter/tmtrack.dll?shell=swc");
            drv.Navigate().GoToUrl(siteToTest);
            System.Threading.Thread.Sleep(5000);


            ///find login form Username field and send sbmUserName variable content (string)
            IWebElement sbmLoginUName = drv.FindElement(By.Id("authUID"));
            sbmLoginUName.Clear();
            sbmLoginUName.SendKeys(sbmUserName);

            IWebElement sbmLoginUPass = drv.FindElement(By.Id("authPWD"));
            sbmLoginUPass.Clear();
            sbmLoginUPass.SendKeys(sbmUserPass);

            IWebElement sbmLoginBtn = drv.FindElement(By.Id("logonButton"));
            sbmLoginBtn.Click();

        
        }
        public bool LoginToSBM(string siteToTest, string sbmUserName, string sbmUserPass)
        {

            return false;
        }
    }
}
