using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Gabinete
    {
        string Marca;
        string Modelo;
        string TipoDePlaca;
        string Material;

        public Gabinete(string marca, string modelo, string tipoDePlaca, string material)
        {
            Marca = marca;
            Modelo = modelo;
            TipoDePlaca = tipoDePlaca;
            Material = material;
        }
    }
}
