#!/usr/bin/env bash

dotnet new console -n "6-print_comb2"
cd 6-print_comb2
dotnet build
mv Program.cs 6-print_comb2.cs
dotnet run
