#!/usr/bin/env bash

dotnet new console -n "3-print_alphabet"
cd 3-print_alphabet
dotnet build
mv Program.cs 3-print_alphabet.cs
dotnet run
