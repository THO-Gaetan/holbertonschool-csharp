#!/usr/bin/env bash

dotnet new console -n "11-concat_edges"
cd 11-concat_edges
dotnet build
mv Program.cs 11-concat_edges.cs
dotnet run
