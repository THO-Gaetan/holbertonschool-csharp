#!/usr/bin/env bash

dotnet new console -n "20-matrix_rotate_2D"
cd 20-matrix_rotate_2D
dotnet build
mv Program.cs 20-matrix_rotate_2D.cs
dotnet run
