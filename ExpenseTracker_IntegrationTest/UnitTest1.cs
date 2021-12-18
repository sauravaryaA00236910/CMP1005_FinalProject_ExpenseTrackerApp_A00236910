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
        public void TestHomeTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            Assert.AreEqual("Expense Tracker", _driver.Title);
            Assert.IsTrue(_driver.Title.Contains("Expense Tracker"));
        }

        [TestMethod]
        public void TestExpenseTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/Expenses");
            Assert.AreEqual("Index", _driver.Title);
            Assert.IsTrue(_driver.Title.Contains("Index"));
        }

        [TestMethod]
        public void TestCreateTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/Expenses/Create");
            Assert.AreEqual("Create", _driver.Title);
            Assert.IsTrue(_driver.Title.Contains("Create"));
        }

        [TestMethod]
        public void TestLoginTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/Identity/Account/Login");
            Assert.AreEqual("Log in", _driver.Title);
            Assert.IsTrue(_driver.Title.Contains("Log in"));
        }

        [TestMethod]
        public void TestRegisterTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/Identity/Account/Register");
            Assert.AreEqual("Register", _driver.Title);
            Assert.IsTrue(_driver.Title.Contains("Register"));
        }

        [TestCleanup]
        public void Shutdown()
        {
            _driver.Quit();
        }
    }
}
