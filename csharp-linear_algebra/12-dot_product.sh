#!/usr/bin/env bash

dotnet new console -n "12-dot_product"
cd 12-dot_product
dotnet build
mv Program.cs 12-dot_product.cs
dotnet run
