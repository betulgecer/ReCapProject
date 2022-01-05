using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetAll();
            GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
            {
                NorthwindContext northwindContext = new NorthwindContext();
                var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);

            }

            }
        }
    }
}
