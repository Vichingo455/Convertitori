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
                int n1, n5, p = 1, k, ch = 1;
                int dec = 0, i = 1, j, d;
                Console.WriteLine("Inserisci il numero ottale:");
                n1 = Convert.ToInt32(Console.ReadLine());
                n5 = n1;
                for (; n1 > 0; n1 = n1 / 10)
                {
                    k = n1 % 10;
                    if (k >= 8)
                    {
                        ch = 0;
                    }
                }
                switch (ch)
                {
                    case 0:
                        Console.Write("\nIl numero inserito non è un numero ottale. \n\n");
                        break;
                    case 1:
                        n1 = n5;
                        for (j = n1; j > 0; j = j / 10)
                        {
                            d = j % 10;
                            if (i == 1)
                                p = p * 1;
                            else
                                p = p * 8;
                            dec = dec + (d * p);
                            i++;
                        }
                        Console.Write("\nNumero Decimale : {1} \n\n", dec);
                        break;
                }
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
