# ClasePOO


Aplicación de ejemplo en ASP.NET Core MVC que implementa un CRUD básico para la entidad **Cliente** usando Entity Framework Core con SQL Server.

## Programación Orientada a Objetos (POO)

La clase `Cliente` representa a un cliente con propiedades y se usa para crear objetos que se almacenan en la base de datos.

```csharp
public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Email { get; set; }
}
```

En POO, las clases son plantillas que encapsulan datos y comportamiento. A partir de la clase `Cliente` se crean objetos concretos que se manejan desde el controlador para realizar las operaciones CRUD.

## Ejecución

1. Instalar el SDK de .NET 8 y tener acceso a una instancia de SQL Server.
2. Configurar la cadena de conexión en `appsettings.json` si es necesario.
3. Restaurar dependencias y compilar:

   ```bash
   dotnet restore
   dotnet build
   ```

4. Ejecutar la aplicación:
   ```bash
   dotnet run
   ```
5. Abrir el navegador en `https://localhost:5001` y navegar a `/Clientes`.


## Estructura

- `Models/Cliente.cs`: clase de dominio del cliente.
- `Data/AppDbContext.cs`: contexto de Entity Framework.
- `Controllers/ClientesController.cs`: controlador MVC con acciones CRUD.
- `Views/Clientes/`: vistas Razor para las operaciones CRUD.
- `Program.cs`: configuración de servicios y pipeline de la aplicación.
