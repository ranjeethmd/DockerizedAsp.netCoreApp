# I like this simple application everything is built outside the box. Docker needs to worry about just executiong it. Easier to debug build errors

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

LABEL org.opencontainers.image.title="Hello Docker with Asp.net core and Docker" \
      org.opencontainers.image.description="Dockerized Asp.net core 3.1 app with Angular" \
      org.opencontainers.image.authors="Ranjeeth Malachira Devaiah"


WORKDIR /app

COPY bin/Release/netcoreapp3.1/publish/ ./

ENTRYPOINT ["dotnet", "DockerizedApp.dll"]