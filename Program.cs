using Microsoft.Data.Sqlite;

string connectionString = @"Data Source=habitLogger.db";

using (var connection = new SqliteConnection(connectionString))
{
    connection.Open();

    var tableCmd = connection.CreateCommand();

    tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS drink_water(
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Date TEXT,
                            Quantity INTEGER)";
    tableCmd.ExecuteNonQuery();

    connection.Close();
}