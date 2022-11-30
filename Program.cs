using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte binarni cislo: ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalHodnota = 0;
            int base1 = 1;
            string delka = binaryNumber.ToString();
            int[] outarry = Array.ConvertAll(binaryNumber.ToString().ToArray(), x => (int)x);
            Console.WriteLine($"Pocet bitu: {delka.Length}");
            foreach (var c in outarry)
                if (c != '0' && c != '1')
                {
                    Console.WriteLine("Nespravna hodnota...");
                    Console.ReadKey();
                    return;
                }
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalHodnota += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimalni hodnota: {decimalHodnota} ");
            Console.ReadKey();
        }
    }
}
