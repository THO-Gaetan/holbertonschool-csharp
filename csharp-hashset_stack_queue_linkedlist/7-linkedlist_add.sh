#!/usr/bin/env bash

dotnet new console -n "7-linkedlist_add"
cd 7-linkedlist_add
dotnet build
mv Program.cs 7-linkedlist_add.cs
dotnet run
