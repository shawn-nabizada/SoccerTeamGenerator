# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["SoccerApp.csproj", "./"]
RUN dotnet restore "SoccerApp.csproj"

# Copy the rest of the source code
COPY . .
RUN dotnet publish "SoccerApp.csproj" -c Release -o /app/publish

# Stage 2: Run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SoccerApp.dll"]