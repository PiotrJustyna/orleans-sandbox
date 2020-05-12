#!/bin/bash
dotnet restore silo/silo.csproj &&
dotnet build --no-restore silo/silo.csproj &&
dotnet run --project silo/silo.csproj --no-build