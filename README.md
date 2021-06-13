# DockerizedAsp.netCoreApp
 Angular and Asp.net core application

## local run Command
docker build -t first_docker_image .

docker run -d  -p 5000:80 --name first_docker_container first_docker_image


## docker hub push pull run Command
docker build -t ranjeethmd/open-image:first-docker-image .

docker push ranjeethmd/open-image:first-docker-image

docker run -d  -p 5000:80 --name first_docker_container ranjeethmd/open-image:first-docker-image

## docker compose example
docker-compose up -d

[DockerHub](https://hub.docker.com/r/ranjeethmd/open-image/tags?page=1&ordering=last_updated)
