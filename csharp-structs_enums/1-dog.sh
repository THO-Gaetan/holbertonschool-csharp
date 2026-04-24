#!/usr/bin/env bash

dotnet new console -n "1-dog"
cd 1-dog
dotnet build
mv Program.cs 1-dog.cs
dotnet run
