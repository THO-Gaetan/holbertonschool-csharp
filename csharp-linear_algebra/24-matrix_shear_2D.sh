#!/usr/bin/env bash

dotnet new console -n "24-matrix_shear_2D"
cd 24-matrix_shear_2D
dotnet build
mv Program.cs 24-matrix_shear_2D.cs
dotnet run
