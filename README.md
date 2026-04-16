# Health Insurance Razor Pages Project

## 🚀 Features

* Health Insurance Website UI
* Quote Request Form
* Contact Form
* SQL Server Integration
* Admin Panel (Login + Dashboard)

## 🛠 Technologies Used

* ASP.NET Core Razor Pages
* Entity Framework Core
* SQL Server
* HTML, CSS

## ⚙️ Setup Instructions

1. Clone the repository:

```bash
git clone https://github.com/RRahulpal/HealthInsurance.git
```

2. Open in Visual Studio

3. Update connection string in `appsettings.json`

4. Run migration:

```bash
dotnet ef database update
```

5. Run the project


Database chnages on 15th April 2026
CREATE TABLE QuoteRequests
(
    Id INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Mobile NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    PlanType NVARCHAR(50) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
## 👨‍💻 Author

Rahul Pal
