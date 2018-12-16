# readit
Accompanying code for the short "Build your Features using ASP.NET Core MVC" email course available via jonhilton.net

## Some notes on this example code

It uses EF Core as its ORM for retrieving data from an SQL database.

These are the relevant lines in `startup.cs`

```csharp
var connection = "Server=(localdb)\\mssqllocaldb;Database=ReadIt;Trusted_Connection=True;ConnectRetryCount=0";
services.AddDbContext<ReadItContext>(options => options.UseSqlServer(connection));
```

This is using MS LocalDB for ease (for demo purposes) but feel free to point this to any database you wish to use.

Once you have a database connection which works, you'll want to run the migrations. You can do that using the Package Manager console...

``` ps
Update-Database
```

You'll also need to manually add at least one entry to the `Posts` table (the migration will create the table but not populate it with any data).

## Dependency Injection

The example also employs Microsoft's built-in dependency injection in two places.

Once in `PostService.cs` to bring in the EF Core database context.

And again in `PostController.cs` to bring in a reference to the `PostService` instance.

`PostService` is configured as a dependency in `startup.cs`.

``` csharp
services.AddScoped<PostService>();
```
