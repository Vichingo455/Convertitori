using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_da_Esadecimale_a_Decimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Inserisci l'esadecimale: ");
                string hexValues = Console.ReadLine();
                string[] hexValuesSplit = hexValues.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("ESADECIMALE = DECIMALE");
                foreach (String hex in hexValuesSplit)
                {
                    // Convert the number expressed in base-16 to an integer. 
                    int value = Convert.ToInt32(hex, 16);
                    Console.WriteLine(string.Format("{0} = {1}", hex, Convert.ToDecimal(value)));
                }
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
