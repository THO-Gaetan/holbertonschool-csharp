#!/usr/bin/env bash

dotnet new console -n "12-linkedlist_insert"
cd 12-linkedlist_insert
dotnet build
mv Program.cs 12-linkedlist_insert.cs
dotnet run
