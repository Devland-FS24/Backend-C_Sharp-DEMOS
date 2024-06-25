using System;

namespace ED2
{
    class Program
    {
        static void Main(string[] args)
        {
            A superOb = new A();
            B subOb = new B();
            superOb.i = 10;
            superOb.j = 20;
            Console.WriteLine("Contenido de superOb: ");
            superOb.mostrarij();
            Console.WriteLine();
            //Estos reemplazan los valores previos de i,j
            subOb.i = 7;
            subOb.j = 8;
            subOb.k = 9;
            Console.WriteLine("Contenido de subOb: ");

            //Notese que la ejecucion del metodo mostrarij(), utiliza las variables 
            //i, j del objeto "hijo" de la clase de la cual hereda (A).
            //Sin embargo, las variables i,j del objeto creado a partir de la clase
            //padre o base (superOb), continuan teniendo los valores que les fueron asignados:
            //10 y 20
            subOb.mostrarij();
            subOb.mostrark();
            Console.WriteLine();
            Console.WriteLine("i+j+k en subOb: ");
            subOb.sum();
        }
    }
}
