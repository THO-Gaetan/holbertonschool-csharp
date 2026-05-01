#!/usr/bin/env bash

dotnet new console -n "1-enemy"
cd 1-enemy
dotnet build
mv Program.cs 1-enemy.cs
dotnet run
