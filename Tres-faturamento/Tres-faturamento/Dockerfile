FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Tres-faturamento/Tres-faturamento.csproj", "Tres-faturamento/"]
RUN dotnet restore "Tres-faturamento/Tres-faturamento.csproj"
COPY . .
WORKDIR "/src/Tres-faturamento"
RUN dotnet build "Tres-faturamento.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tres-faturamento.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tres-faturamento.dll"]
