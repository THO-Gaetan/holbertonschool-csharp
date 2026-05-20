#!/usr/bin/env bash

dotnet new console -n "30-cross_product"
cd 30-cross_product
dotnet build
mv Program.cs 30-cross_product.cs
dotnet run
