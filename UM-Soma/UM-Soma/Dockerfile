FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UM-Soma/UM-Soma.csproj", "UM-Soma/"]
RUN dotnet restore "UM-Soma/UM-Soma.csproj"
COPY . .
WORKDIR "/src/UM-Soma"
RUN dotnet build "UM-Soma.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UM-Soma.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UM-Soma.dll"]
