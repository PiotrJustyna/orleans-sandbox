#!/bin/bash
dotnet restore playerwatcher/playerwatcher.csproj &&
dotnet build --no-restore playerwatcher/playerwatcher.csproj &&
dotnet run --project playerwatcher/playerwatcher.csproj --no-build