#!/usr/bin/env bash

dotnet new console -n "11-linkedlist_sum"
cd 11-linkedlist_sum
dotnet build
mv Program.cs 11-linkedlist_sum.cs
dotnet run
