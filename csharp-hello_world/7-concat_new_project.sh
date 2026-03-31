#!/usr/bin/env bash

dotnet new console -n "7-concat"
cd 7-concat
dotnet build
mv Program.cs 7-concat.cs
dotnet run
