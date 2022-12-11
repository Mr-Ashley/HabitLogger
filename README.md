# Habit Logger

A console app that allows users to track the amount of times they drink water.


## Requirements

- This is an application where you’ll register one habit.
- This habit can't be tracked by time (ex. hours of sleep), only by quantity (ex. number of water glasses a day)
- The application should store and retrieve data from a real database
- When the application starts, it should create a sqlite database, if one isn’t present.
- It should also create a table in the database, where the habit will be logged.
- The app should show the user a menu of options.
- The users should be able to insert, delete, update and view their logged habit.
- You should handle all possible errors so that the application never crashes.
- The application should only be terminated when the user inserts 0.
- You can only interact with the database using raw SQL. You can’t use mappers such as Entity Framework.
- Your project needs to contain a Read Me file where you'll explain how your app works. Here's a nice example:
## Lessons Learned

I learnt how to:

- Take user input from the console.
- Print messages on the console.
- Install nuget packages in VS 2022.
- Control flow with 'if-else' and 'switch statements'.
- Connect  to a Sqlite database.
- Query the Sqlite database.

## Roadmap

- Let users create their own habits to track. 
- Report functionality where the users can view specific information (i.e. how many times the user ran in a year? how many kms?) 
## Acknowledgements

 - [Google](https://www.google.co.za/)
 - [Sql exercises](https://www.w3schools.com/sql/sql_exercises.asp)
 - [Sqlite tutorial](https://www.youtube.com/watch?v=oeuTw00F1as&t=725s)
 - [Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=netcore-cli)
