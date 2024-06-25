using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//NOTESE: QUE NO HIZO FALTA REFERENCIAR AL NAMESPACE1 Y NAMESPACE2, AQUI.


namespace NameSpace3
{
    // Alias para directiva using para una clase.
    using AliasToMyClass = NameSpace1.MyClass;

    // Alias para directiva using para una clase generica.
    using UsingAlias = NameSpace2.MyClass<int>;

    class Program
    {
        static void Main(string[] args)
        {
            AliasToMyClass instance1 = new AliasToMyClass();
            Console.WriteLine(instance1);

            UsingAlias instance2 = new UsingAlias();
            Console.WriteLine(instance2);
        }

        //MORALEJA: TAL COMO SE PUEDE VER EN EL NAMESPACE PC
        //Y EN EL NAMESPACE 3, EL ALIAS PARA UN USING SE PUEDE
        //DECLARAR AL MENOS DENTRO DEL NAMESPACE QUE LO VA A USAR
    }
}
