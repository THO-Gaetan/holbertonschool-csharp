#!/usr/bin/env bash

dotnet new console -n "4-enemy"
cd 4-enemy
dotnet build
mv Program.cs 4-enemy.cs
dotnet run
