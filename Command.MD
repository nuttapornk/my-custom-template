## install new template
```
dotnet new --install .
```
or
```
dotnet new --install . --force
```

## use
```
dotnet new ca-webapi -o {output folder}
```

```
dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models

```