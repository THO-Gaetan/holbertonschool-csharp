#!/usr/bin/env bash

dotnet new console -n "28-determinant"
cd 28-determinant
dotnet build
mv Program.cs 28-determinant.cs
dotnet run
