FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["StockManagementService/StockManagementService.csproj", "StockManagementService/"]
RUN dotnet restore "StockManagementService/StockManagementService.csproj"
COPY . .
WORKDIR "/src/StockManagementService"
RUN dotnet build "StockManagementService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StockManagementService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StockManagementService.dll"]