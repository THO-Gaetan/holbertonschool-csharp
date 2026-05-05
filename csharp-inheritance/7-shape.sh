#!/usr/bin/env bash

dotnet new console -n "7-shape"
cd 7-shape
dotnet build
mv Program.cs 7-shape.cs
dotnet run
