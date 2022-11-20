using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_da_Decimale_a_Esadecimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int decimalNumber, quotient;
                int i = 1, j, temp = 0;
                char[] hexadecimalNumber = new char[100];
                char temp1;
                Console.WriteLine("Inserisci il numero decimale :");
                decimalNumber = int.Parse(Console.ReadLine());
                quotient = decimalNumber;
                while (quotient != 0)
                {
                    temp = quotient % 16;
                    if (temp < 10)
                        temp = temp + 48;
                    else
                        temp = temp + 55;
                    temp1 = Convert.ToChar(temp);
                    hexadecimalNumber[i++] = temp1;
                    quotient = quotient / 16;
                }
                Console.Write("Il numero esadecimale è: ");
                for (j = i - 1; j > 0; j--)
                    Console.Write(hexadecimalNumber[j]);
                Console.WriteLine("");
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
