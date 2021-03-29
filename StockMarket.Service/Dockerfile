FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["StockXchangeApp/StockMarket.Service/StockMarket.Service.csproj", "StockXchangeApp/StockMarket.Service/"]
RUN dotnet restore "StockXchangeApp/StockMarket.Service/StockMarket.Service.csproj"
COPY . .
WORKDIR "/src/StockXchangeApp/StockMarket.Service"
RUN dotnet build "StockMarket.Service.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StockMarket.Service.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StockMarket.Service.dll"]