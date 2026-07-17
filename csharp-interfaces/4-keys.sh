#!/usr/bin/env bash

dotnet new console -n "4-keys"
cd 4-keys
dotnet build
mv Program.cs 4-keys.cs
dotnet run
