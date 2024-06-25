using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Partial
{
    // Page 64
    public partial class Employee
    {
        public void DoWork()
        {
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
        }
    }

    //NOTESE:
    //El modificador parcial no esta disponible para declaraciones
    //tipo 'delegate' o 'enumeration'

    //Los tipos anidados pueden ser parciales, incluso si el tipo
    //dentro del cual estan anidados en si mismo parcial. Por ejemplo:

    class Container
    {
        partial class Nested
        {
            void Test() { }
        }
        partial class Nested
        {
            void Test2() { }
        }
    }

    
    //En tiempo de compilacion, los atributos de definiciones tipo-parcial
    //son fusionados. Por ejemplo, las siguientes declaraciones:


    [System.SerializableAttribute]
    partial class Moon { }

    [System.ObsoleteAttribute]
    partial class Moon { }

 
    //son equivalentes a:


    //Descomentar este bloque y comentar la version previa, para ver:

    //[System.SerializableAttribute]
    //[System.ObsoleteAttribute]
    //class Moon { }

    //Otro ejemplo:

    //partial class Earth : Planet, IRotate { }
    //partial class Earth : IRevolve { }

 
    //son equivalentes a:

   
    //class Earth : Planet, IRotate, IRevolve { }


    //Existen varias reglas a seguir cuando se trabajar con definiciones
    //de clase parcial:

    //Todas las definiciones de tipo-parcial pensadas para ser parte del 
    //mismo tipo deben estar con el modificador 'partial'.
    //Por ejemplo, las siguientes declaraciones de clases generan un error:


    //Sea la clase parcial A:

    //Parte 1 de la clase A
    public partial class A { }

    //Desomentar para ver el error al compilar:
    //Parte 2 de la clase A
    //public class A { }  
    // Error, tambien debe estar marcada como parcial

    //El modificador parcial puede solamente aparecer inmediatamente antes
    //que las palabras clave class, struct o interface.

    //Los tipos parciales estan permitidos en definiciones tipo-parcial,
    //por ejemnplo:

    partial class ClassWithNestedClass
    {
        partial class NestedClass 
        { 
        }
    }

    partial class ClassWithNestedClass
    {
        partial class NestedClass 
        { 
        }
    }

    //En el siguiente ejemplo, los campos y el constructor de la clase
    //CoOrds, estan declarados en una definicion de clase parcial, 
    //mientras que el miembro(metodo) PrintCoOrds, esta declarado en otra 
    //definicion de clase parcial

    public partial class CoOrds
    {
        private int x;
        private int y;

        //Constructor de clase CoOrds
        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class CoOrds
    {
        //Metodo de clase CoOrds
        public void PrintCoOrds()
        {
            System.Console.WriteLine("CoOrds: {0},{1}", x, y);
        }

    }

    //El siguiente ejemplo muestra que tambien podes desarrollar
    //structs e interfaces parciales:

    partial interface ITest
    {
        void Interface_Test();
    }

    partial interface ITest
    {
        void Interface_Test2();
    }

    partial struct S1
    {
        void Struct_Test() 
        {
 
        }
    }

    partial struct S1
    {
        void Struct_Test2() 
        { 
        
        }
    }
}
