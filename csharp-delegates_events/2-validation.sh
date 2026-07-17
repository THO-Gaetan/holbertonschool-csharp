#!/usr/bin/env bash

dotnet new console -n "2-validation"
cd 2-validation
dotnet build
mv Program.cs 2-validation.cs
dotnet run
