#!/usr/bin/env bash

dotnet new console -n "0-universal_health"
cd 0-universal_health
dotnet build
mv Program.cs 0-universal_health.cs
dotnet run
