# MVC_Sample
C# MVC Simple Application
This is a simple application developed in one sitting to meet the following requirements:

Create a C# web application/site that gets data from a SQL Server table and displays it in a tabular grid format on a web page.

1.	Create a table in SQL Server called [Document].  Add the following columns with the appropriate data types: id, author, pubdate, description.
2.	Add sample data.
3.	Create a C# MVC web application/site called, ‘MySampleProject’.
4.	On a web page, display the data from the [Document] table in a tabular grid format.
5.	Users should be able to edit records.  Set up your UI such that clicking on a cell in a table opens that record in edit mode. Save the user’s edits to the database using jQuery.  
6.	Update the grid with the new data using jQuery.  Do not refresh the entire page.


IMPLEMENTATION

Database
For this project I created a simple SQLExpress Database DocsDB.mdf, with two tables, Document and AppUser.  Document will store data outlined in the requirements document, as well as additional LastChangedDate and LastChangedUser, with LastChangedUser linked to AppUser.Id.  DocumentId is the primary key and an identity column.  AppUser stores data for authorized to users of the internal web application.  UserId is the user’s network id and is the primary key for the table. 
Application
Visual Studio 2010 Professional was used to create MySampleProject, using the ASP.NET MVC 4 Web Application wizard.  ADO.NET Entity Data Model tools were used to generate and refresh models based upon DocsDB tables.  DocumentMetaData.cs class was created to maintain custom model data annotations that would not get overwritten during refreshes of the Entity Data Model classes.  The remaining code written for this application is maintained in Controllers\HomeController.cs and Views\Home\Index.cshtml.

HomeController.cs
ActionResult Index() methods load the page and handle form submissions.  The entire form is submitted when the user is creating a new row.  Otherwise, the AJAX UpdateData() method is used when the user is updating an existing record.  Both methods use ObjectContext.SaveChanges() to update the database.

Index.cshtml
Index.cshtml displays data from the Document model loaded from the controller. jQuery is used to enable/disable table cells when clicked by the user.  The button controls call the EditMe() javascript function, passing the DocumentId key value, which is used to retrieve the correct form values before passing them as a parameters in a jQuery Ajax post().  

Misc Observations
Scope and time constraints of this project prevented me from addressing some items that would be included in an enterprise solution.  While the following listing is not comprehensive, they are among the first items that come to mind:
•	Application Access:  Since this is an internal site, the application would evaluate the network user’s id to authenticate against the AppUser table to authorize use of the site.  If the user’s network credentials were unavailable, a login page would be added, and I would consider adding a password field to the table to store hashed values.
•	Add a search page.
•	Include paging in the search results.
•	Include stored procedures for inserts and updates.
•	Use the database system date (vs. UI date) to update datestamp fields, either through triggers or in stored procedure code.
