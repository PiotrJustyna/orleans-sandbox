#!/bin/bash
dotnet restore client/client.fsproj &&
dotnet build --no-restore client/client.fsproj &&
dotnet run --project client/client.fsproj --no-build