using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnlaceDinamico
{

    class Program
    {
        static void Main(string[] args)
        {

            #region EJEMPLO_ENLACE_DINAMICO
            Base b = new Derivada();
            b.metodoVirtual();
            //Output:
            //Derivada.metodoVirtual()
            b.noVirtual();
            //Output:
            //Base.noVirtual()
            #endregion EJEMPLO_ENLACE_DINAMICO

            //Entonces el Enlace dinamico

            //Si quisiera ejecutar metodoVirtual de la clase Base ??
            //Esto esta MAAAAL: base.metodoVirtual();
            //Desde el Main no lo puedo llamar, pero si podria
            //llamarlo por ejemplo, desde dentro de
            //override public void metodoVirtual()
            //en la definicion de metodos de la clase Derivada.
            //En ese caso, tendria la siguiente salida
            //Output:
            //Base.metodoVirtual()

            //Si quisiera ejecutar noVirtual de la clase Derivada ??
            Derivada c = new Derivada();
            c.noVirtual();
            //Output:
            //Derivada.noVirtual()
        }
    }
}
