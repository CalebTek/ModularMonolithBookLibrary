# Modular Monolith Book Library Demo

This repository contains a modular monolith demonstration application for managing a book library system. The application is divided into three modules: Catalog, Administration, and Inventory. Each module represents a distinct business domain and communicates through events.

## Modules

### 1. Catalog Module
- Manages the catalog of available books.
- Handles book information, categories, and related operations.

### 2. Administration Module
- Provides administrative functionalities.
- Allows users with administrative roles to manage users, permissions, and meeting group proposals.

### 3. Inventory Module
- Manages the inventory of available books.
- Handles book quantities, restocking, and related inventory operations.

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
2. Navigate to each module directory (Catalog, Administration, Inventory) and run `dotnet run` to start each module.
3. Explore the provided API endpoints for each module.

## Contributing
Contributions are welcome! Feel free to open issues, submit pull requests, or provide feedback.

