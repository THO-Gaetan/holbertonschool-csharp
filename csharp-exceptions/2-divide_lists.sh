#!/usr/bin/env bash

dotnet new console -n "2-divide_lists"
cd 2-divide_lists
dotnet build
mv Program.cs 2-divide_lists.cs
dotnet run
