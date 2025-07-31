# 🧱 C# Clean Architecture Web API Template

A modular and scalable ASP.NET Core Web API project following **Clean Architecture** principles. Built with separation of concerns, AutoMapper for object mapping, and Entity Framework Core for data access.

---

## 📚 Table of Contents

- [Overview](#-overview)
- [Architecture](#-architecture)
- [Project Structure](#-project-structure)
- [Technologies Used](#-technologies-used)
- [Setup Instructions](#-setup-instructions)
- [Object Mapping with AutoMapper](#-object-mapping-with-automapper)
- [Example Code](#-example-code)
- [Testing](#-testing)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🧭 Overview

This template is designed for building robust and testable Web APIs using ASP.NET Core and Clean Architecture. It organizes the solution into logical layers to promote maintainability and scalability.

---

## 🧱 Architecture

[Client]
↓
[Presentation Layer] → Controllers, API
↓
[Application Layer] → Services, Use Cases
↓
[Domain Layer] → Business Models, Interfaces
↓
[Infrastructure Layer] → EF Core, APIs, Logging

