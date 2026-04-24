#!/usr/bin/env bash

dotnet new console -n "2-dog"
cd 2-dog
dotnet build
mv Program.cs 2-dog.cs
dotnet run
