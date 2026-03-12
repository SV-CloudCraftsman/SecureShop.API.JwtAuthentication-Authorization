SecureShop.API.JwtAuthentication-Authorization

SecureShop.API.JwtAuthentication-Authorization is a secure ASP.NET Core Web API demonstrating JWT-based authentication and authorization. The project implements token generation, secure API protection, and Swagger integration with Bearer authentication support.

This project showcases modern ASP.NET Core security practices and is designed to be deployment-ready for Azure App Services.

⸻

Features
	•	JWT Authentication using Microsoft IdentityModel Tokens
	•	Secure API endpoints with Authorization attributes
	•	Swagger UI integration with Bearer token authentication
	•	Configurable JWT settings via appsettings.json or environment variables
	•	Production-ready configuration for Azure App Services
	•	Clean and minimal ASP.NET Core middleware pipeline

⸻

Tech Stack
	•	ASP.NET Core Web API
	•	C#
	•	JWT (JSON Web Token)
	•	Swagger / OpenAPI
	•	Dependency Injection
	•	Azure App Service compatible configuration

⸻

Project Structure
SecureShop.API
│
├── Controllers
│     └── AuthController.cs
│
├── Services
│     └── TokenService.cs
│
├── Configuration
│     └── JwtSettings.cs
│
├── Program.cs
├── appsettings.json
└── SecureShop.API.csproj


Authentication Flow
Client Login
     ↓
POST /api/auth/login
     ↓
Server validates credentials
     ↓
JWT Token generated
     ↓
Client stores token
     ↓
Client sends request with Authorization header
     ↓
Authorization: Bearer <token>
     ↓
JWT middleware validates token
     ↓
Protected API endpoint executes
