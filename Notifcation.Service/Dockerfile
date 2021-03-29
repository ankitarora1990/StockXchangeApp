FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["StockXchangeApp/Notifcation.Service/Notifcation.Service.csproj", "StockXchangeApp/Notifcation.Service/"]
RUN dotnet restore "StockXchangeApp/Notifcation.Service/Notifcation.Service.csproj"
COPY . .
WORKDIR "/src/StockXchangeApp/Notifcation.Service"
RUN dotnet build "Notifcation.Service.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Notifcation.Service.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Notifcation.Service.dll"]