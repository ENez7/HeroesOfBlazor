## Heroes of Blazor

---
### Project Description

---
### SQL Server
The application uses SQL Server as the database management system. The following steps detail how to set up the database:

1. **Connection settings**  
   Edit the `appsettings.json` file to include the SQL Server connection string in the corresponding section:  
```json
{
   "ConnectionStrings": {
      "DefaultConnection": "Data Source=Home;Initial Catalog=HeroesOfBlazor;Trusted_Connection=True;TrustServerCertificate=True;"
   }
}
```
> You can change the database provider in the `Program.cs` file. Remember to install the corresponding NuGet package and uninstall the previous one.

2. **Database Migrations [(Más info)](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs)**  
   To create migrations and then apply them to the database you can use the following commands:
```.NET CLI
dotnet ef migrations add MigrationName
dotnet ef database update
```
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Or if you prefer to use the Package Manager Console:
```PowerShell
Add-Migration MigrationName
Update-Database
```

> If you are using Rider, checkout this [plugin](https://blog.jetbrains.com/dotnet/2022/01/31/entity-framework-core-inside-rider-ui-way/).

---
### Future Updates
There are no future updates planned for this project. This project is complete and no further updates are expected.
Besides that, feel free to fork this repository and make your own changes.
  
This was made as a learning project and it is not intended to be used in production.

---
### Portability and Containerization

This project is Dockerized, which ensures portability and facilitates deployment in different environments. The `Dockerfile` provides the necessary instructions for the container creation.

---

### Instructions for Use

1. **Clone the repo**
   ```
   git clone https://github.com/ENez7/HeroesOfBlazor.git
   ```

2. **Compile and Run**
   ```
   cd HeroesOfBlazor
   dotnet build
   dotnet run
   ```

3. **Access the App**  
   Once the application is running, you can access it through the web browser at [http://localhost:5169](http://localhost:5169).
> You can change the port according to your needs in `properties/launchSettings.json`
---
### Collaboration and Contributions

This project could be improved in many ways. If you want to collaborate, you can fork the repository and make your own changes. If you want to contribute to the project, you can open a pull request and I will review it as soon as possible.

---

### Problems and Issues

If you find any problems or need technical support, you can open an issue in the project's [issue tracker](https://github.com/ENez7/HeroesOfBlazor/issues)

---

**Software Engineer**  
**Enrique Núñez**
