#!/usr/bin/env bash

dotnet new console -n "10-copy_cut_paste"
cd 10-copy_cut_paste
dotnet build
mv Program.cs 10-copy_cut_paste.cs
dotnet run
