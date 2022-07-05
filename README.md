# PerfectPolicies-WebApplication
A C# Web Application that allows clients to create quizzes for users, and track performance through a ASP.NET Core 5.0 Web API, Front-End, and SQL Database.

### Description

This application's function is to provide the manipulation of database entries through a GUI. The scenario is, through this application, a small workshop will have to track the renting of tools, customer details, and tool details without managing the SQL queries and functions directly. Instead, employees and the employer will simply interact with a GUI.

There are search options in each menu to specifically find and filter an entry. The colour of the application can also be changed through the settings menu.

### Features



### Technologies Used

Developed in Visual Studio with The C# Programming Language.
Microsoft SQL Server Management Studio was utilized for the database portion of the application.

ASP.NET Core 5 was utilized to create the Web API, and the Web Application. Entity Framework was utilized to map objects sent from the front-end to the SQL Database. The entire application is developed in an MVC architectural pattern.

Swagger was used as middleware to test the Back-End. Razor Pages was utilzied to display the front-end. ChartJSCore and CSV Helper was utilized to display a chart with Javascript code and export this data to a .csv file.

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
