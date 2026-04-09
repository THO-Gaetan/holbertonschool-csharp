#!/usr/bin/env bash

dotnet new console -n "6-linkedlist_length"
cd 6-linkedlist_length
dotnet build
mv Program.cs 6-linkedlist_length.cs
dotnet run
