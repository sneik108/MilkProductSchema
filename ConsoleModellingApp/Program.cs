using ModelProducts;
using ModelProducts.Factory;
using System;
using System.Linq;

namespace ConsoleModellingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Milk milk = new Milk(100000, 3.4);

            Agregat agregat = new CreamAgregat (2);
            Factory factory = new CreamFactory(agregat);
            var (cream, sideProducts) = factory.ProduceProducts(milk);


            if (cream == null)
            {
                throw new Exception("нет сливок");
            }

            var obrat = new Obrat();
            foreach (var sideProduct in sideProducts)
            {
                obrat = sideProduct as Obrat;
            }

            if (!(obrat != null))
            {
                agregat = new CheeseAgregat(3);
                factory = new CheeseFactory(agregat);
                var (cheese, sideProductsFromCheese) = factory.ProduceProducts(obrat);
                Console.WriteLine($"Cheese. Value:{cheese.Value}, Percentage:{cheese.MilkPercentage}");
            }

            Console.WriteLine($"Cream. Value:{cream.Value}, Percentage:{cream.MilkPercentage}");

            agregat = new ButterAgregat(10);
            factory = new ButterFactory(agregat);
            var (butter, sideProductsFromCream) = factory.ProduceProducts(cream);

            if (butter == null)
            {
                throw new Exception("нет масла");
            }

            Console.WriteLine($"Butter. Value:{butter.Value}, Percentage:{butter.MilkPercentage}");

            Console.ReadKey();
        }
    }
}