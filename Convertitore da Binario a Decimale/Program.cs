using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_da_Binario_a_Decimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Inserisci il numero binario : ");
                int binaryNumber = int.Parse(Console.ReadLine());
                int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
                Console.WriteLine($"Numero Decimale : {decimalValue} ");
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
