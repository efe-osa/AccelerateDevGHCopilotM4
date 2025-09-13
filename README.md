# Library App

## Description

Library App is a modular application designed to manage library operations such as book loans, patron management, and inventory tracking. It is built using .NET and follows a clean architecture approach to ensure scalability and maintainability.

## Project Structure

- `AccelerateDevGHCopilot.sln` - Solution file for the project.
- `src/`
  - `Library.ApplicationCore/`
    - `Entities/` - Contains core domain entities.
    - `Enums/` - Defines enumerations used across the application.
    - `Interfaces/` - Declares interfaces for core abstractions.
    - `Services/` - Implements business logic and domain services.
    - `Library.ApplicationCore.csproj` - Project file for the Application Core.
  - `Library.Console/`
    - `appSettings.json` - Configuration file for the console application.
    - `CommonActions.cs` - Contains reusable actions for the console app.
    - `ConsoleApp.cs` - Main application logic for the console interface.
    - `ConsoleState.cs` - Manages the state of the console application.
    - `Program.cs` - Entry point for the console application.
    - `Json/` - Contains JSON-related utilities or data.
    - `Library.Console.csproj` - Project file for the Console application.
  - `Library.Infrastructure/`
    - `Data/` - Contains data access implementations.
    - `Library.Infrastructure.csproj` - Project file for the Infrastructure layer.
- `tests/`
  - `UnitTests/`
    - `LoanFactory.cs` - Factory for creating test data related to loans.
    - `PatronFactory.cs` - Factory for creating test data related to patrons.
    - `ApplicationCore/` - Contains unit tests for the Application Core.
    - `UnitTests.csproj` - Project file for unit tests.

## Key Classes and Interfaces

- **Entities**
  - `Book` - Represents a book in the library.
  - `Patron` - Represents a library patron.
  - `Loan` - Represents a loan transaction.
- **Interfaces**
  - `IBookRepository` - Interface for book-related data operations.
  - `IPatronRepository` - Interface for patron-related data operations.
  - `ILoanService` - Interface for managing loan operations.
- **Services**
  - `LoanService` - Implements loan-related business logic.
  - `NotificationService` - Handles notifications for overdue loans.

## Usage

### Setup and Run

1. **Clone the repository:**

```bash
git clone https://github.com/efe-osa/AccelerateDevGHCopilotM4
cd AccelerateDevGHCopilotM4
```

2. **Restore dependencies and build the solution:**

```bash
dotnet restore
dotnet build
```

3. **Open the solution (optional):**

- Open `AccelerateDevGHCopilot.sln` in Visual Studio or the project in your preferred IDE for development.

4. **Run the console application:**

```bash
dotnet run --project src/Library.Console/Library.Console.csproj
```

5. **Execute unit tests:**

```bash
dotnet test tests/UnitTests/UnitTests.csproj
```

6. **(Optional) Add new projects or references:**

- Use Visual Studio or `dotnet` CLI to add new projects or references as needed for development or testing.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
