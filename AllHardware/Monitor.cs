using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Monitor
    {
        string Marca;
        string modelo;
        string TamañoDePantalla;
        string Resolucion;
        string TazaDeRefresco;

        public Monitor(string marca, string modelo, string tamañoDePantalla, string resolucion, string tazaDeRefresco)
        {
            Marca = marca;
            this.modelo = modelo;
            TamañoDePantalla = tamañoDePantalla;
            Resolucion = resolucion;
            TazaDeRefresco = tazaDeRefresco;
        }
    }
}
