#!/usr/bin/env bash

dotnet new console -n "3-writeline"
cd 3-writeline
dotnet build
mv Program.cs 3-writeline.cs
echo "Console.WriteLine(\"\\\"Programming is like building a multilingual puzzle\");" > 3-writeline.cs
dotnet run