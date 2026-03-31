#!/usr/bin/env bash

dotnet new console -n "14-rectangular_array"
cd 14-rectangular_array
dotnet build
mv Program.cs 14-rectangular_array.cs
dotnet run
