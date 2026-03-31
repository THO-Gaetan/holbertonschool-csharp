#!/usr/bin/env bash

dotnet new console -n "8-print_variables"
cd 8-print_variables
dotnet build
mv Program.cs 8-print_variables.cs
dotnet run
