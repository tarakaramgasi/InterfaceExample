using Products;
namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.GetProductInfo();
            p1.DisplayProductInfo();
            Console.WriteLine(p1.Addition(100, 200));
            p1.ThisInterface();
            Console.Read();
        }
    }
}
