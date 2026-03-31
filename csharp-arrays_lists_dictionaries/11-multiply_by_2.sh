#!/usr/bin/env bash

dotnet new console -n "11-multiply_by_2"
cd 11-multiply_by_2
dotnet build
mv Program.cs 11-multiply_by_2.cs
dotnet run
