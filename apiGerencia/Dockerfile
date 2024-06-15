# Use uma imagem base do .NET 8.0 para o ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Use a imagem SDK do .NET 8.0 para o build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["apiGerencia/apiGerencia.csproj", "apiGerencia/"]
RUN dotnet restore "apiGerencia/apiGerencia.csproj"
COPY . .
WORKDIR "/src/apiGerencia"
RUN dotnet build "apiGerencia.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Etapa de publicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "apiGerencia.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Etapa final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "apiGerencia.dll"]
