FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR "/Movies Versions/app"
COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet MoviesVersions.dll