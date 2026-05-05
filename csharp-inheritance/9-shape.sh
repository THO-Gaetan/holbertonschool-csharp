#!/usr/bin/env bash

dotnet new console -n "9-shape"
cd 9-shape
dotnet build
mv Program.cs 9-shape.cs
dotnet run
