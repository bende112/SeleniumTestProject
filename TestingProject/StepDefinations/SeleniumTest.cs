using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestingProject;
using BoDi;
using TechTalk.SpecFlow.Assist;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions : TestClass
    {

        public StepDefinitions()
        {
           
        }
        [Given(@"a user access the Url")]
        public void GivenAUserAccessTheUrl()
        {
            NavigateToTestPage();
        }
        [Given(@"Selenium Test is displayed")]
        public void GivenSeleniumTestIsDisplayed()
        {
            CheckPageContent();
        }
        
        [Given(@"the details of '(.*)' is displayed")]
        public void GivenTheDetailsOfIsDisplayed(string CustomerName, Table table)
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

        [When(@"the user clicks the second Click to View Details button")]
        public void WhenTheUserClicksTheSecondClickToViewDetailsButton()
        {
            UserClickSecondViewButton();
        }

        [Then(@"the second customer details are displayed")]
        public void ThenTheSecondCustomerDetailsAreDisplayed(Table table)
        {
        
            string[] header = { "Key", "Value" };
            string[] row1 = { "Name", "Jeff Bridges" };
            string[] row2 = { "Email", "abcd@test.com" };
            string[] row3 = { "Phone", "0161 225 7632" };
            string[] row4 = { "City", "Manchester" };
            string[] row5 = { "State", "Greater Manchester" };
            string[] row6 = { "Country", "England" };
            string[] row7 = { "Organisation", "Company 2" };
            string[] row8 = { "Job Profile", "Software Developer" };
            string[] row9 = { "Additional Info", "Buys Products Rarely" };

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
        //[When(@"the user clicks the '(.*)' Details button")]
        //public void WhenTheUserClicksTheDetailsButton(string p0)
        //{
        //    UserClickLastViewButton();
        //}

        [When(@"the user clicks the last '(.*)' button")]
        public void WhenTheUserClicksTheLastButton(string p0)
        {
            UserClickLastViewButton();
        }

        [Then(@"the Details of Steve Jones is displayed")]
        public void ThenTheDetailsOfIsDisplayed(Table table)
        {
            string[] header = { "Key", "Value" };
            string[] row1 = { "Name", "Steve Jones" };
            string[] row2 = { "Email", "steven.jones@test.com" };
            string[] row3 = { "Phone", "01403 215100" };
            string[] row4 = { "City", "Horsham" };
            string[] row5 = { "State", "West Sussex" };
            string[] row6 = { "Country", "England" };
            string[] row7 = { "Organisation", "Company 3" };
            string[] row8 = { "Job Profile", "Software Developer" };
            string[] row9 = { "Additional Info", "Buys Lots of Products in general" };

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
        [Given(@"a list of customer is displayed")]
        public void GivenAListOfCustomerIsDisplayed(Table table)
        {
            UserCheckCustomerList();
        }

    }
}