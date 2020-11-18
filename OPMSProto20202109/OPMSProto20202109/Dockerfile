#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OPMSProto20202109/OPMSProto20202109.csproj", "OPMSProto20202109/"]
RUN dotnet restore "OPMSProto20202109/OPMSProto20202109.csproj"
COPY . .
WORKDIR "/src/OPMSProto20202109"
RUN dotnet build "OPMSProto20202109.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OPMSProto20202109.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OPMSProto20202109.dll"]