using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ED2_InterfacePila;

namespace ED2_ReferenciaInterfacePila
{
    // Page 44
    // Page 46
    class Program
    {
        static void Main(string[] args)
        {

         
            IntPila pilafijaInterface = new PilaFija(112);
            pilafijaInterface.quitar();

            //MORALEJA:
            //MISMA QUE PARA PAGE 45
            //VER ED2_ReferenciaInterfacePilaDinamica
        }
    }
}
