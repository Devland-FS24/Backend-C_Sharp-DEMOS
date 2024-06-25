using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_AccesoMiembrosHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Una clase derivada no puede acceder a miembros de la
            //clase base que han sido declarados como privados
            //(private).

             B subOb = new B();
             subOb.establecerij(10, 12);

            //It does nothing...
             subOb.sum();
             Console.WriteLine("Total: " + subOb.total);
        }
    }
}
