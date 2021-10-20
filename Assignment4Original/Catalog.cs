using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Original
{
    public class Catalog
    {
        public List<Product> _list;
        
        
        public  void Add(Product product)
        {
            _list.Add(product);
        }

        public  IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return (IEnumerable<Product>)_list ;
            }
        
            catch(Exception e)
            {
                throw new Exception($"Error in Product Loading, Details:{e.Message }");
            }
        }

        public  IEnumerable<Product> GetProducts(string filter)
        {

            try
            {
                List<Product> returnProductList = new List<Product>();

                foreach (Product productItem in _list)
                {

                    if (productItem.Name.Trim().ToUpper() == filter.Trim().ToUpper())
                    {
                        Product lineProduct = productItem;
                        returnProductList.Add(lineProduct);

                    }

                }
                return (IEnumerable<Product>)returnProductList;
            }
            catch (Exception e)
            {
                throw new Exception($"Error in Product Loading, Details:{e.Message }");
                
            }
        }

    }
}
