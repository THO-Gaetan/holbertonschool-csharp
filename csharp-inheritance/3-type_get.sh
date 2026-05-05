#!/usr/bin/env bash

dotnet new console -n "3-type_get"
cd 3-type_get
dotnet build
mv Program.cs 3-type_get.cs
dotnet run
