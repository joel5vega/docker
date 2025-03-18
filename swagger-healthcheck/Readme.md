# Swagger test
## Build the image
```
docker build -t healthcheck .
```
## Run the container
```
docker run -d -p 8080:8080 --name healthcheck healthcheck
```

## Test 
http://localhost:8080/swagger
http://localhost:8080/Home
http://localhost:8080/health