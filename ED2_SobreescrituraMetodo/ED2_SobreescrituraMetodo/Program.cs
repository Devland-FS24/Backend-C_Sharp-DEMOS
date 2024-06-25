using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SobreescrituraMetodo
{
    class Program
    {
          // Page 17
        static void Main(string[] args)
        {
            B subOb = new B(1, 2, 3);
            subOb.mostrar();

            //Moraleja: La Ocultacion de metodos muestra sus ventajas.
            //Sin embargo, puede ocasionar un gran dolor de cabeza si 
            //se utiliza de manera incorrecta.
            //Dado que el objetivo de la HERENCIA es extender un sistema
            //existente y evitar volver a escribir codigo o tener que rehacer
            //el sistema por completo, quizas es conveniente tener en mente
            //las posibilidades que ofrecen las RELACIONES POLIMORFICAS
            //bien pensadas.
        }
    }
}
