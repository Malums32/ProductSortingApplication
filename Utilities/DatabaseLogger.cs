using ProductSortingAppWithDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.Utilities
{
    public class DatabaseLogger
    {
        private readonly string _connectionString;

        public DatabaseLogger(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Logs a customer activity to the database.
        /// </summary>
        /// <param name="activity">The customer activity to log.</param>
        public void LogCustomerActivity(CustomerActivity activity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO CustomerActivities (CustomerName, Activity, Timestamp, TimeSpent) VALUES (@CustomerName, @Activity, @Timestamp, @TimeSpent)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", activity.CustomerName);
                        command.Parameters.AddWithValue("@Activity", activity.Activity);
                        command.Parameters.AddWithValue("@Timestamp", activity.Timestamp);
                        command.Parameters.AddWithValue("@TimeSpent", activity.Timespent);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred while logging customer activity: {ex.Message}");
            }
        }
    }
}
