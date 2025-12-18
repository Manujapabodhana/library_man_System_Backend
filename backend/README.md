# Library Management System - Backend

A RESTful API backend for a Library Management System built with ASP.NET Core and Entity Framework Core.

## Technologies Used

- **Framework**: ASP.NET Core (.NET 9.0)
- **Database**: Entity Framework Core
- **Authentication**: JWT-based authentication
- **Language**: C#

## Features

- User authentication and authorization
- Book management (CRUD operations)
- Database migrations with Entity Framework Core
- RESTful API design
- Data Transfer Objects (DTOs) for clean separation of concerns

## Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server or another compatible database
- A code editor (Visual Studio, VS Code, or Rider)

## Project Structure

```
backend/
├── Controllers/          # API Controllers
│   ├── AuthController.cs
│   └── BookControllers.cs
├── Data/                # Database context
│   └── LibraryDbContex.cs
├── DTOs/                # Data Transfer Objects
│   ├── AuthDTOs.cs
│   └── BookDTOs.cs
├── Migrations/          # EF Core migrations
├── Models/              # Domain models
│   ├── book.cs
│   └── User.cs
├── Properties/          # Launch settings
├── appsettings.json     # Configuration
└── Program.cs           # Application entry point
```

## Installation & Setup

1. **Clone the repository**

   ```bash
   cd d:\intern\library_man_System_Backend\backend
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Update database connection string**

   Edit `appsettings.json` or `appsettings.Development.json` to configure your database connection string.

4. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

## Running the Application

### Development Mode

```bash
dotnet run
```

Or with hot reload:

```bash
dotnet watch run
```

### Production Mode

```bash
dotnet run --configuration Release
```

The API will be available at:

- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

(Check `Properties/launchSettings.json` for exact URLs)

## API Endpoints

### Authentication

- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Login and receive JWT token

### Books

- `GET /api/books` - Get all books
- `GET /api/books/{id}` - Get a specific book
- `POST /api/books` - Create a new book (authenticated)
- `PUT /api/books/{id}` - Update a book (authenticated)
- `DELETE /api/books/{id}` - Delete a book (authenticated)

## Database Migrations

### Create a new migration

```bash
dotnet ef migrations add MigrationName
```

### Apply migrations to database

```bash
dotnet ef database update
```

### Remove last migration

```bash
dotnet ef migrations remove
```

## Configuration

Key configuration settings in `appsettings.json`:

- **ConnectionStrings**: Database connection configuration
- **JWT Settings**: Token generation and validation settings
- **Logging**: Application logging configuration

## Development

### Build the project

```bash
dotnet build
```

### Run tests

```bash
dotnet test
```

### Clean build artifacts

```bash
dotnet clean
```

## Contributing

1. Create a feature branch
2. Make your changes
3. Test thoroughly
4. Submit a pull request

## License

[Specify your license here]

## Contact

[Add your contact information or team details]
