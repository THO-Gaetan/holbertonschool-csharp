#!/usr/bin/env bash

dotnet new console -n "2-dequeue"
cd 2-dequeue
dotnet build
mv Program.cs 2-dequeue.cs
dotnet run
