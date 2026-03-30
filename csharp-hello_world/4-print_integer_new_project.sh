#!/usr/bin/env bash

dotnet new console -n "4-print_integer"
cd 4-print_integer
dotnet build
mv Program.cs 4-print_integer.cs
dotnet run
