#!/usr/bin/env bash

dotnet new console -n "100-hello_error"
cd 100-hello_error
dotnet build
mv Program.cs 100-hello_error.cs
dotnet run
