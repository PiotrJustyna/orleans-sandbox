#!/bin/bash
dotnet restore loadgenerator/loadgenerator.csproj &&
dotnet build --no-restore loadgenerator/loadgenerator.csproj