#!/usr/bin/env bash

dotnet new console -n "10-delete_key_value"
cd 10-delete_key_value
dotnet build
mv Program.cs 10-delete_key_value.cs
dotnet run
