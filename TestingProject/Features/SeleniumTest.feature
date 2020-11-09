Feature: Selenium Test

//Test the customer page

@Test1	
Scenario: Navigate to customer page
	Given a user access the Url
	And Selenium Test is displayed
	And the details of 'John Smith' is displayed
     |Key            |Value          |
     |Name           |John Smith     |
     |Email          |jsmith@test.com|
     |Phone          |0208092029     |
     |City           |London         |
     |State          |Greater London |
     |Country        |England        |
     |Organization   |Company 1      |
     |Job Profile    |Software Developer|
     |Additional Info|Has Bought a lot of products before and a high Value Customer|
   When the user clicks the second Click to View Details button
   Then the second customer details are displayed
     |Key             |Value                 |
     |Name            |Jeff Bridges          |
     |Email           |abcd@test.com         |
     |Phone           | 0161 225 7632        |
     |City            |Manchester            |
     |State           |Greater Manchester    |
     |Country         |England               |
     |Organization    |Company 2             |
     |Job Profile     |Software Developer    |
     |Additonal info  | Buys Products Rarely |

@Test2
Scenario: user view another customer detail
   Given a user access the Url
   And Selenium Test is displayed
   When the user clicks the last 'Click to View Details' button
   Then the Details of Steve Jones is displayed
     |Key             |Value                             |
     |Name            |Steve Jones                       |
     |Email           |steven.jones@test.com             |
     |Phone           | 01403 215100                     |
     |City            |Horsham                           |
     |State           |West Sussex                       |
     |Country         |England                           |
     |Organization    |Company 3                         |
     |Job Profile     |Software Developer                |
     |Additonal info  | Buys Lots of Products in general |

@test3
Scenario: Check customer list
   Given a user access the Url
   And a list of customer is displayed
     |FirstName|LastName|
     |John     |Smith   |
     |Jeff     |Bridges |
     |Steve    |Jones   |
