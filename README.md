# DockerizedAsp.netCoreApp
 Angular and Asp.net core application

## local run Command
docker build -t first_docker_image .

docker run -d  -p 5000:80 --name first_docker_container first_docker_image