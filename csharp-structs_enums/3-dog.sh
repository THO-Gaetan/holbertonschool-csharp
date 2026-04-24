#!/usr/bin/env bash

dotnet new console -n "3-dog"
cd 3-dog
dotnet build
mv Program.cs 3-dog.cs
dotnet run
