#!/usr/bin/env bash

dotnet new console -n "3-decorations"
cd 3-decorations
dotnet build
mv Program.cs 3-decorations.cs
dotnet run
