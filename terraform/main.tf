terraform {
    required_providers {
        docker = {
          source = "kreuzwerker/docker"
          version = "~> 3.0.1"
        }
    }
}

provider "docker" {}

resource "docker_network" "private_network" {
  name = "dev"
   ipam_config {
    subnet  = "10.0.1.0/24"
    gateway = "10.0.1.254"
  }
}

resource "docker_image" "postgres" {
  name = "postgres:11.22-bullseye"
  keep_locally = true
}

resource "docker_container" "postgres" {
  name = "database"
  image = docker_image.postgres.image_id
  networks_advanced {
    name = "dev"
  }
  ports {
    internal = 5432
    external = 5432
  }
  env = [
     "POSTGRES_PASSWORD=password123",
     "POSTGRES_USER=root",
     "POSTGRES_DB=TimestampDB",
     "PGDATA=/var/lib/postgresql/data"
  ]
  hostname = "postgres"
}

resource "docker_image" "devops" {
  name = "botimpact/devops:latest"
}

resource "docker_container" "devops" {
  image = docker_image.devops.image_id
  name = "webservice"
  networks_advanced {
    name = "dev"
    ipv4_address ="10.0.1.1"
  }
  ports {
    internal = 80
    external = 8080
  }
  env = [
    "ConnectionStrings__Default=User ID=root;Password=password123;Server=database;Port=5432;Database=TimestampDB;IntegratedSecurity=true;",
    "ASPNETCORE_URLS=http://+:80"
  ]
  restart = "on-failure"
}