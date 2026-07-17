#!/usr/bin/env bash

dotnet new console -n "1-damage_delegation"
cd 1-damage_delegation
dotnet build
mv Program.cs 1-damage_delegation.cs
dotnet run
