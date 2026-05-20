#!/usr/bin/env bash

dotnet new console -n "18-matrix_matrix_mul"
cd 18-matrix_matrix_mul
dotnet build
mv Program.cs 18-matrix_matrix_mul.cs
dotnet run
