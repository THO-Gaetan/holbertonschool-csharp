#!/usr/bin/env bash

dotnet new console -n "3-print_alphabt"
cd 3-print_alphabt
dotnet build
mv Program.cs 3-print_alphabt.cs
dotnet run
