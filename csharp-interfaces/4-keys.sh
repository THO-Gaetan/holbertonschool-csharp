#!/usr/bin/env bash

dotnet new console -n "0-is"
cd 0-is
dotnet build
mv Program.cs 0-is.cs
dotnet run
