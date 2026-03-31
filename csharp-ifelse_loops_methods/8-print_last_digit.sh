#!/usr/bin/env bash

dotnet new console -n "8-print_last_digit"
cd 8-print_last_digit
dotnet build
mv Program.cs 8-print_last_digit.cs
dotnet run
