FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["PersonalNutritionist.TelegramBot/PersonalNutritionist.TelegramBot.csproj", "PersonalNutritionist.TelegramBot/"]
RUN dotnet restore "PersonalNutritionist.TelegramBot/PersonalNutritionist.TelegramBot.csproj"
COPY . .
WORKDIR "/src/PersonalNutritionist.TelegramBot"
RUN dotnet build "PersonalNutritionist.TelegramBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonalNutritionist.TelegramBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonalNutritionist.TelegramBot.dll"]