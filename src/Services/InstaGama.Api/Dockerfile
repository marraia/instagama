#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Services/InstaGama.Api/InstaGama.Api.csproj", "src/Services/InstaGama.Api/"]
RUN dotnet restore "src/Services/InstaGama.Api/InstaGama.Api.csproj"
COPY . .
WORKDIR "/src/src/Services/InstaGama.Api"
RUN dotnet build "InstaGama.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InstaGama.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InstaGama.Api.dll"]