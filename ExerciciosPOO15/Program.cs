using ExerciciosPOO15.Entities;
using System.Security.AccessControl;

namespace ExerciciosPOO15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int aux = int.Parse(Console.ReadLine());

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");

                Console.WriteLine("Common, used or imported (c/u/i)?");
                char Situation = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String Name = Console.ReadLine();

                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine());

                if (Situation == 'i')
                {
                    Console.Write("Customs fee: ");
                    double CustomFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(Name, Price, CustomFee));
                }
                else if (Situation == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(Name, Price, manufactureDate));
                }
                else if (Situation == 'c')
                {
                    list.Add(new Product(Name, Price));
                }
            }
            Console.WriteLine();

            Console.WriteLine("Price Tags: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
            Console.ReadKey();
        }
    }
}
