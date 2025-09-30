# Travel Expense Management Web API (ASP.NET)

A RESTful Web API for managing travel requests and expense claims, designed using classic **ASP.NET Web API** (not Core), with a strong N-Tier architecture and best coding practices.

---

## Features

- **Travel Requests**: Employees submit and track travel requests.
- **Expense Claims**: Submit claims with receipt details for approved travel.
- **Approval Workflow**: Managers approve/reject requests and claims.
- **Notifications**: Users receive notifications on status changes.
- **Advanced Filtering & Search**: Find requests/claims by user, status, dates, etc.
- **Expense Reports**: Generate summaries per user, trip, or period.
- **Budget Enforcement**: Claims cannot exceed user or trip budget.
- **Audit Logging**: All actions (submit, approve, reject) are logged.

---

## Architecture

- **N-Tier Design**:
  - **Presentation Layer**: API Controllers (exposes RESTful endpoints)
  - **Business Logic Layer (BLL)**: Services (enforces rules, workflows)
  - **Data Access Layer (DAL)**: Repositories (Entity Framework, SQL Server)
- **SOLID Principles**:  
  Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion

---

## Technologies

- **ASP.NET Web API (classic, not Core)**
- **Entity Framework 6**
- **SQL Server**
- **JSON** for all requests and responses

---

## Getting Started

### Prerequisites

- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/)
- [.NET Framework 4.6.1+](https://dotnet.microsoft.com/download/dotnet-framework)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/MarufSiddikiGalib/travel-expense-api.git
   cd travel-expense-api
   ```

2. **Configure the Database Connection:**
   - Update the connection string in `Web.config`:
     ```xml
     <connectionStrings>
       <add name="DefaultConnection" connectionString="Data Source=YOUR_SERVER;Initial Catalog=TravelExpenseDb;Integrated Security=True;" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

3. **Update Database (EF Migrations):**
   - Open the Package Manager Console in Visual Studio:
     ```
     Update-Database
     ```

4. **Run the Application:**
   - Press `F5` or click "Start" in Visual Studio.
   - By default, the API will be accessible at `http://localhost:xxxx/api/`

5. **Test the API:**
   - Use [Postman](https://www.postman.com/) or [Swagger UI](https://github.com/heldersepu/Swagger-Net) if integrated.

---

## API Endpoints (Examples)

- `POST /api/travelrequests` — Submit a travel request
- `GET /api/travelrequests/search?...` — Advanced search/filtering
- `POST /api/expenseclaims` — Submit an expense claim
- `POST /api/expenseclaims/{id}/approve` — Approve/reject claims
- `GET /api/reports/expenses?...` — Expense reports
- `GET /api/notifications/{userId}` — View notifications

---

## Project Structure

```
/Controllers      // API Endpoints (Presentation Layer)
/Services         // Business Logic Layer (BLL)
/Repositories     // Data Access Layer (DAL)
/Models           // Entity models (EF POCOs)
/DTOs             // Data Transfer Objects
/Migrations       // EF Migrations
/Web.config       // Configuration
```

---

## Functionalities Beyond CRUD

1. **Advanced Filtering/Search**  
   Find requests or claims by user, date, status, destination, and more.

2. **Expense Reports**  
   Get summaries by user, trip, or time period in JSON format.

3. **Automated Notifications**  
   Notify users when requests or claims are approved/rejected.

4. **Budget Enforcement**  
   Prevent claims exceeding user/trip budget, show remaining budget.

5. **Audit Logging**  
   Every action (submit, update, approve, reject) is logged and retrievable.

---

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -am 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## License

This project is open source and available under the [MIT License](LICENSE).

---

## Author

- [Maruf Siddiki Galib](https://github.com/MarufSiddikiGalib)
