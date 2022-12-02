# Postgress DB

## Local Database Installation

https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?source=recommendations&tabs=netcore-cli

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update

## crud

https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?source=recommendations&tabs=netcore-cli#create-read-update--delete

## TODOs
- Get this in docker-compose or other script
- Use local volume for db
- Use env/config db cn strings for each environment
- Determine how updates will be applied to running prod containers/db instances
- 