#!/usr/bin/env bash

dotnet new console -n "1-instance"
cd 1-instance
dotnet build
mv Program.cs 1-instance.cs
dotnet run
