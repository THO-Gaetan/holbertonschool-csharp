#!/usr/bin/env bash

dotnet new console -n "10-linkedlist_get_node"
cd 10-linkedlist_get_node
dotnet build
mv Program.cs 10-linkedlist_get_node.cs
dotnet run
