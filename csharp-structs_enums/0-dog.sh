#!/usr/bin/env bash

dotnet new console -n "0-dog"
cd 0-dog
dotnet build
mv Program.cs 0-dog.cs
dotnet run
