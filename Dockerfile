# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["HealthInsuranceWeb.csproj", "./"]
RUN dotnet restore "HealthInsuranceWeb.csproj"

COPY . .
RUN dotnet publish "HealthInsuranceWeb.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "HealthInsuranceWeb.dll"]