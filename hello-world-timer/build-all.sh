#!/bin/bash
dotnet restore silo/silo.csproj &&
dotnet build --no-restore silo/silo.csproj &&
dotnet restore client/client.csproj &&
dotnet build --no-restore client/client.csproj