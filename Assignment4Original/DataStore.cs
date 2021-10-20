using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Original
{
    public static class DataStore
    {
        public static Catalog Load(string filePath)

        {
            Catalog myCatalog = new Catalog();
            
            try
            {
                StreamReader myReader = new StreamReader(filePath );
                string productLine = "";
                List<Product> myProductList = new List<Product>();

                while ((productLine = myReader.ReadLine()) != null)
                {
                    string[] myFields = productLine.Split(new char[] { '\t' });

                    Product myLineProduct = new Product
                    {
                        Name = myFields[0],
                        Department = (Department)Enum.Parse(typeof(Department), myFields[1], true),
                        Price = Convert.ToDecimal(myFields[2])
                    };
                    myProductList.Add(myLineProduct);
                }

                myReader.Close();
                myCatalog._list = myProductList;

            }
            catch (FileNotFoundException e)
            {
                throw new Exception($" File Not Found in Data Reading details :{e.Message }");
            }
            catch (Exception e)
            {
                throw new Exception($"Error in Product Loading, Details:{e.Message }");
            }

            return myCatalog ;
        }
        public static void Save(Catalog catalog, string filePath)
        {
            try
            {
                StreamWriter myWriter = new StreamWriter(filePath);

                foreach (Product productItem in catalog._list)
                {
                    myWriter.WriteLine($"{productItem.Name}\t{productItem.Department}\t{productItem.Price}");
                }
                myWriter.Close();

            }
            catch (Exception e)
            {
                throw new Exception($"Error Saving to File details : {e.Message}");
            }
        }
    }
}
