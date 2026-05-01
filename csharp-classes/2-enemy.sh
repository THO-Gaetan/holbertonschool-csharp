#!/usr/bin/env bash

dotnet new console -n "2-enemy"
cd 2-enemy
dotnet build
mv Program.cs 2-enemy.cs
dotnet run
