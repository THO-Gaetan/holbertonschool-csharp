#!/usr/bin/env bash

dotnet new console -n "2-replace_element"
cd 2-replace_element
dotnet build
mv Program.cs 2-replace_element.cs
dotnet run
