using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEFY_StringMagicTricks
{
    public static class MagicTricks
    {
        //No es posible utilizando una misma funcion.
        //Por principios de cohesion, la misma funcion no puede
        //aceptar dos escenarios diferentes, en uno invierte el
        //orden de un array de strings y en el otro invierte
        //el orden de un conjunto de caracteres.
        //Es tecnicamente posible de hacer, pero a costa de un
        //mantenimiento mas dificil sobre la funcion/metodo, a futuro.
        public static string Reverse(string x)
        {
            string text=x;
            string[] words = text.Split(' ');
            Array.Reverse(words);
            text = String.Join(" ", words);

            return text;
        }
    }
}
