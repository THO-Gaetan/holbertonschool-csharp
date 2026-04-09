#!/usr/bin/env bash

dotnet new console -n "4-queue_enqueue_dequeue"
cd 4-queue_enqueue_dequeue
dotnet build
mv Program.cs 4-queue_enqueue_dequeue.cs
dotnet run
