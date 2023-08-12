FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Discourse.App/Discourse.App.csproj", "Discourse.App/"]
RUN dotnet restore "Discourse.App/Discourse.App.csproj"
COPY . .
WORKDIR "/src/Discourse.App"
RUN dotnet build "Discourse.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discourse.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discourse.App.dll"]
