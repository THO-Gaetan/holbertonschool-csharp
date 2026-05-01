#!/usr/bin/env bash

dotnet new console -n "3-enemy"
cd 3-enemy
dotnet build
mv Program.cs 3-enemy.cs
dotnet run
