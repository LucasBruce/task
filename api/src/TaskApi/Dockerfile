# Estágio de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /TaskApi

# Copiar os arquivos de projeto e restaurar dependências
COPY TaskApi.csproj .
RUN dotnet restore "TaskApi.csproj"

# Copiar todo o código e construir
COPY . .
RUN dotnet build "TaskApi.csproj" -c Release -o /app/build

# Estágio de publicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /TaskApi
COPY --from=build /TaskApi .
RUN dotnet publish "TaskApi.csproj" -c Release -o /app/publish

# Estágio final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Definir a porta exposta
EXPOSE 80
EXPOSE 443

# Configurar ambiente para escutar em todas as interfaces
ENV ASPNETCORE_URLS=http://+:80;https://+:443

# Comando de entrada
ENTRYPOINT ["dotnet", "TaskApi.dll"]