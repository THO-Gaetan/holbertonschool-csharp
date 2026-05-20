#!/usr/bin/env bash

dotnet new console -n "33-inverse_2D"
cd 33-inverse_2D
dotnet build
mv Program.cs 33-inverse_2D.cs
dotnet run
