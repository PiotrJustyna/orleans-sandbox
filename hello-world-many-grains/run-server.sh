#!/bin/bash
dotnet restore server/server.fsproj &&
dotnet build --no-restore server/server.fsproj &&
dotnet run --project server/server.fsproj --no-build