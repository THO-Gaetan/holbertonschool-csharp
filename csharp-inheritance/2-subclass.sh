#!/usr/bin/env bash

dotnet new console -n "2-subclass"
cd 2-subclass
dotnet build
mv Program.cs 2-subclass.cs
dotnet run
