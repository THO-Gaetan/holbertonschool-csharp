#!/usr/bin/env bash

dotnet new console -n "8-linkedlist_find"
cd 8-linkedlist_find
dotnet build
mv Program.cs 8-linkedlist_find.cs
dotnet run
