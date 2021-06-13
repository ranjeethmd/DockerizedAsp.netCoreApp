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




- [x] create asp.net 5 application with angular
- [x] created automated workflow using git actions 
- [x] implemented matrix build and testing
- [x] implemented docker build and dockerhub push


> .NET Core is open source and runs on linux. .NET 5 unification of multiplatform .NET Core and legacy .NET 4.x framework into single multplaform framework.
