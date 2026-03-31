#!/usr/bin/env bash

dotnet new console -n "12-print_sorted_dictionary"
cd 12-print_sorted_dictionary
dotnet build
mv Program.cs 12-print_sorted_dictionary.cs
dotnet run
