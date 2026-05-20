#!/usr/bin/env bash

dotnet new console -n "6-vector_addition"
cd 6-vector_addition
dotnet build
mv Program.cs 6-vector_addition.cs
dotnet run
