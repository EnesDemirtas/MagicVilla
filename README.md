
# MagicVilla

MagicVilla is a robust ASP.NET Core web application for managing villa rentals. It offers a fully-featured API with user authentication, including JWT-based access and refresh tokens, role-based authorization, pagination, filtering, and caching mechanisms. The application also provides a client-side web interface with functionalities for managing villas and villa numbers.


## Tech Stack

**Client:** ASP.NET Core MVC with Razor Pages, Bootstrap

**Server:** ASP.NET Core MVC, .NET 7, EF Core, PostgreSQL, ASP.NET Core Identity


## Features

### General Features

- User Authentication & Authorization: Integrated with **ASP.NET Core Identity** and **JWT Tokens** for secure login, registration, and authorization, including refresh token support.
- API Versioning: Dynamically versioned API for smooth upgrades and backward compatibility.
- Role-based Access Control: User roles implemented on the web UI to allow role-based access for admins and users.
- Filtering, Pagination, and Caching: Advanced query mechanisms with support for pagination, filtering, and caching to optimize performance.
- CRUD Operations: Full Create, Read, Update, Delete functionality for managing villas and villa numbers.
- File Upload: Ability to upload images and manage them for each villa.
## Project Structure

- API: Provides secure, versioned endpoints for all villa-related operations.
- Web Client: A dynamic frontend web application built using **ASP.NET Core MVC** that interacts with the API for villa management.
- Services: Contains shared services, including token providers, user management, villa, and villa number services.
## Usage

### 1. Clone the Repository

First, clone the project from GitHub to your local machine:

```bash
git clone https://github.com/EnesDemirtas/MagicVilla.git
cd MagicVilla
```

### 2. Install Dependencies

Ensure that you have all necessary dependencies installed. If you're using Visual Studio or Visual Studio Code, these dependencies will be managed automatically.

```bash
dotnet restore
```

### 3. Database Setup

The project uses **PostgreSQL** for the database, and migrations have been configured using **Entity Framework Core**.

You will need to configure the connection string in `appsettings.json` file:

```json
"ConnectionStrings": {
    "DefaultSQLConnection": "User ID=postgres;Password=123321;Server=localhost;Port=5432;Database=MagicVillaAPI;Integrated Security=true;Pooling=true;"
}
```

Run the following commands to apply migrations and create the database:

```bash
dotnet ef database update
```

### 6. Run the Application

To run the application, use the following command in the project root directory:

```bash
dotnet run
```
