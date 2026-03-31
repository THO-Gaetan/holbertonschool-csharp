#!/usr/bin/env bash

dotnet new console -n "7-islower"
cd 7-islower
dotnet build
mv Program.cs 7-islower.cs
dotnet run
