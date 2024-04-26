using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product:IProduct,Interface1
    {
        public void GetProductInfo()
        {
            Console.WriteLine("This is Product Info Method");
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine("This is Display Product Info Method");
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public void ThisInterface()
        {
            Console.WriteLine("we are using Interface1 method");
        }


    }
}
