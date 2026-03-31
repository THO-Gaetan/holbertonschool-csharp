#!/usr/bin/env bash

dotnet new console -n "3-print_array_reverse"
cd 3-print_array_reverse
dotnet build
mv Program.cs 3-print_array_reverse.cs
dotnet run
