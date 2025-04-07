# Identity Data Protection Project 🔐

This project demonstrates secure password encryption using ASP.NET Core's Data Protection API.

## Features ⭐

- User registration with encrypted passwords 🔒
- Secure login with password decryption 🔑
- Data Protection using IDataProtector 🛡️
- User management endpoints 👥

## Password Protection Implementation 🔐

The project uses `IDataProtector` from ASP.NET Core's Data Protection API to securely encrypt and decrypt passwords:

```csharp
public class UserControllers : ControllerBase
{
    private readonly IDataProtector _dataProtector;

    public UserControllers(IDataProtectionProvider dataProtectionProvider, AppDbContext context)
    {
        // Create a protector with a specific purpose
        _dataProtector = dataProtectionProvider.CreateProtector("UserDataProtection");
    }
}
```

### Password Encryption 🔒
When registering a new user, the password is encrypted:
```csharp
// During registration
var newUser = new User
{
    Email = data.Email,
    Password = _dataProtector.Protect(data.Password) // Encrypts the password
};
```

### Password Decryption 🔓
During login, the stored password is decrypted for comparison:
```csharp
// During login
var decryptedPassword = _dataProtector.Unprotect(user.Password);
if (decryptedPassword != data.Password)
{
    return BadRequest("Incorrect password.");
}
```

## API Endpoints 🌐

- POST `/api/user/register` - Register a new user
- GET `/api/user/login` - User login
- GET `/api/user/getall` - Get all users
- GET `/api/user/getbyid/{id}` - Get user by ID

## Security Features 🛡️

- Passwords are never stored in plain text
- Data Protection API provides secure encryption
- Purpose-bound encryption with "UserDataProtection" purpose string
- Automatic key management and rotation

## Getting Started 🚀

1. Clone the repository
2. Update the connection string in `appsettings.json`
3. Run database migrations
4. Start the application

## Dependencies 📦

- ASP.NET Core 8.0
- Entity Framework Core
- Microsoft.AspNetCore.DataProtection
