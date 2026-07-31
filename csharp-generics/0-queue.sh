#!/usr/bin/env bash

dotnet new console -n "0-queue"
cd 0-queue
dotnet build
mv Program.cs 0-queue.cs
dotnet run
