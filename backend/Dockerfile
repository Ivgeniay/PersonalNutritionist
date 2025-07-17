FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["PersonalNutritionist.WebApi/PersonalNutritionist.WebApi.csproj", "PersonalNutritionist.WebApi/"]
COPY ["PersonalNutritionist.Application/PersonalNutritionist.Application.csproj", "PersonalNutritionist.Application/"]
COPY ["PersonalNutritionist.Domain/PersonalNutritionist.Domain.csproj", "PersonalNutritionist.Domain/"]
COPY ["PersonalNutritionist.Infrastructure/PersonalNutritionist.Infrastructure.csproj", "PersonalNutritionist.Infrastructure/"]
COPY ["PersonalNutritionist.Persistence/PersonalNutritionist.Persistence.csproj", "PersonalNutritionist.Persistence/"]

RUN dotnet restore "PersonalNutritionist.WebApi/PersonalNutritionist.WebApi.csproj"
COPY . .
WORKDIR "/src/PersonalNutritionist.WebApi"
RUN dotnet build "PersonalNutritionist.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonalNutritionist.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonalNutritionist.WebApi.dll"]