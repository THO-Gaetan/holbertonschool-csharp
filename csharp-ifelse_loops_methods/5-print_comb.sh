#!/usr/bin/env bash

dotnet new console -n "5-print_comb"
cd 5-print_comb
dotnet build
mv Program.cs 5-print_comb.cs
dotnet run
