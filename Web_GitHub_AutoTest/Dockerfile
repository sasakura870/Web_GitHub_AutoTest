#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Web_GitHub_AutoTest/Web_GitHub_AutoTest.csproj", "Web_GitHub_AutoTest/"]
RUN dotnet restore "Web_GitHub_AutoTest/Web_GitHub_AutoTest.csproj"
COPY . .
WORKDIR "/src/Web_GitHub_AutoTest"
RUN dotnet build "Web_GitHub_AutoTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web_GitHub_AutoTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web_GitHub_AutoTest.dll"]