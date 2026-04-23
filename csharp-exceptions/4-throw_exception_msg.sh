#!/usr/bin/env bash

dotnet new console -n "4-throw_exception_msg"
cd 4-throw_exception_msg
dotnet build
mv Program.cs 4-throw_exception_msg.cs
dotnet run
