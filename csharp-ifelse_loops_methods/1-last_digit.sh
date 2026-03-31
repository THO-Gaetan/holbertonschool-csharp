#!/usr/bin/env bash

dotnet new console -n "1-last_digit"
cd 1-last_digit
dotnet build
mv Program.cs 1-last_digit.cs
dotnet run
