FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HomeCalanderBackend/HomeCalanderBackend.csproj", "HomeCalanderBackend/"]
RUN dotnet restore "HomeCalanderBackend/HomeCalanderBackend.csproj"
COPY . .
WORKDIR "/src/HomeCalanderBackend"
RUN dotnet build "HomeCalanderBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeCalanderBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeCalanderBackend.dll"]
