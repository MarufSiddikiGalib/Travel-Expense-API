# Travel Expense Management API

This project is a **N-tiered ASP.NET solution** for managing travel expenses. It follows best practices including N-tier architecture, SOLID principles, and is designed for modularity and maintainability.

---

## Solution Structure

- **DAL**  
  Data Access Layer. Contains Entity Framework models, database context, repository interfaces and implementations.

- **BLL**  
  Business Logic Layer. Contains business logic, services, and DTOs.

- **PresentationAPI**  
  Web API Layer. Exposes RESTful endpoints for all business operations (CRUD, approval workflows, search/filter, reporting, notifications, etc).

- **PresentationMVC**  
  (Optional) ASP.NET MVC project for web-based UI (pages, views, etc).

---

## Features

- **Travel Requests:** Submission, approval, status management.
- **Expense Claims:** CRUD operations, approval workflow, file uploads for receipts.
- **Notifications:** In-app (API endpoint) notifications for approvals/rejections.
- **Reporting:** Expense summaries, filters by user/date/status/trip.
- **Budget Enforcement:** Prevents over-budget claims.
- **Audit Logging:** Track all user actions for compliance.

---

## Technologies Used

- **ASP.NET Web API**
- **ASP.NET MVC** (optional)
- **Entity Framework (EF 6 or Core)**
- **SQL Server** (or compatible RDBMS)
- **C#**
- **N-tier architecture**
- **SOLID principles**

---

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework (or .NET Core if using Core projects)
- SQL Server (Express/LocalDB is sufficient for dev)
- NuGet packages: EntityFramework, Microsoft.AspNet.WebApi, etc.

### How to Run

1. **Clone the repository.**
2. **Open the solution** in Visual Studio.
3. **Restore NuGet packages.**
4. **Set up the database connection string** in `DAL\App.config` or `PresentationAPI\web.config`.
5. **Apply EF migrations** (if using Code First).
6. **Set `PresentationAPI` as the startup project.**
7. **Run the project**. Use Postman, Swagger, or any API client to test endpoints.

### Folder Structure

- `DAL/EF/` — Entity Framework context and entities
- `DAL/Interfaces/` — Repository interfaces
- `DAL/Repos/` — Repository implementations
- `BLL/DTOs/` — Data Transfer Objects
- `BLL/Service/` — Business logic/services
- `PresentationAPI/Controllers/` — API endpoints
- `PresentationMVC/` — (If used) MVC controllers, views, models

---

## Contribution

Pull requests are welcome. For major changes, open an issue first to discuss what you would like to change.

---

## License

This project is for educational use.
