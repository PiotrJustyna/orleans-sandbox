#!/bin/bash
dotnet restore host/host.csproj &&
dotnet build --no-restore host/host.csproj &&
dotnet run --project host/host.csproj --no-build