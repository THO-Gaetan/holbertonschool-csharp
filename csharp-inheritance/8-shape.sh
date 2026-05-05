#!/usr/bin/env bash

dotnet new console -n "8-shape"
cd 8-shape
dotnet build
mv Program.cs 8-shape.cs
dotnet run
