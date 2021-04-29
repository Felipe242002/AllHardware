using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Disipador
    {
        string Marca;
        string Modelo;
        string TipoDeDisipador;
        string TamañoDeVentilador;

        public Disipador(string marca, string modelo, string tipoDeDisipador, string tamañoDeVentilador)
        {
            Marca = marca;
            Modelo = modelo;
            TipoDeDisipador = tipoDeDisipador;
            TamañoDeVentilador = tamañoDeVentilador;
        }
    }
}
