# Bank Customer Management System (BCMS)
## 🏦 Overview
The Bank Customer Management System is a robust ASP.NET Core Web API designed to handle modern banking workflows. It utilizes Dependency Injection (DI) to deliver personalized customer experiences, ranging from standard greetings to premium VIP services.

## ✨ Key Features
* Layered Architecture: Clean separation of concerns between Service Logic, Models, and Contracts.

* Dynamic Greeting Engine: Swappable service implementations for different customer tiers.

* Interactive API: Fully integrated Swagger UI for real-time endpoint testing.

## 🏗 Project Structure
This repository follows the Clean Architecture pattern to ensure scalability:

- CMS.WebAPI: The entry point containing Controllers and middleware configuration.

- CMS.ServiceLogic: Core business logic hub. Includes a Classes sub-folder for specific implementations (e.g., StandardCustomerService).

- CMS.Contracts: Defined Request/Response Data Transfer Objects (DTOs) for secure data exchange.

- CMS.Model: Centralized domain entities representing the core data structure.

## 🚀 Getting Started
1. Clone the repo.

2. Run dotnet restore to install dependencies.

3. Hit F5 to launch the Swagger UI and test the /Customer/greet endpoint.