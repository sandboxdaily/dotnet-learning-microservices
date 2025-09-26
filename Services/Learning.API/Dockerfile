# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/Learning.API/Learning.API.csproj", "Services/Learning.API/"]
COPY ["Services/Learning.Application/Learning.Application.csproj", "Services/Learning.Application/"]
COPY ["BuildingBlocks/BuildingBlocks.csproj", "BuildingBlocks/"]
COPY ["Services/Learning.Domain/Learning.Domain.csproj", "Services/Learning.Domain/"]
COPY ["Services/Learning.Infrastructure/Learning.Infrastructure.csproj", "Services/Learning.Infrastructure/"]
RUN dotnet restore "./Services/Learning.API/Learning.API.csproj"
COPY . .
WORKDIR "/src/Services/Learning.API"
RUN dotnet build "./Learning.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Learning.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Learning.API.dll"]