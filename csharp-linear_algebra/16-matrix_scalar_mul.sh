#!/usr/bin/env bash

dotnet new console -n "16-matrix_scalar_mul"
cd 16-matrix_scalar_mul
dotnet build
mv Program.cs 16-matrix_scalar_mul.cs
dotnet run
