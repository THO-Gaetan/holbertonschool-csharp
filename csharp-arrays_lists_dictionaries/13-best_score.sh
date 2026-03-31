#!/usr/bin/env bash

dotnet new console -n "13-best_score"
cd 13-best_score
dotnet build
mv Program.cs 13-best_score.cs
dotnet run
