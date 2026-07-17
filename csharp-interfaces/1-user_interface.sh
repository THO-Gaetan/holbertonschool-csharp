#!/usr/bin/env bash

dotnet new console -n "1-user_interface"
cd 1-user_interface
dotnet build
mv Program.cs 1-user_interface.cs
dotnet run
