using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class FuenteDePoder
    {
        string Marca;
        string Modelo;
        string Potencia;
        string Voltaje;
        string TipoDeCertificacion;

        public FuenteDePoder(string marca, string modelo, string potencia, string voltaje, string tipoDeCertificacion)
        {
            Marca = marca;
            Modelo = modelo;
            Potencia = potencia;
            Voltaje = voltaje;
            TipoDeCertificacion = tipoDeCertificacion;
        }
    }
}
