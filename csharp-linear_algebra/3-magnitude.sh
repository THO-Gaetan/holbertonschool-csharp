#!/usr/bin/env bash

dotnet new console -n "3-magnitude"
cd 3-magnitude
dotnet build
mv Program.cs 3-magnitude.cs
dotnet run
