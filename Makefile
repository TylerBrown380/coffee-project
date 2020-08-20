# Project Variables
  PROJECT_NAME ?= CoffeeShop
  ORG_NAME ?= CoffeeShop
  REPO_NAME ?= CoffeeShop

 .PHONY: migrations db


 migrations:
 	cd ./CoffeeShop.Data && dotnet ef --startup-project ../CoffeeProject.Web migrations add $(mname) && cd ..

 db: 
 	cd ./CoffeeProject.Data && dotnet ef --startup-project ../CoffeeProject.Web database update && cd ..
