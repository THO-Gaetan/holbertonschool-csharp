#!/usr/bin/env bash

dotnet new console -n "0-safe_list_print"
cd 0-safe_list_print
dotnet build
mv Program.cs 0-safe_list_print.cs
dotnet run
