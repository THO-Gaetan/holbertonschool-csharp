#!/usr/bin/env bash

dotnet new console -n "14-matrix_addition"
cd 14-matrix_addition
dotnet build
mv Program.cs 14-matrix_addition.cs
dotnet run
