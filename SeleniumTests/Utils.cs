using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumTests
{
    static class Utils
    {

        //Start WebBrowsers
        public static List<IWebDriver> GetAvailableWebDrivers()
        {

            var drivers = new List<IWebDriver>();

            IWebDriver _ChromeDriver = new ChromeDriver();
            _ChromeDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            drivers.Add(_ChromeDriver);

            //IWebDriver _IEDriver = new InternetExplorerDriver();
            //_IEDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            //drivers.Add(_IEDriver);

            //IWebDriver _FireFoxDriver = new FirefoxDriver();
            //_FireFoxDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            //drivers.Add(_FireFoxDriver);

            //NOT WORKING - https://code.google.com/p/selenium/wiki/SafariDriver
            //IWebDriver _SafariDriver = new SafariDriver();
            //_SafariDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

            return drivers;
        }



        //Automate Login
        public static void MockLogIn(IWebDriver driver, string fødselsnummer)
        {
            try
            {
             

            }
            catch (Exception)
            {
                throw;
            }

        }

        //LogOut
        public static void LogOut(IWebDriver driver)
        {
            try
            {


            }
            catch (Exception)
            {

            }
        }


        //Clean and Destroy drivers and processes
        public static void Destroy(IWebDriver driver)
        {
            try
            {
                driver.Close();
                driver.Quit();

                Process[] processes = Process.GetProcessesByName("IEDriverServer");
                if (processes.Length > 0)
                {
                    KillProcessByName("iexplore");
                    KillProcessByName("IEDriverServer");
                }

                processes = Process.GetProcessesByName("chromedriver");
                if (processes.Length > 0)
                {
                    KillProcessByName("chrome");
                    KillProcessByName("chromedriver");
                }

            }
            catch (Exception) { }

        }

        private static void KillProcessByName(string processName)
        {
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }

    }
}
