#!/usr/bin/env bash

dotnet new console -n "4-print_list"
cd 4-print_list
dotnet build
mv Program.cs 4-print_list.cs
dotnet run
