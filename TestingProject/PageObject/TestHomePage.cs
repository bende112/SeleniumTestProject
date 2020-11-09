using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestingProject.PageObject
{
    public class TestHomePage 
    {
       public IWebDriver driver;

        public TestHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PageContent()
        {
            //IWebElement PageContent = driver.FindElement(By.TagName("Selenium Test"));
            string expectedTitle = "Selenium Test";
            string actualTitle = driver.FindElement(By.CssSelector("h1[class='App-title']")).Text.ToString();
            Assert.AreEqual(expectedTitle, actualTitle);
        }
        public void DefaultCustomerDetails()
        {
            string[] header = { "Key", "Value" };
            string[] row1 = { "Name", "John Smith" };
            string[] row2 = { "Email", "jsmith@test.com" };
            string[] row3 = { "Phone", "0208092029" };
            string[] row4 = { "City", "London" };
            string[] row5 = { "State", "Greater London" };
            string[] row6 = { "Country", "England" };
            string[] row7 = { "Organisation", "Company 1" };
            string[] row8 = { "Job Profile", "Software Developer" };
            string[] row9 = { "Additional Info", "Has Bought a lot of products before and a high Value Customer" };


            var t = new Table(header);
            t.AddRow(row1);
            t.AddRow(row2);
            t.AddRow(row3);
            t.AddRow(row4);
            t.AddRow(row5);
            t.AddRow(row6);
            t.AddRow(row7);
            t.AddRow(row8);
            t.AddRow(row9);
        }
        public void ClickViewButton()
        {
            IWebElement ViewButton = driver.FindElement(By.CssSelector("button[data-test='2']"));
            ViewButton.Click();
        }
        public void ClickLastViewButton()
        {
            IWebElement ViewButton2 = driver.FindElement(By.CssSelector("button[data-test='3']"));
            ViewButton2.Click();
        }

        public void CustomerList()
        {
            string firstName = "John Smith";
            string secondName = "Jeff Bridges";
            string thirdName = "Steve Jones";
            String actualTitle = driver.Title;

            IWebElement CustomoerListSection = driver.FindElement(By.CssSelector("col-md-3"));
            if (firstName.Equals(actualTitle))
            {
                Console.WriteLine(firstName);
            }
            else if (secondName.Equals(actualTitle))
            {
                Console.WriteLine(secondName);
            }
            else if (thirdName.Equals(actualTitle))
            {
                Console.WriteLine(thirdName);
            }
            else
            {
                Assert.Fail("The expected message was not found");
            }


            Assert.IsTrue(CustomoerListSection.Text.Contains(firstName));
            Assert.IsTrue(CustomoerListSection.Text.Contains(secondName));
            Assert.IsTrue(CustomoerListSection.Text.Contains(thirdName));
        }
    }

}
