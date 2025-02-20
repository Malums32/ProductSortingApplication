using ProductSortingAppWithDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortingAppWithDB.Services
{
    /// <summary>
    /// Defines all the product-related operations for extension
    /// </summary>
    public interface IProductService
    {
        #region Sorting Lists Products
        List<Products> SortByPrice(List<Products> products);
        List<Products> SortByQuantity(List<Products> products);
        List<Products> SortByProduct_Name(List<Products> products);
        List<Products> GroupByProduct_NameAndSortByPrice(List<Products> products);

        #endregion

        #region Sorting Methods
        int GetPrefixLength(string productName);
        string GetPrefix(string productName);
        #endregion
    }
}
