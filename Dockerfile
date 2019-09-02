FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
ARG src="Movies Versions/app/"
COPY ${src} .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet MoviesVersions.dll