#!/usr/bin/env bash

dotnet new console -n "9-add_key_value"
cd 9-add_key_value
dotnet build
mv Program.cs 9-add_key_value.cs
dotnet run
