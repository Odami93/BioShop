# Establecer la imagen base para la compilación
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Establecer el directorio de trabajo en la carpeta /app
WORKDIR /app

# Copiar el archivo de proyecto y restaurar las dependencias
COPY ["BioShop/BioShop.csproj", "BioShop/"]
RUN dotnet restore "BioShop/BioShop.csproj"

# Copiar todos los archivos y construir la aplicación
COPY . . 
WORKDIR /app/BioShop
RUN dotnet build "BioShop.csproj" -c Release -o /app/build

# Publicar la aplicación
FROM build AS publish
RUN dotnet publish "BioShop.csproj" -c Release -o /app/publish

# Generar la imagen final
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BioShop.dll"]
