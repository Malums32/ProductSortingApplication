using ProductSortingAppWithDB.Models;
using ProductSortingAppWithDB.Services;
using ProductSortingAppWithDB.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.UI
{
    public class ConsoleUI : ConsoleDisplay
    {
        private readonly IProductService _productService;
        private ProductManager productManager;

        public ConsoleUI(IProductService productService)
        {
            _productService = productService;
        }

  

        /// <summary>
        /// Displays the main menu and handles user input.
        /// </summary>
        /// <param name="products">The list of products to sort.</param>
        public void Run(List<Products> products)
        {
            bool showMenu = true;

            while (true)
            {
                if (showMenu)
                {
                    DisplayMenu();
                }

                // Read user input
                string input = Console.ReadLine()?.Trim().ToUpper();
                if (input == "5")
                {
                    break;
                }

                switch (input)
                {
                    case "1":
                        ShowSortedProducts(_productService.SortByPrice(products));
                        showMenu = false;
                        break;
                    case "2":
                        ShowSortedProducts(_productService.SortByQuantity(products));
                        showMenu = false;
                        break;
                    case "3":
                        ShowSortedProducts(_productService.SortByProduct_Name(products));
                        showMenu = false;
                        break;
                    case "4":
                        ShowSortedProducts(_productService.GroupByProduct_NameAndSortByPrice(products));
                        showMenu = false;
                        break;
                    case "M":
                        showMenu = true; //show menu when 'M' is pressed
                        break;

                    default:
                        Console.WriteLine("Invalid option. Press 'M' to show the menu.");
                        showMenu = false;
                        break;
                }

                
            }
        }
    }
}
