using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SeleccionDinamicaFiguras
{
    class Program
    {

        // Page 24
        static void Main(string[] args)
        {
          Figura f = new Figura(10, 10);
          Rectangulo r = new Rectangulo(9, 5);
          Triangulo t = new Triangulo(10, 8);
          

            //Notese la relacion con el ejemplo de Page 20
            //En el caso del lenguaje c#, la palabra override
            //es fundamental a la hora de pensar en 
            // "enlace dinamico" o "polimorfismo dinamico"

            //La misma reflexion propuesta para el ejemplo Page 20
            //tiene sentido en este.
          Figura figref = f;
          Console.WriteLine("Area = " + figref.area());

          figref = r;
          Console.WriteLine("Area = " + figref.area());


          figref = t;
          Console.WriteLine("Area = " + figref.area());

          figref = f;
          Console.WriteLine("Area = " + figref.area());
        }
    }
}
