using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.Models
{
    public class Products
    {
        #region Property Members
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region String Override Method
        /// <summary>
        /// Overrides the default ToString method to display product details.
        /// </summary>
        /// <returns>A string representation of the product.</returns>
        public override string ToString()
        {
            return $"{Name} - Price: ZAR {Price}, Quantity: {Quantity})";
        }
        #endregion 
    }
}
