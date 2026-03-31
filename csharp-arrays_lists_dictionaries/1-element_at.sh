#!/usr/bin/env bash

dotnet new console -n "1-element_at"
cd 1-element_at
dotnet build
mv Program.cs 1-element_at.cs
dotnet run
