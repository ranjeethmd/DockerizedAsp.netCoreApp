# I like this simple application everything is built outside the box. Docker needs to worry about just executiong it. Easier to debug build errors

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

LABEL org.opencontainers.image.title="Hello Docker with Asp.net core and Docker" \
      org.opencontainers.image.description="Dockerized Asp.net core 3.1 app with Angular" \
      org.opencontainers.image.authors="Ranjeeth Malachira Devaiah"

# Remove non root user

RUN useradd -ms /bin/bash app_user

WORKDIR /app

COPY bin/Release/netcoreapp3.1/publish/ ./

#Update the environment variables
ENV ASPNETCORE_URLS=http://+:8080

#Add read permission for the user
RUN chown -R app_user /app

#Add the read permission on the folder.
RUN chmod 755 /app

USER app_user

ENTRYPOINT ["dotnet", "DockerizedApp.dll"]