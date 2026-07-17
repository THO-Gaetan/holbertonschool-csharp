#!/usr/bin/env bash

dotnet new console -n "6-generic_iteration"
cd 6-generic_iteration
dotnet build
mv Program.cs 6-generic_iteration.cs
dotnet run
