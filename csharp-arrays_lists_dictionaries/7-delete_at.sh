#!/usr/bin/env bash

dotnet new console -n "7-delete_at"
cd 7-delete_at
dotnet build
mv Program.cs 7-delete_at.cs
dotnet run
