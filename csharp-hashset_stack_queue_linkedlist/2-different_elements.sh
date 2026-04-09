#!/usr/bin/env bash

dotnet new console -n "2-different_elements"
cd 2-different_elements
dotnet build
mv Program.cs 2-different_elements.cs
dotnet run
