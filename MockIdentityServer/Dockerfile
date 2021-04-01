FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MockIdentityServer/MockIdentityServer.csproj", "MockIdentityServer/"]
RUN dotnet restore "MockIdentityServer/MockIdentityServer.csproj"
COPY . .
WORKDIR "/src/MockIdentityServer"
RUN dotnet build "MockIdentityServer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MockIdentityServer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MockIdentityServer.dll"]