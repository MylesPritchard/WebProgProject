This is a Hospital Management System in ASP.NET MVC with C#.

To run, the database needs to be initialized. On Visual Studio, this is done by opening the NuGet Package Manager Console (under Tools) and creating a new database migration. To do this, run Add-Migration, and then Update-Database.

The application consists of four main pages: Home, Doctors, Patients, and Visits, among others. Doctors, Patients, and Visits are stored in the database with full CRUD implementation (However, only Doctors can be viewed without being logged in). There is also an account system and search functionality by different criteria for Doctors and Patients.
