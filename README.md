# DockerizedAsp.netCoreApp
 Angular and Asp.net core application on Docker

## Intialization 
git clone https://github.com/ranjeethmd/DockerizedAsp.netCoreApp.git -branch docker-with-build 

## local run Command
docker build -t first_docker_image .

docker run -d  -p 5000:80 --name first_docker_container first_docker_image


## docker hub push pull run Command
docker build -t ranjeethmd/open-image:first-docker-image .

docker image push ranjeethmd/open-image:first-docker-image

docker run -d  -p 5001:80 --name first-docker-container ranjeethmd/open-image:first-docker-image