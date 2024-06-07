This is how is look like our database scheme


![image](https://github.com/NickAdvisor95/TravelAgency/assets/93551467/b6852c30-847d-4710-897a-51118a97062e)

The project is running on Asp.Net Core MVC v6
Requirements:

In order to run the project:
1. Open the TravelAgency.sln in Microsoft Visual Studio
2. Open 'Solution Explorer' -> right click on 'TravelAgency' project -> 'Manage NuGet Packages'
3. Browse for and install these packages:
    • GeoCoordinate.NetCore
    • MathNet.Numerics
    • Microsoft.EntityFrameworkCore
    • Microsoft.EntityFrameworkCore.Design
    • Microsoft.EntityFrameworkCore.SqlServer
    • Microsoft.EntityFrameworkCore.Tools
    • Microsoft.EntityFrameworkCore.Debug
    • Microsoft.VisualStudio.Web.CodeGeneration.Design
    • Microsoft.AspNetCore
4. You have to configure you local SQL server (with SQL Server 2022 Configuration Manager)
5. Open 'Server Explorer' in Visual Studio
6. Right click in 'Data Connections'-> 'Add Connection'
7. In the new opened window:
    • Set the 'Data source' field to 'Microsoft SQL Server (SqlClient)'
    • 'Server name': [your server name]
    • 'Authentification': 'Windows Authentification' (recommended)
    • Enter a db name for your choice in the field below
    • Press 'OK'
    • Right click in 'Data Connections'-> 'Refresh'
8. Open 'Server Explorer' -> open 'Data Connections'-> right click on the new connection you've added -> 'Properties'
9. Copy the 'Connection String' value
10. Open 'appsettings.json' file in the main project path -> paste copied value instead of "your connection string" in line 3 of code
11. Open 'Package Manager Console'
12. Run the command 'Update-Database'
13. Run the project (Note: the first run will seed the database with initial data, wait a couple seconds)


