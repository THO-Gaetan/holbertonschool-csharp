#!/usr/bin/env bash

dotnet new console -n "2-doors"
cd 2-doors
dotnet build
mv Program.cs 2-doors.cs
dotnet run
