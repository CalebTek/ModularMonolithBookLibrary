# Modular Monolith Book Library Demo

This repository contains a modular monolith demonstration application for managing a book library system. The application is divided into three modules: Books, Management, and Users. Each module represents a distinct business domain and communicates through events.

## Modules

### 1. Books Module (Short Name: `Books`)
- Manages the catalog of available books.
- Handles book information, categories, and related operations.

### 2. Administration Module (Short Name: `Admin`)
- Provides administrative functionalities.
- Allows users with administrative roles to manage books, permissions, and meeting group proposals.

### 3. Users Module (Short Name: `Users`)
- Manages user-related operations.
- Handles user information, roles, and related user management tasks.

## Technologies Used
- .NET Core
- C#
- Entity Framework Core
- MediatR for CQRS
- Event-driven communication using an in-memory event bus
- Docker (optional)

## Getting Started

### Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started) (optional)

### Running the Application
1. Clone the repository.
2. Navigate to each module directory (Books, Management, Users) and run `dotnet run` to start each module.
3. Explore the provided API endpoints for each module.

## Contributing
Contributions are welcome! Feel free to open issues, submit pull requests, or provide feedback.

