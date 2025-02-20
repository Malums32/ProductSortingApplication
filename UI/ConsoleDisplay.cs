using ProductSortingAppWithDB.Models;
using ProductSortingAppWithDB.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.UI
{
    public class ConsoleDisplay
    {

        public void DisplayMenu()
        {
            Console.WriteLine("\nPlease choose a sorting option:");
            Console.WriteLine("1. Sort by Price (ascending)");
            Console.WriteLine("2. Sort by Quantity (ascending)");
            Console.WriteLine("3. Sort alphabetically by Product Name (ascending)");
            Console.WriteLine("4. Group by Product Name and sort each group by Price (ascending)");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Press 'M' to show the menu.");
        }

        ///<summary>
        ///Display the sorted products
        ///</summary>
        ///<param name="products">The lost of sorted products</param>

        public void ShowSortedProducts(List<Products> products)
        {
            Console.WriteLine("\nSorted Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("\nPress 'M' to show menu.");
        }

       
    }
}
