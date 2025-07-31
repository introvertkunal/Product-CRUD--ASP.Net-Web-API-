# Architecture Web API 

A modular and scalable ASP.NET Core Web API project following **Clean Architecture** principles. Built with separation of concerns, AutoMapper for object mapping, and Entity Framework Core for data access.

---



## 🧭 Overview

This template is designed for building robust and testable Web APIs using ASP.NET Core and Clean Architecture. It organizes the solution into logical layers to promote maintainability and scalability.

---

## 🧱 Architecture

## [Client] 
↓
## [Presentation Layer] → Controllers, API 
↓
## [Application Layer] → Services, Use Cases 
↓
## [Domain Layer] → Business Models, Interfaces 
↓
## [Infrastructure Layer] → EF Core, APIs, Logging 


---

## ✨ Technologies Used

| Concern         | Technology         |
|----------------|--------------------|
| Framework       | ASP.NET Core       |
| Dependency Injection | Built-in DI Container |
| Object Mapping  | AutoMapper         |
| ORM             | Entity Framework Core |
| Testing         | xUnit, Moq         |
| Documentation   | Swagger (Swashbuckle) |
| Logging         | Serilog (optional) |

---

## 🔁 Object Mapping (AutoMapper)

Object mapping helps convert between:
- `CreateProductRequest` ⇄ `Product`  
- `Product` ⇄ `ProductResponse`
• Reduces repetitive code by automating object-to-object conversions.  
• Keeps controllers and services clean by handling transformations in one place.  
• Centralizes mapping logic, making it easier to maintain and update.  
• Enables a clear separation between domain models and data transfer objects (DTOs).

### 🔧 Example Mapping Profile
```csharp
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductResponse>();
        CreateMap<CreateProductRequest, Product>();
        CreateMap<UpdateProductRequest, Product>();
    }
}



