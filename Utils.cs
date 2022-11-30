﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitLogger
{

    public class Utils
    {
        static string connectionString = @"Data Source=habitLogger.db";

        public static void GetUserInput()
        {
            Console.Clear();
            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("What would you like to do?\n");

                Console.WriteLine("Type 0 to View All Records");
                Console.WriteLine("Type 1 Insert Record");
                Console.WriteLine("Type 2 Delete Record");
                Console.WriteLine("Type 3 to Update Record");
                Console.WriteLine("Type 4 to Close Application\n");

                Console.WriteLine("-----------------------------");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        GetAllRecords();
                        break;
                    case "1":
                        Insert();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("\nThank you for using Habit Logger!");
                        endApp = true; 
                        break;
                    default:
                        break;
                }
            }
        }

        public static void GetAllRecords()
        {
            Console.Clear();
            using(var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText = $"SELECT * FROM drink_water";

                List<drinkWater> tableData = new();

                SqliteDataReader reader = tableCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tableData.Add(
                        new drinkWater
                        {
                            Id = reader.GetInt32(0),
                            Date = DateTime.ParseExact(reader.GetString(1), "dd-MM-yy", new CultureInfo("en-UK")),
                            Quantity = reader.GetInt32(2)
                        });
                        
                        
                    }
                }
                else
                {
                    Console.WriteLine("No rows Found");
                }
                connection.Close();

                Console.WriteLine("--------------------------\n");

                foreach(var dw in tableData)
                {
                    Console.WriteLine($"{dw.Id} - {dw.Date.ToString("dd-MM-yy")} - Quantity: {dw.Quantity}");
                }
                Console.WriteLine("--------------------------\n");
            }
        }

        public static void Insert()
        {
            string date = GetDateInput();

            int quantity = GetNumberInput("\n\nPlease insert number of glasses or other measure of your choice(no decimals allowed)\n\n");

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = $"INSERT INTO drink_water(date,quantity) VALUES ('{date}','{quantity}')";

                tableCmd.ExecuteNonQuery();
                connection.Close(); 
            }
        }

        public static int GetNumberInput(string message)
        {
            Console.WriteLine(message);

            string numberInput = Console.ReadLine();

            if (numberInput == "0") GetUserInput();

            int finalInput = Convert.ToInt32(numberInput);

            return finalInput;
        }

        public static string GetDateInput()
        {
            Console.WriteLine("\n\nPlease Insert the date: (format: dd-mm-yy). Type 4 to return to main menu");

            string dateInput = Console.ReadLine();

            if (dateInput == "0") GetUserInput();

            return dateInput;
        }
    }
}


