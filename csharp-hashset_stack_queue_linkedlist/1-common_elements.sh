#!/usr/bin/env bash

dotnet new console -n "1-common_elements"
cd 1-common_elements
dotnet build
mv Program.cs 1-common_elements.cs
dotnet run
