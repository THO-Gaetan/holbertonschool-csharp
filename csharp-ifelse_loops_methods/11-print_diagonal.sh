#!/usr/bin/env bash

dotnet new console -n "11-print_diagonal"
cd 11-print_diagonal
dotnet build
mv Program.cs 11-print_diagonal.cs
dotnet run
