# 🔐 JWT Authentication Project

This project demonstrates a secure JWT (JSON Web Token) authentication implementation using ASP.NET Core 8.0.

## 🌟 Features

- 🔑 JWT-based authentication
- 👤 User registration and login
- 🛡️ Protected API endpoints
- 📝 Email validation
- 🔄 Token generation and validation
- 📚 Swagger UI with JWT support

## 🚀 Getting Started

### Prerequisites

- .NET 8.0 SDK
- SQL Server
- Visual Studio or VS Code

### 🛠️ Configuration

Add the following to your `appsettings.json`:

```json
{
  "Jwt": {
    "SecretKey": "H0xRKxMd5tCpEeD1tmqkeFV8r8ULbTE+R1HHENxoav87vO5cIQZgCG/YorUGsot6",
    "Issuer": "Jwt",
    "Audience": "https://localhost:5278",
    "ExpireMinutes": "45"
  },
 "ConnectionStrings": {
    "Default": "Server=MELIHCAN\\SQLEXPRESS;Database=JwtAppDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
}
```

## 📋 API Endpoints

### Authentication

#### 📝 Register
```http
POST /api/Auth/register
Content-Type: application/json

{
    "email": "user@example.com",
    "password": "password123"
}
```

#### 🔑 Login
```http
POST /api/Auth/login
Content-Type: application/json

{
    "email": "user@example.com",
    "password": "password123"
}
```

### Protected Endpoints

#### 🔒 Test Authentication
```http
GET /api/Test
Authorization: Bearer {your-jwt-token}
```

## 🔐 JWT Implementation Details

- Token generation using `Microsoft.IdentityModel.Tokens`
- Claims-based authentication
- Token validation middleware
- Secure password handling
- Email uniqueness validation

## 🛡️ Security Features

- Token expiration
- Issuer validation
- Audience validation
- Signature validation
- HTTPS enforcement

## 🧪 Testing with Swagger

1. Launch the application
2. Navigate to `/swagger`
3. Click "Authorize" button
4. Enter your JWT token with "Bearer " prefix
5. Test protected endpoints

## 📦 Dependencies

- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Swashbuckle.AspNetCore