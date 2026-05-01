#!/usr/bin/env bash

dotnet new console -n "0-enemy"
cd 0-enemy
dotnet build
mv Program.cs 0-enemy.cs
dotnet run
