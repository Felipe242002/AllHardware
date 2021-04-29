using AllHardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardwarePrincipal 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Procesador proc1 = new Procesador();
            Console.WriteLine("Los procesadores actuales son: ");
            Console.WriteLine("");
            proc1.ImprimirProc("Intel I3-8800", "FCLGA1151", 4, 4, "2.3Ghz");

            Console.WriteLine("");

            Procesador proc2 = new Procesador();
            proc1.ImprimirProc("AMD Ryzen 5 2600", "AM4",6,6,"3,4Ghz");

            Console.WriteLine();

            TarjetaDeVideo TDV = new TarjetaDeVideo();
            TDV.ImprTDV("ASUS","Strix 5600","4GB","DDR5");

            Console.ReadLine();
        }
        
    }
}
