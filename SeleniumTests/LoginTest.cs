using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTests
{
    /// <summary>
    /// Test About
    /// </summary>
    [TestClass]
    public class TestLogin
    {

        private List<IWebDriver> _drivers;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            _drivers = Utils.GetAvailableWebDrivers();

        }

        [SetUp]
        public void TestSetUp()
        {


        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            foreach (var webDriver in _drivers)
            {
                Utils.LogOut(webDriver);
                Utils.Destroy(webDriver);
            }
        }


        [Test]
        public void S12T1()
        {
            foreach (var webDriver in _drivers)
            {
                webDriver.Navigate().GoToUrl("http://localhost:8080/Home/About");

                IWebElement aboutMenuOption = webDriver.FindElement(By.LinkText("About"));

                aboutMenuOption.Click();

            }
        }
    }
}
