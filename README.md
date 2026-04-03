Bank Management System (BMS)
Developer: Manuela Taborda Muñoz

Course: Software Construction II

Institution: University Faculty of Engineering

Project Overview
This repository contains a robust Bank Management System designed to demonstrate the practical application of Clean Architecture and Domain-Driven Design (DDD). The system manages core banking operations, including user registration, account management, and financial transactions, ensuring high integrity and strict separation of concerns.

Architectural Structure
The solution is organized into four distinct layers to ensure maintainability, scalability, and testability:

BankManagementSystem.Domain
The core layer containing enterprise business rules, entities (e.g., BankAccount), and value objects. It maintains zero dependencies on external layers.

BankManagementSystem.Application
Implementation of Domain Services (AccountService, UserService). This layer coordinates application flow, implements core use cases, and manages Data Transfer Objects (DTOs).

BankManagementSystem.Infrastructure
Handles data persistence and external concerns. Currently implemented with an In-Memory storage provider for demonstration and testing purposes.

BankManagementSystem.API
The system's entry point. A RESTful API built with ASP.NET Core that exposes endpoints for external interaction, fully documented via Swagger UI.

Functional Specifications
Automated User Onboarding: Automatic creation of a linked bank account upon successful user registration.

Transaction Management: Secure deposit and withdrawal operations with real-time balance and business rule validation.

Funds Transfer: Atomic transfer logic between accounts utilizing double-entry validation to ensure financial consistency.

API Documentation: Interactive technical documentation provided by Swagger for endpoint verification and testing.

Technical Stack
Language: C# 13 / .NET 10.0

Framework: ASP.NET Core Web API

Architecture: Clean Architecture (Onion Pattern)

Design Patterns: Dependency Injection, Repository Pattern (In-Memory), DTO Pattern.

Version Control: Git & GitHub

Execution Instructions
Clone the repository:

git clone https://github.com/tabordam1910/BankManagementSystem.git

Open the solution file in Visual Studio 2022.

Set BankManagementSystem.API as the Startup Project.

Execute the application (F5) and navigate to the Swagger UI.

Academic Project - 2026
