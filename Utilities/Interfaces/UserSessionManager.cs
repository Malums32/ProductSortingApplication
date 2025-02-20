using ProductSortingAppWithDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.Utilities.Interfaces
{
    /// <summary>
    ///  Manages user login and logout activities
    /// </summary>
    public class UserSessionManager
    {
        private readonly DatabaseLogger _dataLogger;

        public UserSessionManager(string connectionString)
        {
            _dataLogger = new DatabaseLogger(connectionString);
        }

        public string GetCustomerName()
        {
            string customerName;
            while (true)
            {
                Console.Write("Enter your name: ");
                customerName = Console.ReadLine()?.Trim();

                try
                {
                    if (string.IsNullOrWhiteSpace(customerName))
                        throw new ArgumentException("Name cannot be empty. Please enter your name.");

                    if (Regex.IsMatch(customerName, @"\d"))
                        throw new ArgumentException("Name cannot contain numbers. Please enter a valid name.");

                    break; // Valid input, exit loop
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return customerName;
        }

        /// <summary>
        /// Handling user logons
        /// </summary>
        /// <param name="customerName">The string value of the customer</param>

        public void LogCustomerLogin(string customerName)
        {
            var loginActivity = new CustomerActivity
            {
                CustomerName = customerName,
                Activity = "Logged in",
                Timestamp = DateTime.Now,
            };
            _dataLogger.LogCustomerActivity(loginActivity);
        }

        public void LogCustomerLogout(string customerName, TimeSpan timeSpent)
        {
            var logoutActivity = new CustomerActivity
            {
                CustomerName = customerName,
                Activity = "Logged out",
                Timestamp = DateTime.Now,
                Timespent = timeSpent
            };
            _dataLogger.LogCustomerActivity(logoutActivity);

            Console.WriteLine($"Time spent: {timeSpent}");
        }

    }
}
