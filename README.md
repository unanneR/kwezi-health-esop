# KweziHealth Systems - Enterprise Staff Operations Platform (ESOP)

Phase 1 implementation of the Enterprise Staff Operations Platform (ESOP) for KweziHealth Systems. This web application provides a secure, modular, and scalable staff administration portal built with C# and ASP.NET Core MVC.

---

## Technical Stack & Architecture

- **Framework:** .NET 8.0 / ASP.NET Core MVC
- **Language:** C#
- **Authentication:** Cookie-based Authentication Middleware
- **Service Layer:** In-Memory Data Storage (`StaffService`)
- **Frontend:** Razor Views, HTML5, Bootstrap 5

### Project Structure

```text
kwezi-health-esop/
├── Controllers/
│   ├── AccessController.cs   # Handles Admin Login, Logout, and Session Authentication
│   └── StaffController.cs    # Manages CRUD operations for Staff Members
├── Models/
│   ├── StaffMember.cs        # Entity model for staff details
│   └── SystemAdmin.cs        # Entity model for admin login credentials
├── Services/
│   └── StaffService.cs       # In-memory service layer handling business logic
├── Views/
│   ├── Access/
│   │   └── Login.cshtml      # Admin login page
│   └── Staff/
│       └── Index.cshtml      # Unified Staff Directory & CRUD management view
├── Program.cs                # Application configuration, DI, middleware, and routing
└── kwezi-health-esop.csproj