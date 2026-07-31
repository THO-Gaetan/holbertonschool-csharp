#!/usr/bin/env bash

dotnet new console -n "4-print"
cd 4-print
dotnet build
mv Program.cs 4-print.cs
dotnet run
