#!/usr/bin/env bash

dotnet new console -n "3-throw_exception"
cd 3-throw_exception
dotnet build
mv Program.cs 3-throw_exception.cs
dotnet run
