# I like docker to build everything.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

LABEL org.opencontainers.image.title="Hello Docker with Asp.net core and Docker" \
      org.opencontainers.image.description="Dockerized Asp.net core 3.1 app with Angular" \
      org.opencontainers.image.authors="Ranjeeth Malachira Devaiah"


FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app


COPY *.csproj ./
RUN dotnet restore


COPY . ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DockerizedApp.dll"]