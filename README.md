Change Directory
----------------
cd dotnet-core-sqlite-swagger-rest-api

Restore Packages
----------------
dotnet restore

Build Command
----------------
dotnet build

Run Command
----------------
dotnet run

Watch Command
----------------
dotnet watch run

Check Url
----------------
http://localhost:5000/swagger

https://localhost:5001/swagger

Download Required Packages
----------------
dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Swashbuckle.AspNetCore

dotnet tool install --global dotnet-ef
