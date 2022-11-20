using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_da_Ottale_a_Decimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write($"Inserisci il numero ottale: ");
                int OctalNumber = int.Parse(Console.ReadLine());
                int Decimal_Number = 0;
                int BASE = 1;
                int temp = OctalNumber;
                while (temp > 0)
                {
                    int last_digit = temp % 10;
                    temp /= 10;
                    Decimal_Number += last_digit * BASE;
                    BASE *= 8;
                }
                Console.WriteLine($"Numero decimale : {Decimal_Number}");
                Console.Write("Premere un tasto per uscire...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Si è verificato un errore, questi sono i dettagli: " + ex.Message);
                Console.Write("Premere un tasto per uscire...");
                Console.ReadKey();
            }
        }
    }
}
