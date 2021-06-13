# What is this
 This repository contains open source Asp.NET project with Angular framework. This is a basic project to demonstrate the capability of the latest .NET plaform to run on linux aswell as windows. This repository also implements DockerFile to demonstrate that .NET applications can seemlessly run on Docker container. This repository progressively demonstrates the use of github actions to build test and containarize the application as well as use the images in kubernetes. 

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
