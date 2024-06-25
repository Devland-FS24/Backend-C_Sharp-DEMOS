using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_AccesoMiembrosOcultados
{
    class Program
    {
          // Page 15
        static void Main(string[] args)
        {
            B subOb = new B(1, 2);
            subOb.mostrar();

            //El objetivo de este ejemplo es mostrar el uso de la palabra clave 
            // "base". En este caso como medio de acceder a miembros de la clase base
            //que han sido "ocultados" por la clase derivada.

            //Notese la relacion de este ejemplo con el de Page 13.
            //Se busca hacer enfasis en la forma mas apropiada de trabajar con
            //variables de clase base y de clases derivadas de esta.
        }
    }
}
