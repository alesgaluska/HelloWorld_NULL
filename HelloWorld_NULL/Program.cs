using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_NULL
{
    class Program
    {
        static void Main(string[] args)
        {

            // NULLABLE se pouziva protoze v DB byvaji hodnoty NULL!!!
            // je treba s tim pocitat a osetrit to

            // string muze nit jako jediny hodnotu null

            Nullable<int> ccislo = null; // plny zapis
            int? cislo = null;  // zkraceny zapis
            int? aaa = null;
            double? velkecislo = null;
            float? strednicislo = null;
            char? znak = null;
            bool? yyy = null;

            // rekne zda ma hodnotu         cislo.HasValue;
            // obsahu samotnou hodnotu      cislo.Value;

            
            if (cislo.HasValue) // je to same jako cislo != null
            {
                Console.WriteLine(cislo.Value); // neni osetreno a v pripade ze cislo = null hodi error programu
                Console.WriteLine("Mam hodnotu");
            }
            else
                Console.WriteLine("Nemam hodnotu");

            int a = cislo ?? 0; // pokud cislo je null stane se neco dalsiho, funguje to jen u nullable typu
            // muze se retezit
            int b = cislo ?? aaa ?? 0; // kdyz je cislo null dej tam aaa, kdyz je aaa null dej tam 0

            Console.ReadKey();

            // https://www.youtube.com/watch?v=O2s-ZznuXH8&t=5s
        }
    }
}
