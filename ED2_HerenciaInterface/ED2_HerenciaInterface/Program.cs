using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_HerenciaInterface
{
     // Page 48
    class Program
    {
        static void Main(string[] args)
        {
            Miclase ob = new Miclase();
            ob.meth1();
            ob.meth2();
            ob.meth3();

            B test1 = new Miclase();
              test1.meth1();
              test1.meth2();
              test1.meth3();

              A test2 = new Miclase();
                test2.meth1();
                test2.meth2();

           //MORALEJA:
            //LA UTILIZACION DE LA MEMORIA DINAMICA SIEMPRE TENDRA
            //PRIORIDAD SOBRE LA MEMORIA ESTATICA.

            //SI SE ME OCURRE ALGO MAS O AL LECTOR, RESPECTO DE ESTE TEMA, 
            //ADELANTE !!
        }
    }
}
