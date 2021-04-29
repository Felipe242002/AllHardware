using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class PlacaBase
    {
        string Marca;
        string Modelo;
        string Capacidad_De_Ram;
        string Socket;
        string Chipset;
        string Version;

        public PlacaBase(string marca, string modelo, string capacidad_De_Ram, string socket, string chipset, string version)
        {
            Marca = marca;
            Modelo = modelo;
            Capacidad_De_Ram = capacidad_De_Ram;
            Socket = socket;
            Chipset = chipset;
            Version = version;
        }
    }
    
}
