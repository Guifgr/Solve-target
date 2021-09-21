FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Cinco-Inverter/Cinco-Inverter.csproj", "Cinco-Inverter/"]
RUN dotnet restore "Cinco-Inverter/Cinco-Inverter.csproj"
COPY . .
WORKDIR "/src/Cinco-Inverter"
RUN dotnet build "Cinco-Inverter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cinco-Inverter.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cinco-Inverter.dll"]
