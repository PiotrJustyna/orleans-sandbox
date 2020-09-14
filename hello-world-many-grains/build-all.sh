#!/bin/bash
dotnet restore server/server.fsproj &&
dotnet build --no-restore server/server.fsproj &&
dotnet restore client/client.fsproj &&
dotnet build --no-restore client/client.fsproj