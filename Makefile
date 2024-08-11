DOCKER_IMAGE = mcr.microsoft.com/dotnet/sdk:8.0
CONTAINER_NAME = csharp-desafio-reserva
PROJECT_DIR = ./

build:
	docker run --rm -v $(PWD)/$(PROJECT_DIR):/app -w /app $(DOCKER_IMAGE) dotnet build

run:
	docker run --rm -it --name $(CONTAINER_NAME) -v $(PWD)/$(PROJECT_DIR):/app -w /app $(DOCKER_IMAGE) dotnet run
