#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Server/EddysItHomepage.Server.csproj", "Server/"]
COPY ["Client/EddysItHomepage.Client.csproj", "Client/"]
COPY ["Shared/EddysItHomepage.Shared.csproj", "Shared/"]
RUN dotnet restore "Server/EddysItHomepage.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "EddysItHomepage.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EddysItHomepage.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EddysItHomepage.Server.dll"]