#!/usr/bin/env bash

dotnet new console -n "4-check_yourself"
cd 4-check_yourself
dotnet build
mv Program.cs 4-check_yourself.cs
dotnet run
