
# Autenticação com Identiy 

Projeto em Console Aplication criado para estudo de aplicação do Entity Framework Core.
- .Net 8
- Entity Framework 8.0
- Sql Server
- User Secrets


## Rodando localmente

1. Clone o projeto

```bash
  git clone https://github.com/WilliamAbelo/WebApplicationIdentity.git
```
2. Rodando a aplicação pelo prompt
    - ***certifique-se de estar na pasta do projeto***
    - Restaures os pacotes Nuget [^1]
        ```bash
        dotnet restore
        ```
    - Rodando as Migrations [^2]
        ```bash
        dotnet ef migrations add InitialCreate
        ```
        ```bash
        dotnet ef database update
        ```
    - Build o projeto [^3]
        ```bash
        dotnet build
        ```
    - Rode o projeto [^4]
        ```bash
        dotnet run --project WebApplicationIdentity
        ```
   [^1]: [Dotnet Restore](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore)
   
   [^2]: [Dotnet Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

   [^3]: [Dotnet Build](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-build)
    
   [^4]: [Dotnet Run](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run)
## Funcionalidades

- Register, Login, Refresh, Confirm Email, Resend Confirmation Email, Forgot Password, Reset Password.


## Autores

- [@WilliamAbelo](https://github.com/WilliamAbelo)

