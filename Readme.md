Saurav Arya

A00236910

Expense Tracker App Final Project: 

The idea is to build a web application which can track the regular bill details of the individual user. The web app can log the bills of the user, store the amount on the bill for the tracker and its corresponding date and time. The user is able to view the list of stored bills in the web application and shall be able to generate or view the graph for its bill expenditures history. The app shall use SQL database to store the manually entered bill amounts along with the details and automatic date and time entry to track expenses.


\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

What I have done so far?

I created a web app MVC project for the solution and changed my uthetication to individual user accounts during the setup. First, I changed the title and description of the Welcome page in the index file to provide a description of the app to the user. Then, I went ahead and added a new expense model class in the models folder to include some expense properties like Id, ExpenseTitle, ExpenseDetails, and DateTime of the entry along with a constructor. After creating the model class, I added a MVC controller with views, using entity framework and selected appropriate model, data context class and a controller name. The step also generated some new files in the views folder such as create, delete, details, edit, and index file under the expense folder name. 

Then, to create the database model, I added migration from the package manager console and updated the database. In the Layout file, I added a new nav bar item for Expense page and linked it to expenses controller and set the action as Index. After this, in order to hide the details of the expenses on the page and show them only after clicking the details option, I deleted the details instances in the index file under the expenses folder.

To add authentication and authorization for registering users and their log in, I added authorize keywords for create functions for authorization in the expenses controller using the microsoft.aspnetcore.authorization library. I did the same step for edit and delete functions as well.

I also modified some UI aspects of the page from the site.css file in the wwwroot folder.

After that for my final submission, I added an integration test project to the solution and included some integration tests to test if the application loads successfully.


\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

What else I tried?

I tried to add charts or graphs into the app using Chart.js library but couln't figure out how to integrate it with my databse to retreive and showcase data on the graph. I also tried to include or intgrate Microsoft Graph .NET SDK to generate graphs. I installed microsoft's authentication library and OWIN middleware NuGet packages but couldn't figure out the further steps to work it down with the expense inputs of the user over the entered dateTime. Further, I tried to find charts option in the tools menu and other inbuilt graph options but I think those are available for different kind of projects which include forms. 

For my final submission, I tried to include a WebAPI project in the solution but couldn't think of any value add it can provide in this kind of an application as there are no specific functions like the previous web calculator app to call from the webAPI project.

\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




