using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ExpenseTracker_IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver _driver;

        [TestInitialize]
        public void Startup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void TestTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            Assert.AreEqual("Expense Tracker", _driver.Title);
            Assert.IsTrue(_driver.Title.Contains("Expense Tracker"));
        }

        [TestCleanup]
        public void Shutdown()
        {
            _driver.Quit();
        }
    }
}
