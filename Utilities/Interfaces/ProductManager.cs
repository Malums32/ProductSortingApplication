using ProductSortingAppWithDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.Utilities.Interfaces
{
    /// <summary>
    /// Handles product-related operations
    /// </summary>
    public class ProductManager
    {
        private readonly DatabaseHelper _dataHelper;

        public ProductManager(string connectionString)
        {
            _dataHelper = new DatabaseHelper(connectionString);
        }

        public List<Products> GetAllProducts()
        {
            return _dataHelper.GetAllProducts();
        }
    }
}
