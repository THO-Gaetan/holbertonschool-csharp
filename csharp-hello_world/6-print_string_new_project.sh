#!/usr/bin/env bash

dotnet new console -n "6-print_string"
cd 6-print_string
dotnet build
mv Program.cs 6-print_string.cs
dotnet run
