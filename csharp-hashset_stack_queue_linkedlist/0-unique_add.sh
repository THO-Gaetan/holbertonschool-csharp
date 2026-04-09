#!/usr/bin/env bash

dotnet new console -n "0-unique_add"
cd 0-unique_add
dotnet build
mv Program.cs 0-unique_add.cs
dotnet run
