using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ConversionTiposClasesAsignacionImplicitaErronea
{
    class Program
    {
        static void Main(string[] args)
        {
           // Sólo pueden darse conversiones de tipo entre clases 
           //relacionadas por herencia.

              // Page 27
            A a = new A();

            // Este objeto no esta definido con la palabra clave "new"
            //Descomentar esta linea para que ocurra un error en tiempo de
            //ejecucion:

            //Linea 1
            //B b;


            //Comentar esta linea para estudiar los errores que se producen
            //al compilar el proyecto
            B b = new B();

            //El error esta en el orden de asignacion:
            //No se puede asignar padre a un hijo (Error 1).
            //Aun si existiera el hijo, el cual no esta definido, 
            //si se descomentara la Linea 1, se estaria violando la
            // "relacion de herencia", en la Linea 2

            //Descomentar esta linea para que ocurra un error en tiempo
            //de ejecucion:

            //Linea 2
            //b = (B)a;



            //Descomentar esta linea para que ocurra un error en tiempo
            //de ejecucion

            //Linea 3
            // b.b = 3;


            //Comentar estas lineas para estudiar los errores que se producen
            //al ejecutar el proyecto
            a = b;
            b.b = 3;
            
        }
    }
}
