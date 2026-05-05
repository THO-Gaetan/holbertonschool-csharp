#!/usr/bin/env bash

dotnet new console -n "5-shape"
cd 5-shape
dotnet build
mv Program.cs 5-shape.cs
dotnet run
