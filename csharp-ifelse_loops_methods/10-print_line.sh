#!/usr/bin/env bash

dotnet new console -n "10-print_line"
cd 10-print_line
dotnet build
mv Program.cs 10-print_line.cs
dotnet run
