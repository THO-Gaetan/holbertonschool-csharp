#!/usr/bin/env bash

dotnet new console -n "3-modified_behavior"
cd 3-modified_behavior
dotnet build
mv Program.cs 3-modified_behavior.cs
dotnet run
