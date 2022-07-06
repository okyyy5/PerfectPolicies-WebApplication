# PerfectPolicies-WebApplication
A C# Web Application that allows clients to create quizzes for users, and track performance through a ASP.NET Core 5.0 Web API, Front-End, and SQL Database.

### Description

This application's function is to allow the ability to provide a platform for quiz creation that can be accessed remotely through any device. The scenario is that the user, which is a quiz creating company, can allow clients to subscribe to this platform, after which these clients can create quizzes for their respective employees.

### Features

The entire application can be accessed through an interactable web application, which can be accessed from any device when deployed to an appropriate platform such as Azure. All webpages of the application have a navigation bar at the top. Each page has functionality relating to the creation and viewing the details of quizzes, options, and questions. A user must be authenticated through the login page with appropriate details for more functionality, such as deleting and editing data.

Data can be filtered on all respective pages. For example, if a user wants to see the options for only a particular question, then they have to navigate to the questions page and click on the options button next to the respective question that is to be filtered.

The Display Chart page presents a bar chart containing an easy visual representation regarding the number of questions per quizzes. This data can be exported to a .csv file through the same page by pressing the respective button.

A Help page with instructions and pictures have been included for more assistance.

This application was developed as a way to explore different aspects of development in C# and ASP.NET Core 5 such as:
- MVC architectural pattern
- Web GUI Design
- Multiple Inheritance
- REST architectural style
- Drag and Drop Features with JavaScript
- 2-D Graphics
- Token Authentication and Cookies
- API and Database Design
- Cloud Deployment
- DTO Patterns
- Web Services

### Technologies Used

Developed in Visual Studio with The C# Programming Language.
Microsoft SQL Server Management Studio was utilized for the database portion of the application.

ASP.NET Core 5 was utilized to create the Web API, and the Web Application. Entity Framework was utilized to map objects sent from the front-end to the SQL Database. The entire application is developed in an MVC architectural pattern.

Swagger was used as middleware to test the Back-End. Razor Pages was utilized to display the front-end. ChartJSCore and CSV Helper was utilized to display a chart with JavaScript code and export this data to a .csv file.

Originally deployed to Azure but can still be utilized locally.

### How to Use and Install

The executable is located in \bin\Release folders for both the front-end and back-end

However, this application was developed as a way to explore different aspects of development in C# and SQL, as such running the source code directly in a relevant environment is recommended. Either way an application that can manage an SQL Database must be utilized.

The application itself is self-explanatory. Navigate the website, add Quizzes, Questions, Options etc., authenticate yourself with the seeded user data, by checking the source code, for extra features such as deleting data. Display and export chart data for the number of questions per quiz from the relevant page.

Database must be seeded before application is run. To do this, delete the migration folder and any pre-existing database with the same name, and from the NuGet Package Manager Console run the following code:

add-migration <migration name>

Update-database

The connection strings in the appsettings.json files for both the front-end and back-end may need to be modified for compatibility.

Consult the Software Implementation Plan, Software Installation Plan, and Technical Report for more details alongside how to deploy the application to Azure.

### Credits

<a href="https://www.linkedin.com/in/oktay-turdu/">Oktay Turdu</a>

### Licence

GNU General Public License v3.0
