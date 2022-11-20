using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_da_Decimale_a_Ottale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int decimalNumber, quotient, i = 1, j;
                int[] octalNumber = new int[100];
                Console.WriteLine("Inserisci un numero decimale :");
                decimalNumber = int.Parse(Console.ReadLine());
                quotient = decimalNumber;
                while (quotient != 0)
                {
                    octalNumber[i++] = quotient % 8;
                    quotient = quotient / 8;
                }
                Console.Write("Il numero ottale è: ");
                for (j = i - 1; j > 0; j--)
                {
                    Console.Write(octalNumber[j]);
                }
                Console.WriteLine("");
                Console.Write("Premere un tasto per uscire...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Si è verificato un errore, questi sono i dettagli: " + ex.Message);
                Console.Write("Premere un tasto per uscire...");
            }
        }
    }
}
