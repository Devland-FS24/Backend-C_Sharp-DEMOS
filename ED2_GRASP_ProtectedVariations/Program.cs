using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_GRASP_ProtectedVariations
{
    class Program
    {
        static void Main(string[] args)
        {

            //SIMPLE EXAMPLE
            Printer printer = new Printer();
                    printer.print();

            //En este ejemplo de c#, la clase Printer tiene un metodo print.
            //Este metodo print, en lugar de ejecutar la impresion el mismo,
            //delega la tarea a la clase RealPrinter. Para el mundo exterior,
            //pareciera que la clase Printer esta llevando a cabo la impresion,
            //pero en realidad la clase RealPrinter es la que hace el trabajo.
            //La Delegacion consiste simplemente en pasar una tarea a 
            //alguien/algo mas.
            //END OF SIMPLE EXAMPLE


            //COMPLEX EXAMPLE
            //C c = new C();
            //c.f();     // output: A: doing f()
            //c.g();     // output: A: doing g()
            //c.toB();
            //c.f();     // output: B: doing f()
            //c.g();     // output: B: doing g()

            //A traves del uso de interfaces, la delegacion puede ser mas 
            //flexible y se pueden evitar errores por inconsistencias de tipos
            //de dato(type-safety o tipo de dato resguardado). En este punto
            //"Flexibilidad" significa que C no necesita referirse a A o B en
            //ninguna forma, dado que el intercambio de delegacion se abstrae
            //de la clase C. No hace falta decir, que los metodos toA() y 
            //toB() no cuentan como referencias a A y B. En este ejemplo, 
            //la clase C puede delegar ya sea a la clase A o a la clase B.
            //La clase C tiene metodos para cambiar entre las clases A y B. 
            //Incluyendo las clausulas de implementacion que mejoras el 
            //resguardo de tipos (type safety), dado que cada clase debe
            //implementar los metodos en la interface. El principal 
            //costo-beneficio aqui, reside en una mayor codificacion

            //END OF COMPLEX EXAMPLE
        }
    }
}
