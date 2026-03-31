#!/usr/bin/env bash

dotnet new console -n "2-print_alphabet"
cd 2-print_alphabet
dotnet build
mv Program.cs 2-print_alphabet.cs
dotnet run
