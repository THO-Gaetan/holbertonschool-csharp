#!/usr/bin/env bash

dotnet new console -n "0-positive_or_negative"
cd 0-positive_or_negative
dotnet build
mv Program.cs 0-positive_or_negative.cs
dotnet run
