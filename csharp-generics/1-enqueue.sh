#!/usr/bin/env bash

dotnet new console -n "1-enqueue"
cd 1-enqueue
dotnet build
mv Program.cs 1-enqueue.cs
dotnet run
