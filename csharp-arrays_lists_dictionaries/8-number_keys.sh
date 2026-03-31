#!/usr/bin/env bash

dotnet new console -n "8-number_keys"
cd 8-number_keys
dotnet build
mv Program.cs 8-number_keys.cs
dotnet run
