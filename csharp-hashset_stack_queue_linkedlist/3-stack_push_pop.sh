#!/usr/bin/env bash

dotnet new console -n "3-stack_push_pop"
cd 3-stack_push_pop
dotnet build
mv Program.cs 3-stack_push_pop.cs
dotnet run
