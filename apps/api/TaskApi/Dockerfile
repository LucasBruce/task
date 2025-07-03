# Estágio de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /TaskApi

# Copiar os arquivos de projeto e restaurar dependências
COPY TaskApi.csproj .
RUN dotnet restore "TaskApi.csproj"

# Copiar todo o código e construir
COPY . .

RUN dotnet build "TaskApi.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "TaskApi.csproj" -c Release -o /app/publish

# Estágio final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Criar diretório para o certificado HTTPS e gerar o certificado de desenvolvimento HTTPS
RUN mkdir -p /https \
    && dotnet dev-certs https --clean \
    && dotnet dev-certs https -ep /https/aspnetapp.pfx -p Your_password123 \
    && dotnet dev-certs https --trust || true

# Definir a porta exposta (ajuste conforme sua aplicação)
EXPOSE 80
EXPOSE 443

# Mapear o certificado para o container
ENV ASPNETCORE_Kestrel__Certificates__Default__Password=Your_password123
ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx

# Comando de entrada
ENTRYPOINT ["dotnet", "TaskApi.dll"]