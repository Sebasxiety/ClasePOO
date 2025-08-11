# ClasePOO

Aplicación de ejemplo en ASP.NET Core MVC que implementa un CRUD básico para la entidad **Cliente** usando Entity Framework Core con una base de datos en memoria.

## Ejecución

1. Instalar el SDK de .NET 8.
2. Restaurar dependencias y compilar:
   ```bash
   dotnet restore
   dotnet build
   ```
3. Ejecutar la aplicación:
   ```bash
   dotnet run
   ```
4. Abrir el navegador en `https://localhost:5001` y navegar a `/Clientes`.

## Estructura

- `Models/Cliente.cs`: clase de dominio del cliente.
- `Data/AppDbContext.cs`: contexto de Entity Framework.
- `Controllers/ClientesController.cs`: controlador MVC con acciones CRUD.
- `Views/Clientes/`: vistas Razor para las operaciones CRUD.
- `Program.cs`: configuración de servicios y pipeline de la aplicación.
