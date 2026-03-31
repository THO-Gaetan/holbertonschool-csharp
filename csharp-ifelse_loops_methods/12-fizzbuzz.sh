#!/usr/bin/env bash

dotnet new console -n "12-fizzbuzz"
cd 12-fizzbuzz
dotnet build
mv Program.cs 12-fizzbuzz.cs
dotnet run
