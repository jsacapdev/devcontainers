# Dev Containers 

Dev Container configuration for a dotnet application. Spins up a container for development purposes and supporting containers (in this case a SQL database).

Uses a base image build and then layers in some additional dependencies (at the time of writing install .NET 8 preview).

The main work using the containers is for various Identity use cases.

To attach and run commands on the shell in the container (cd `/workspaces`):

`docker exec -it netdevcontainer /bin/bash`

`alias ls='ls -alF'`

Connect to SQL in container using [Sql Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) and server name `127.0.0.1,1433`.

To generate and apply migrations:

`dotnet ef migrations add InitialSchema`
`dotnet ef database update --connection "Server=127.0.0.1,1433;Database=IdentityDB;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True"`

To access the identitiy endpoints:

`https://localhost:5001/swagger`
