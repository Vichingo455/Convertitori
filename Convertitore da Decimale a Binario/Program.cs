using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_da_Decimale_a_Binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Inserisci il numero decimale : ");
                int number = int.Parse(Console.ReadLine());
                string Result = string.Empty;
                for (int i = 0; number > 0; i++)
                {
                    Result = number % 2 + Result;
                    number = number / 2;
                }
                Console.WriteLine($"Numero binario : {Result}");
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
