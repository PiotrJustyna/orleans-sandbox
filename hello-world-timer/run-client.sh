#!/bin/bash
dotnet restore client/client.csproj &&
dotnet build --no-restore client/client.csproj &&
dotnet run --project client/client.csproj --no-build