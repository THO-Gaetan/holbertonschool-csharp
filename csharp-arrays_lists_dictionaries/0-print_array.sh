#!/usr/bin/env bash

dotnet new console -n "0-print_array"
cd 0-print_array
dotnet build
mv Program.cs 0-print_array.cs
dotnet run
