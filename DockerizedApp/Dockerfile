FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

# I like this simple application everything is built outside the box. Docker needs to worry about just executiong it. Easier to debug build errors
LABEL org.opencontainers.image.title="Hello Docker with Asp.net core and Docker" \
      org.opencontainers.image.description="Dockerized Asp.net core 3.1 app with Angular" \
      org.opencontainers.image.authors="Ranjeeth Malachira Devaiah"

RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_10.x | bash \
    && apt-get install nodejs -yq

WORKDIR /app


COPY *.csproj ./
RUN dotnet restore


COPY . ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

# Remove non root user

RUN useradd -ms /bin/bash app_user

#Update the environment variables
ENV ASPNETCORE_URLS=http://+:8080

#Add read permission for the user
RUN chown -R app_user /app

#Add the read permission on the folder.
RUN chmod 755 /app

USER app_user

ENTRYPOINT ["dotnet", "DockerizedApp.dll"]