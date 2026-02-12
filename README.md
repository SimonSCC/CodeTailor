# CodeTailor

[![NuGet](https://img.shields.io/nuget/v/CodeTailor.Domain.svg)](https://www.nuget.org/packages/CodeTailor.Domain/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

> A curated collection of Clean Architecture utilities and patterns tailored for everyday development.

**CodeTailor** provides battle-tested helpers, base classes, and patterns organized by Clean Architecture layers. Stop rewriting the same boilerplate across projects—let CodeTailor handle the common stuff so you can focus on what makes your application unique.

## Installation

CodeTailor is organized by Clean Architecture layers. Install only the layers you need:

```bash
# Domain Layer - Entities, Value Objects, Domain Events
dotnet add package CodeTailor.Domain

# Application Layer - CQRS, Commands, Queries, Use Cases
dotnet add package CodeTailor.Application

# Infrastructure Layer - Data Access, Repositories, External Services
dotnet add package CodeTailor.Infrastructure

# Presentation Layer - API Controllers, View Models, DTOs
dotnet add package CodeTailor.Presentation

# Testing - Test Utilities, Builders, Fakes
dotnet add package CodeTailor.Testing
```

## Packages

Organized following Clean Architecture principles:

### 🎯 CodeTailor.Domain
The innermost layer - your business logic core:
- **Entities** - Base entity classes with domain events
- **Value Objects** - Immutable value object helpers
- **Domain Events** - Event-driven domain patterns
- **Aggregates** - Aggregate root patterns

### 💼 CodeTailor.Application
Use cases and business workflows:
- **CQRS** - Command and Query patterns
- **Commands/Queries** - Base classes for CQRS
- **Use Cases** - Application service patterns
- **Behaviors** - Pipeline behaviors (validation, logging, etc.)

### 🏗️ CodeTailor.Infrastructure
External concerns and persistence:
- **Repositories** - Repository pattern implementations
- **Data Access** - EF Core helpers and patterns
- **External Services** - Integration patterns
- **Caching** - Caching utilities

### 🌐 CodeTailor.Presentation
Web API and UI concerns:
- **API Controllers** - Base controller classes
- **View Models** - DTO and ViewModel patterns
- **Mapping** - Object mapping utilities
- **Validation** - Input validation helpers

### 🧪 CodeTailor.Testing
Make testing easier:
- **Test Builders** - Fluent builders for test data
- **Fakes** - In-memory implementations
- **Assertions** - Custom test assertions
- **Fixtures** - Reusable test setups

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author

**SimonSCC**

- GitHub: [@SimonSCC](https://github.com/SimonSCC)
- Repository: [CodeTailor](https://github.com/SimonSCC/CodeTailor)
