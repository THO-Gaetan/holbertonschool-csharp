#!/usr/bin/env bash

dotnet new console -n "15-square_matrix"
cd 15-square_matrix
dotnet build
mv Program.cs 15-square_matrix.cs
dotnet run
