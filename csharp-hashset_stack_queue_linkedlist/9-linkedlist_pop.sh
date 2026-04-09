#!/usr/bin/env bash

dotnet new console -n "9-linkedlist_pop"
cd 9-linkedlist_pop
dotnet build
mv Program.cs 9-linkedlist_pop.cs
dotnet run
