using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private string baseURL = "http://localhost:12268/";
        private RemoteWebDriver driver;
        private string browser;
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("Chrome")]

        public void MakeOrder()
        {
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //driver.Navigate().GoToUrl(this.baseURL);
            //driver.FindElementById("search - box").Clear();
            //driver.FindElementById("search - box").SendKeys("tire");
            //do other Selenium things here!
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElementByLinkText("Vehicles").Click();
            driver.FindElementByLinkText("Buy").Click();
            driver.FindElementByLinkText("Cart").Click();
            driver.FindElementByLinkText("Remove").Click();

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            driver = new ChromeDriver();
        }
    }
}