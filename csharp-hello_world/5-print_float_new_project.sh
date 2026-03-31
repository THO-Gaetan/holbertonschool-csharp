#!/usr/bin/env bash

dotnet new console -n "5-print_float"
cd 5-print_float
dotnet build
mv Program.cs 5-print_float.cs
dotnet run
