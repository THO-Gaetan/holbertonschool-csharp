#!/usr/bin/env bash

dotnet new console -n "6-divisible_by_2"
cd 6-divisible_by_2
dotnet build
mv Program.cs 6-divisible_by_2.cs
dotnet run
