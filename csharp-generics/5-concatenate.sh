#!/usr/bin/env bash

dotnet new console -n "5-concatenate"
cd 5-concatenate
dotnet build
mv Program.cs 5-concatenate.cs
dotnet run
