using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Mouse
    {
        string Marca;
        string Modelo;
        string Color;
        string CantidadDeBotones;
        string TipoDeMouse;
        string TipoDeSensor;
        bool Inalambrico;

        public Mouse(string marca, string modelo, string color, string cantidadDeBotones, string tipoDeMouse, string tipoDeSensor, bool inalambrico)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            CantidadDeBotones = cantidadDeBotones;
            TipoDeMouse = tipoDeMouse;
            TipoDeSensor = tipoDeSensor;
            Inalambrico = inalambrico;
        }
    }
}
