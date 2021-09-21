FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Quatro-FaturamentoEstado/Quatro-FaturamentoEstado.csproj", "Quatro-FaturamentoEstado/"]
RUN dotnet restore "Quatro-FaturamentoEstado/Quatro-FaturamentoEstado.csproj"
COPY . .
WORKDIR "/src/Quatro-FaturamentoEstado"
RUN dotnet build "Quatro-FaturamentoEstado.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quatro-FaturamentoEstado.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Quatro-FaturamentoEstado.dll"]
