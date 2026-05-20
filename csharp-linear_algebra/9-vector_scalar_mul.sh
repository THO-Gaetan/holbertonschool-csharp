#!/usr/bin/env bash

dotnet new console -n "9-vector_scalar_mul"
cd 9-vector_scalar_mul
dotnet build
mv Program.cs 9-vector_scalar_mul.cs
dotnet run
