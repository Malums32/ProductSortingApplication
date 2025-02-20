using ProductSortingApp.Services;
using ProductSortingAppWithDB.Models;
using ProductSortingAppWithDB.Services;
using ProductSortingAppWithDB.UI;
using ProductSortingAppWithDB.Utilities.Interfaces;

//using ProductSortingAppWithDB.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProductSortingAppWithDB
{
    internal class Program
    {
        /// <summary>
        /// Handles the program operations and functionalities
        /// </summary>    
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Sorting Application!");

            var app = new ProductSortApp(); 
            app.Run();

            Console.WriteLine("Thank you for using the Product Sorting Application! Goodbye!");

        }
    }
}
