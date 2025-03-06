# CodeFirstRelation Project 🚀

This project demonstrates a simple Code-First approach using Entity Framework Core with a PostgreSQL database. It includes basic entities and relationships.

## Project Structure 📂

- **Data**: Contains the DbContext and entity classes.
- **Controllers**: API controllers for handling HTTP requests.
- **Properties**: Configuration files for the project.
- **wwwroot**: Static files for the web application.

## Getting Started 🛠️

### Prerequisites

- .NET 8.0 SDK
- PostgreSQL

### Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/melihcandemir/Patika-Full-Stack.git
   cd CodeFirstRelation
   ```

2. Update the database connection string in `PatikaSecondDbContext.cs`:
   ```csharp
   optionsBuilder.UseNpgsql("Host=localhost;Database=PatikaCodeFirstDb2;Username=postgres;Password=yourpassword");
   ```

3. Apply migrations and update the database:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

### Usage

- Access the Swagger UI at `https://localhost:7048/swagger` to explore the API endpoints.

## Technologies Used 🛠️

- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- Swagger

---

Happy coding! 😊
