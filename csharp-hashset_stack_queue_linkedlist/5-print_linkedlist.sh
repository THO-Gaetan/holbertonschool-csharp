#!/usr/bin/env bash

dotnet new console -n "5-print_linkedlist"
cd 5-print_linkedlist
dotnet build
mv Program.cs 5-print_linkedlist.cs
dotnet run
