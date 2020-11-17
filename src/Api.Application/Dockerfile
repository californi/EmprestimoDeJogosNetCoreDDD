#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Api.Application/application.csproj", "Api.Application/"]
COPY ["Api.CrossCutting/CrossCutting.csproj", "Api.CrossCutting/"]
COPY ["Api.Service/Service.csproj", "Api.Service/"]
COPY ["Api.Domain/Domain.csproj", "Api.Domain/"]
COPY ["Api.Data/Data.csproj", "Api.Data/"]
RUN dotnet restore "Api.Application/application.csproj"
COPY . .
WORKDIR "/src/Api.Application"
RUN dotnet build "application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "application.dll"]