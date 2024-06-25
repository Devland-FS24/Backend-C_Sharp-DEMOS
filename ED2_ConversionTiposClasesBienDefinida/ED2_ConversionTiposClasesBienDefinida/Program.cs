using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ConversionTiposClasesBienDefinida
{
    class Program
    {
        // Page 26
        static void Main(string[] args)
        {
            A a = new A();


            //En c#, este objeto no puede existir, sin haber sido definido
            //con la palabra clave "new". Por lo tanto no podra ser
            //asignado al no estar definido.
            //Descomentar esta linea para que no compile:
            //B b;


            B b = new B();
              //Al menos c#, obliga que a que la jerarquia de clases, en una
              //herencia sea respetada. Por ello no es posible asignar
              //a un objeto hijo, un objeto padre.
              //Lo contrario es permitido.
             a = b;

              //En JAVA no estoy seguro si esto esta permitido.
              //Invito al lector a que investigue.
              //Al menos en c#, esta asignacion hace que el proyecto no compile,
              //pues considera que no es posible la conversion de tipos de dato
            
             //Descomentar esta linea para que no compile:
            //b = (B)a;
        }
    }
}
