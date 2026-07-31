#!/usr/bin/env bash

dotnet new console -n "3-peek"
cd 3-peek
dotnet build
mv Program.cs 3-peek.cs
dotnet run
