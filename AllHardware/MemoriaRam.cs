using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class MemoriaRam
    {
        string Marca;
        string Modelo;
        string CapacidadTotal;
        string Formato;
        string Velocidad;
        string Tecnologia;

        public MemoriaRam(string marca, string modelo, string capacidadTotal, string formato, string velocidad, string tecnologia)
        {
            Marca = marca;
            Modelo = modelo;
            CapacidadTotal = capacidadTotal;
            Formato = formato;
            Velocidad = velocidad;
            Tecnologia = tecnologia;
        }
    }
}
