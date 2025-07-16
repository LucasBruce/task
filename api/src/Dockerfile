# Estágio de desenvolvimento
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS development
WORKDIR /app

# Copia apenas os arquivos de projeto para restaurar dependências
COPY TaskApi.Api/TaskApi.Api.csproj TaskApi.Api/
COPY TaskApi.Core/TaskApi.Core.csproj TaskApi.Core/
RUN dotnet restore TaskApi.Api/TaskApi.Api.csproj

# Copia o restante do código (mas será sobrescrito pelo volume em dev)
COPY TaskApi.Api/ TaskApi.Api/
COPY TaskApi.Core/ TaskApi.Core/

# Comando padrão para desenvolvimento com hot reload
CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:80"]

# Estágio de build para produção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY TaskApi.Api/TaskApi.Api.csproj TaskApi.Api/
COPY TaskApi.Core/TaskApi.Core.csproj TaskApi.Core/
RUN dotnet restore TaskApi.Api/TaskApi.Api.csproj
COPY TaskApi.Api/ TaskApi.Api/
COPY TaskApi.Core/ TaskApi.Core/
RUN dotnet build TaskApi.Api/TaskApi.Api.csproj -c Release -o /app/build

# Estágio de publicação
FROM build AS publish
WORKDIR /src
RUN dotnet publish TaskApi.Api/TaskApi.Api.csproj -c Release -o /app/publish

# Estágio final para produção
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_URLS=http://+:80;https://+:443
ENTRYPOINT ["dotnet", "TaskApi.Api.dll"]