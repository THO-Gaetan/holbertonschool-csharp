#!/usr/bin/env bash

dotnet new console -n "5-enemy"
cd 5-enemy
dotnet build
mv Program.cs 5-enemy.cs
dotnet run
