#!/usr/bin/env bash

dotnet new console -n "25-matrix_transpose"
cd 25-matrix_transpose
dotnet build
mv Program.cs 25-matrix_transpose.cs
dotnet run
