# forge-workout-tracker
An application to track workouts of users over time

## Features
- sign in
- select exercises from curated list
- log reps/sets/weight
- track progress over time

## Tech stack
- ASP.NET Core MVC (C#)
- Entity Framework Core
- SQL Server
- Deployable to internal servers or Azure

## Setup
1. Clone the repo: `git clone https://github.com/scsigmund/forge-workout-tracker.git`
2. Update the connection string in `appsettings.json` to point to your SQL database
3. Apply migrations: `dotnet ef database update`
4. Run: `dotnet run`

## Purpose
Created by Scott S as a learning project to understand data modeling and clean architecture
