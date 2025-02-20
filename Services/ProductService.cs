using System.Collections.Generic;
using System.Linq;
using ProductSortingAppWithDB.Models;
using ProductSortingAppWithDB.Services;

namespace ProductSortingApp.Services
{
    /// <summary>
    /// Provides functionality for sorting and grouping products.
    /// </summary>
    public class ProductService : IProductService
    {
        #region IProductService Members
        /// <summary>
        /// Sorts products by price in ascending order.
        /// </summary>
        /// <param name="products">The list of products to sort.</param>
        /// <returns>A sorted list of products.</returns>
        public List<Products> SortByPrice(List<Products> products)
        {
            return products.OrderBy(p => p.Price).ToList();
        }

        /// <summary>
        /// Sorts products by quantity in ascending order.
        /// </summary>
        /// <param name="products">The list of products to sort.</param>
        /// <returns>A sorted list of products.</returns>
        public List<Products> SortByQuantity(List<Products> products)
        {
            return products.OrderBy(p => p.Quantity).ToList();
        }

        /// <summary>
        /// Sorts products by name in ascending order.
        /// </summary>
        /// <param name="products">The list of products to sort.</param>
        /// <returns>A sorted list of products.</returns>
        public List<Products> SortByProduct_Name(List<Products> products)
        {
            return products.OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Groups products by name and sorts each group by price in ascending order.
        /// </summary>
        /// <param name="products">The list of products to group and sort.</param>
        /// <returns>A grouped and sorted list of products.</returns>
        public List<Products> GroupByProduct_NameAndSortByPrice(List<Products> products)
        {
            return products
                       .GroupBy(p => GetPrefixLength(p.Name)) // Sort by prefix length
                       .SelectMany(group => group.OrderBy(p => p.Price)) // Sort each group by price
                       .ToList();
        }
#endregion 

        #region Sorting Methods
        /// <summary>
        /// Sorts product_Name by single-letter prefix and double-letter prefix of product_Name
        /// </summary>
        /// <param name="productName">The list of products to sort  prefixes</param>
        /// <returns>A list of sorted products by single-letter prefix and double-letter prefix </returns>
        public int GetPrefixLength(string productName)
        {
            string prefix = GetPrefix(productName);
            return prefix.Length; // 1 for single-letter, 2 for double-letter
        }

        public string GetPrefix(string productName)
        {
            string[] words = productName.Split(' ');
            return words.Length > 1 ? words[1] : string.Empty;
        }
        #endregion
    }
}