using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Teclado
    {
        string Marca;
        string Modelo;
        string TipoDeSwitch;
        bool Retroiluminacion;
        string Color;
        string layout;

        public Teclado(string marca, string modelo, string tipoDeSwitch, bool retroiluminacion, string color, string layout)
        {
            Marca = marca;
            Modelo = modelo;
            TipoDeSwitch = tipoDeSwitch;
            Retroiluminacion = retroiluminacion;
            Color = color;
            this.layout = layout;
        }
    }
}
