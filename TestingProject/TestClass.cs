using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TestingProject.PageObject;

namespace TestingProject
{
    [Binding]
    public class TestClass
    {
        private IWebDriver driver;
        WebDriverWait _wait;

        [SetUp]
        public void NavigateToTestPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist");
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [Test]
        public void CheckPageContent()
        {
            TestHomePage testHomePage = new TestHomePage(driver);
            testHomePage.PageContent();
            driver.Close();
        }
        [Test]
        public void FirstCustomerDetails()
        {
            TestHomePage testHomePage = new TestHomePage(driver);
            testHomePage.DefaultCustomerDetails();
            driver.Close();
        }
        [Test]
        public void UserClickSecondViewButton()
        {
            TestHomePage testHomePage = new TestHomePage(driver);
            testHomePage.ClickViewButton();
            driver.Close();
        }
        [Test]
        public void UserClickLastViewButton()
        {
            TestHomePage testHomePage = new TestHomePage(driver);
            testHomePage.ClickLastViewButton();
            driver.Close();
        }
        [Test]
        public void UserCheckCustomerList()
        {
            TestHomePage testHomePage = new TestHomePage(driver);
            testHomePage.CustomerList();
            driver.Close();
        }
    }
}

