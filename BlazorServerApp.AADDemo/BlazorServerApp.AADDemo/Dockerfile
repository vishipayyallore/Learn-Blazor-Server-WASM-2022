#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlazorServerApp.AADDemo/BlazorServerApp.AADDemo.csproj", "BlazorServerApp.AADDemo/"]
RUN dotnet restore "BlazorServerApp.AADDemo/BlazorServerApp.AADDemo.csproj"
COPY . .
WORKDIR "/src/BlazorServerApp.AADDemo"
RUN dotnet build "BlazorServerApp.AADDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorServerApp.AADDemo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorServerApp.AADDemo.dll"]