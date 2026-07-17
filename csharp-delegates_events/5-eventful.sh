#!/usr/bin/env bash

dotnet new console -n "5-eventful"
cd 5-eventful
dotnet build
mv Program.cs 5-eventful.cs
dotnet run
