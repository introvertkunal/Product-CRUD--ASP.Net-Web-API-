# Architecture Web API 

A modular and scalable ASP.NET Core Web API project following **Clean Architecture** principles. Built with separation of concerns, AutoMapper for object mapping, and Entity Framework Core for data access.

---



## 🧭 Overview

This template is designed for building robust and testable Web APIs using ASP.NET Core and Clean Architecture. It organizes the solution into logical layers to promote maintainability and scalability.

---

## 🧱 Architecture

## [Client] 
↓
## [Presentation Layer] → Controllers, API ---
↓
## [Application Layer] → Services, Use Cases ---
↓
## [Domain Layer] → Business Models, Interfaces ---
↓
## [Infrastructure Layer] → EF Core, APIs, Logging 

