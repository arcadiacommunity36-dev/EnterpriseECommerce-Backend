# Enterprise E-Commerce Backend (.NET 10)

A production-ready, highly scalable, and loosely coupled E-Commerce backend built using the industry-standard **Clean Architecture** and **CQRS (Command Query Responsibility Segregation)** design patterns. This project is specifically designed to showcase modern backend engineering principles, performance optimization, and robust data validation.

---

## 🏗️ Architectural Overview & Clean Architecture Layers

This project strictly follows **Clean Architecture** principles to ensure the core business logic remains independent of external frameworks, databases, or UI components.



- **`Domain`**: The core of the application. Contains domain entities (`Product`, `Category`), custom exceptions, and core domain rules. It has absolutely zero external dependencies.
- **`Application`**: Contains the business logic, CQRS commands/queries, handlers, DTOs, interface definitions (e.g., `IApplicationDbContext`), and validation rules.
- **`Persistence`**: Implements the data access logic using **Entity Framework Core (Code-First)**, manages the database context, configures Fluent API relationships, and handles SQL Server migrations.
- **`WebAPI`**: The presentation layer. Exposes RESTful HTTP endpoints using controllers and handles dependency injection orchestration.

---

## 🚀 Key Features & Tech Stack

- **Framework:** .NET 8/9 Core (Web API)
- **Database & ORM:** MS SQL Server with **Entity Framework Core**
- **Design Patterns:** CQRS Pattern managed via **MediatR** for decoupled read/write operations
- **Data Validation:** Pipeline-ready **FluentValidation** securing incoming request payloads
- **API Documentation:** Interactive **Swagger UI / OpenAPI** integration for effortless testing
- **Clean Code Practices:** Centralized configurations via Fluent API to keep entities lightweight

---

## 🛠️ Getting Started

### Prerequisites
- .NET 10
- MS SQL Server (LocalDB or Express instance)

### Installation & Local Setup

1. **Clone the repository:**

   bash
   
   git clone [https://github.com/arcadiacommunity36-dev/EnterpriseECommerce-Backend.git](https://github.com/arcadiacommunity36-dev/EnterpriseECommerce-Backend.git)
   cd EnterpriseECommerce-Backend
   
2. Database Configuration:
Open src/EnterpriseECommerce.WebAPI/appsettings.json and verify the SQL Server connection string under ConnectionStrings:

json

"ConnectionStrings": {
  "SqlConnection": "Server=.;Database=EnterpriseECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;"
}

3. Apply Entity Framework Migrations:
Run the following command from the root directory to automatically generate the database and its relational tables:

  bash

  dotnet ef database update --project src/EnterpriseECommerce.Persistence --startup-project src/EnterpriseECommerce.WebAPI

4. Run the Application:
Start the Web API server using the .NET CLI:

  bash

  dotnet run --project src/EnterpriseECommerce.WebAPI

5. Explore the API:
Once the application starts, open your browser and navigate to the interactive API playground:
👉 http://localhost:5238/swagger

🔒 License
This project is open-source and available under the MIT License.
