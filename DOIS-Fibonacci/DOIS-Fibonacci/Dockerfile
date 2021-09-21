FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DOIS-Fibonacci/DOIS-Fibonacci.csproj", "DOIS-Fibonacci/"]
RUN dotnet restore "DOIS-Fibonacci/DOIS-Fibonacci.csproj"
COPY . .
WORKDIR "/src/DOIS-Fibonacci"
RUN dotnet build "DOIS-Fibonacci.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DOIS-Fibonacci.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DOIS-Fibonacci.dll"]
