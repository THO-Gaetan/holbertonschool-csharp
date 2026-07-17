#!/usr/bin/env bash

dotnet new console -n "0-abstract_thinking"
cd 0-abstract_thinking
dotnet build
mv Program.cs 0-abstract_thinking.cs
dotnet run
