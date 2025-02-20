using ProductSortingApp.Services;
using ProductSortingAppWithDB.Models;
using ProductSortingAppWithDB.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.Utilities.Interfaces
{
    internal class ProductSortApp
    {
        private readonly UserSessionManager _sessionManager;
        private readonly ProductManager _productManager;
        private readonly ConsoleUI _consoleUI;

        public ProductSortApp()
        {
            var connectionString = @"Data Source=DESKTOP-P0UCL71\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;";
            _sessionManager = new UserSessionManager(connectionString);
            _productManager = new ProductManager(connectionString);
            _consoleUI = new ConsoleUI(new ProductService());
        }

        public void Run()
        {
            string customerName = _sessionManager.GetCustomerName();
            _sessionManager.LogCustomerLogin(customerName);

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            List<Products> products = _productManager.GetAllProducts(); // Ensure products are retrieved
            _consoleUI.Run(products);
            stopwatch.Stop();

            _sessionManager.LogCustomerLogout(customerName, stopwatch.Elapsed);
        }
    }
}
