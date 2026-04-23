#!/usr/bin/env bash

dotnet new console -n "1-divide_print"
cd 1-divide_print
dotnet build
mv Program.cs 1-divide_print.cs
dotnet run
