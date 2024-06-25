using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ClaseAbstractaFiguras
{
    // Page 33
    class Program
    {
        static void Main(string[] args)
        {
          //Figura f = new Figura(10, 10);
            // No se puede instanciar un objeto desde una clase abstracta.

          Rectangulo r = new Rectangulo(9, 5);
          Triangulo t = new Triangulo(10, 8);
          Figura figref;
          figref = r;
          Console.WriteLine("Area = " + figref.area());
          figref = t;
          Console.WriteLine("Area = " + figref.area());
          //figref = f;
            //Clase abstracta. No se puede instanciar un objeto.
          Console.WriteLine("Area = Figura no definida. Metodo abstracto no implementado, en clase no instanciable.");
        
        //Moraleja: Notese que tanto en Page 23, como en Page 32, fue necesario
        // el modificador "override" a la hora de implementar metodos, ya sean
        // abstractos o virtuales. De otra forma, se habria caido en el peligro
        // de romper la relacion polimorfica.

        //La ventaja de la clase abstracta radica en poder indicar una lista de
        //metodos "base", que sus clases derivadas siempre deberan implementar,
        //para poder utilizar. 
        //La desventaja, es que esta lista de metodos dificil y estrategicamente,
        //es de facil modificacion. Tampoco es facilmente trasladable a otras
        //arquitecturas de clases, mas alla de para la cual fue creada.
        //Para que una arquitectura, que incluya clases abstractas, sea de 
        //Bajo Acoplamiento, debe estar bien pensada en cuanto a la forma 
        //de implementar sus metodos abstractos.
        
        }
    }
}
