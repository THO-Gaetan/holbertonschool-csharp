#!/usr/bin/env bash

dotnet new console -n "9-add"
cd 9-add
dotnet build
mv Program.cs 9-add.cs
dotnet run
