#!/usr/bin/env bash

dotnet new console -n "4-inherit"
cd 4-inherit
dotnet build
mv Program.cs 4-inherit.cs
dotnet run
