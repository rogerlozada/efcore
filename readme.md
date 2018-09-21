
# comandos utilizados

dotnet new mvc  

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 2.2.0-preview2-35157

dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.1.0-preview1-final

dotnet restore    

dotnet run


# adicione no csproj

 <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.1.0-preview1-final" />
  </ItemGroup>

# comandos efcore

dotnet ef  migrations add CreateDatabase -> migration

dotnet ef database update -> update

dotnet ef migrations add LimitStrings -> adiciona novo migrations

# referências

http://anthonygiretti.com/2018/01/11/entity-framework-core-2-entity-type-configuration/

https://www.learnentityframeworkcore.com/walkthroughs/aspnetcore-application

