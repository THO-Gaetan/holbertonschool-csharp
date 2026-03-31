#!/usr/bin/env bash

dotnet new console -n "5-max_integer"
cd 5-max_integer
dotnet build
mv Program.cs 5-max_integer.cs
dotnet run
