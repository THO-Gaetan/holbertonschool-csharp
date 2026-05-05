#!/usr/bin/env bash

dotnet new console -n "6-shape"
cd 6-shape
dotnet build
mv Program.cs 6-shape.cs
dotnet run
