#!/usr/bin/env bash

dotnet new console -n "5-iterate_act"
cd 5-iterate_act
dotnet build
mv Program.cs 5-iterate_act.cs
dotnet run
