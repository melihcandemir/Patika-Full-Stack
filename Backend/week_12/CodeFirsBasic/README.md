# CodeFirstBasic 🎬🎮

Welcome to the CodeFirstBasic project! This project demonstrates a basic implementation of Code-First approach using Entity Framework Core with ASP.NET Core.

## Project Structure 📁

- **Models**: Contains the data models `Movie` and `Game`.
- **Data**: Contains the `PatikaFirstDbContext` which is the database context.
- **Controllers**: Contains the API controllers (not included in the current setup).
- **Properties**: Contains the launch settings for the project.
- **wwwroot**: Static files (not included in the current setup).

## Getting Started 🚀

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)

### Setup Instructions

1. **Clone the repository**:
    ```bash
    git clone https://github.com/melihcandemir/Patika-Full-Stack.git
    cd CodeFirstBasic
    ```

2. **Update the connection string**:
    Update the connection string in `appsettings.json` to match your PostgreSQL setup.
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

3. **Run the migrations**:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4. **Run the application**:
    ```bash
    dotnet run
    ```

### Usage

- The application will be available at `http://localhost:5008`.
- Swagger UI will be available at `http://localhost:5008/swagger`.

## Models

### Movie 🎥

```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Gerne { get; set; }
    public int ReleaseYear { get; set; }
}
```

### Game 🎮

```csharp
public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Platform { get; set; }
    public decimal Rating { get; set; }
}
```

Happy coding! 😊
