using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                BronzeCard bronzeCard = new BronzeCard(0, 150);
                SilverCard silverCard = new SilverCard(600, 850);
                GoldCard goldCard = new GoldCard(1300, 1300);

                Console.WriteLine("1. Bronze");
                bronzeCard.PrintOutput();

                Console.WriteLine("2. Silver");
                silverCard.PrintOutput();

                Console.WriteLine("3. Gold");
                goldCard.PrintOutput();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"{ae.GetType().Name}: {ae.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}