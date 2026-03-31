#!/usr/bin/env bash

dotnet new console -n "4-print_hexa"
cd 4-print_hexa
dotnet build
mv Program.cs 4-print_hexa.cs
dotnet run
