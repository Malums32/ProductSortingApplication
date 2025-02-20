# Product Sorting Application

A C# application for managing and sorting products with database integration.

## Project Structure

```
ProductSortingAppWithDB/
├── Models/
│   ├── CustomerActivity.cs
│   └── Products.cs
├── Services/
│   └── IProductService.cs
│   └── ProductService.cs
├── UI/
│   ├── ConsoleDisplay.cs
│   └── ConsoleUI.cs
├── Utilities/
│   ├── Interfaces/
│   │   ├── ProductManager.cs
│   │   ├── SessionManager.cs
│   │   └── UserSessionManager.cs
│   ├── DatabaseHelper.cs
│   └── DatabaseLogger.cs
├── App.config
├── appsettings.json
└── Program.cs
```

## Features

- Product management and sorting functionality
- Customer activity tracking
- Database integration with logging capabilities
- Console-based user interface
- Session management system

## Components

### Models
- `CustomerActivity.cs`: Handles customer interaction data
- `Products.cs`: Product data model

### Services
- `IProductService.cs`: Interface defining product-related operations
- `ProductService.cs`: Implementation of product service operations

### UI Components
- `ConsoleDisplay.cs`: Handles display formatting and output
- `ConsoleUI.cs`: Main console interface implementation

### Utilities
- `DatabaseHelper.cs`: Database connection and operation utilities
- `DatabaseLogger.cs`: Logging system for database operations

### Interface Implementations
- `ProductManager.cs`: Manages product-related operations
- `SessionManager.cs`: Handles general session management
- `UserSessionManager.cs`: Manages user-specific sessions

## Configuration

The application uses two configuration files:
- `App.config`: Application configuration settings
- `appsettings.json`: JSON-based application settings

## Getting Started

1. Ensure you have the .NET SDK installed
2. Clone the repository
3. Configure the database connection in `appsettings.json`
4. Build the project:
   ```bash
   dotnet build
   ```
5. Run the application:
   ```bash
   dotnet run
   ```

## Technical Requirements

- .NET Core/.NET 5+ (specific version to be specified)
- SQL Server/Database (specific version to be specified)

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

[License Type] - Specific license to be determined
