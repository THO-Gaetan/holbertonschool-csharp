#!/usr/bin/env bash

dotnet new console -n "9-print_specifiers"
cd 9-print_specifiers
dotnet build
mv Program.cs 9-print_specifiers.cs
dotnet run
