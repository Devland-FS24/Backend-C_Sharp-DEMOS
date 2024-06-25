using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Descomentar para probar Ejemplo 2 de ToString
//using Examples;

namespace ED2_ObjectClass
{
    // Page 35

    class Program
    {
        //Descomentar para correr el ejemplo MemberwiseClone
        // Realiza una copia superficial de p1 y la asigna a p2.
        //public static void DisplayValues(Person p)
        //{
        //   Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
        //   Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        //}

        static void Main(string[] args)
        {

            //Ejemplo MemberwiseClone:

            //Crea una instancia de Persona y asigna valores a sus campos:
            //Person p1 = new Person();
            //p1.Age = 42;
            //p1.Name = "Sam";
            //p1.IdInfo = new IdInfo(6565);

            //// Realiza una copia superficial de p1 y la asigna a p2.
            //Person p2 = (Person) p1.ShallowCopy();

            //// Muestra los valores de p1, p2
            //Console.WriteLine("Original values of p1 and p2:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //DisplayValues(p2);

            //// Cambia el valor de las propiedades de p1 y muestra los valores
            //// de p1 y p2:
            //p1.Age = 32;
            //p1.Name = "Frank";
            //p1.IdInfo.IdNumber = 7878;
            //Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //DisplayValues(p2);

            //// Hace una copia profunda de p1 y la asigna a p3:
            //Person p3 = p1.DeepCopy();

            //// Cambia los miembros de la clase p1 a nuevos valores para 
            //// mostrar la copia profunda.
            //p1.Name = "George";
            //p1.Age = 39;
            //p1.IdInfo.IdNumber = 8641;
            //Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p3 instance values:");
            //DisplayValues(p3);

            // El ejemplo muestra el siguiente resultado:
            //       Original values of p1 and p2: 
            //          p1 instance values: 
            //             Name: Sam, Age: 42 
            //             Value: 6565 
            //          p2 instance values: 
            //             Name: Sam, Age: 42 
            //             Value: 6565 
            //        
            //       Values of p1 and p2 after changes to p1: 
            //          p1 instance values: 
            //             Name: Frank, Age: 32 
            //             Value: 7878 
            //          p2 instance values: 
            //             Name: Sam, Age: 42 
            //             Value: 7878 
            //        
            //       Values of p1 and p3 after changes to p1: 
            //          p1 instance values: 
            //             Name: George, Age: 39 
            //             Value: 8641 
            //          p3 instance values: 
            //             Name: Frank, Age: 32 
            //             Value: 7878

            //MORALEJA PARA MEMBERWISECLONE:
            //La moraleja esta en los tipos valor y  en los 
            //tipos referencia:
            
            //Una copia superficial solo copia valores a un nuevo objeto
            //del mismo tipo(clon) y no hace copia de los miembros 
            //tipos referencia del objeto original.
            //En lugar de eso, el objeto clon hace una referencia
            //a los miembros tipo referencia del objeto original.

            //Una copia profunda crea una nuevo objeto y para los
            //miembros que son tipo referencia se generan nuevas
            //variables tipo referencia, a las que asignara el 
            //mismo valor que tienen los tipos referencia del 
            //objeto original. 





            //------------------------------------------------------
            //Ejemplo Equals(Object):

            //Person person1a = new Person("John");
            //Person person1b = person1a;
            //Person person2 = new Person(person1a.ToString());

            //Console.WriteLine("Calling Equals:");
            //Console.WriteLine("person1a and person1b: {0}", person1a.Equals(person1b));
            //Console.WriteLine("person1a and person2: {0}", person1a.Equals(person2));

            //Console.WriteLine("\nCasting to an Object and calling Equals:");
            //Console.WriteLine("person1a and person1b: {0}", ((object)person1a).Equals((object)person1b));
            //Console.WriteLine("person1a and person2: {0}", ((object)person1a).Equals((object)person2)); 

            // El ejemplo muestra el siguiente resultado: 
            //       person1a and person1b: True 
            //       person1a and person2: False 
            //        
            //       Casting to an Object and calling Equals: 
            //       person1a and person1b: True 
            //       person1a and person2: False

            //Ejemplo 2
            //Descomentar y comentar el resto para probar:
            
            // Si la actual instancia es un tipo valor, el metodo
            // Equals(Object) prueba valores de igualdad. 
            // Valor de igualdad significa:

            //•
            //Los dos objetos son del mismo tipo. Tal como muestra el 
            //siguiente
            //ejemplo, un objeto Byte que tiene un valor de 12, no es igual
            //a un objeto Int32 que tiene un valor de 12, debido
            //a que los dos objetos tienen diferentes 'Tipos' en 
            //tiempo de ejecucion(runtime type)


            //byte value1 = 12;
            //int value2 = 12;

            //object object1 = value1;
            //object object2 = value2;

            //Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
            //                  object1, object1.GetType().Name,
            //                  object2, object2.GetType().Name,
            //                  object1.Equals(object2));

            // El ejemplo muestra el siguiente resultado: 
            //        12 (Byte) = 12 (Int32): False


            //Ejemplo 3:
            //Descomentar y comentar el resto para probar
            //Person person1 = new Person("John");
            //Person person2 = new Person("John");

            //Console.WriteLine("Calling Equals:");
            //Console.WriteLine(person1.Equals(person2));

            //Console.WriteLine("\nCasting to an Object and calling Equals:");
            //Console.WriteLine(((object)person1).Equals((object)person2));  

            // El ejemplo muestra el siguiente resultado: 
            //       Calling Equals: 
            //       True 
            //        
            //       Casting to an Object and calling Equals: 
            //       True

            //MORALEJA PARA EQUALS:
            //Debido a que la clase System.Object es la clase base para todos
            //los tipos del framework .NET, el metodo Object.Equals(Object)
            //provee la comparacion por igualdad por defecto para todos
            //los otros tipos. Sin embargo, los tipos a menudo sobreescriben
            //el metodo Equals para implementar valores de igualdad. Para
            //mas informacion, vea las secciones de notas para Invocadores 
            //y las notas para Heredadores.

            //NOTESE: QUE EN EL EJEMPLO 3, EL MISMO CODIGO EN MAIN,
            //DA COMO RESULTADO 'FALSE', SI SE CAMBIA struct Person
            //POR class Person. ESTO ES POR LA NATURALEZA DEL TIPO DE DATO
            //, EN EL PRIMER CASO TIPO VALOR, EN EL SEGUNDO CASO TIPO
            //REFERENCIA.







            //------------------------------------------------------
            //Ejemplo Finalize:
            //(se indica en codigo con el simbolo " ~ ".)

            //Descomentar y comentar el resto para probar
            //ExampleClass ex = new ExampleClass();
            //ex.ShowDuration();

            // El ejemplo muestra un resultado como el siguiente:
            //    Instantiated object 
            //    This instance of ExampleClass has been in existence for 00:00:00.0011060 
            //    Finalizing object 
            //    This instance of ExampleClass has been in existence for 00:00:00.0036294


            //MORALEJA: TAL COMO DICE LA DEFINICION DE MICROSOFT, NO ES
            //POSIBLE SABER CON EXACTITUD EN QUE MOMENTO SE INVOCA AL 
            //METODO OBJECT.FINALIZE().
            //LO QUE SI SE PUEDE DEDUCIR, ES QUE TAL METODO ES LLAMADO
            //'IMPLICITAMENTE', CUANDO SE EJECUTA AL DESTRUCTOR (' ~ ')
            //DE LA CLASE BASE, CON PROPOSITOS DE LIMPIEZA DE RECURSOS
            //QUE QUEDAN EN DESUSO.





            //------------------------------------------------------
            //Ejemplo GetType
             

            //EJEMPLO 1
            //Descomentar y comentar Ejemplo Test y el resto para probar
            //int n1 = 12;
            //int n2 = 82;
            //long n3 = 12;

            //Console.WriteLine("n1 and n2 son del mismo tipo?: {0}",
            //                  Object.ReferenceEquals(n1.GetType(), n2.GetType()));
            //Console.WriteLine("n1 and n3 son del mismo tipo?: {0}",
            //                  Object.ReferenceEquals(n1.GetType(), n3.GetType()));


            //El ejemplo muestra el siguiente resultado: 
            //       n1 and n2 are the same type: True 
            //       n1 and n3 are the same type: False      


            //Ejemplo Test
            //Descomentar y comentar el resto para probar
            //MyBaseClass myBase = new MyBaseClass();
            //MyDerivedClass myDerived = new MyDerivedClass();
            //object o = myDerived;
            //MyBaseClass b = myDerived;
            
            //Prueba de asignacion
            //Descomentar y compilar para ver el error.
            //MyDerivedClass c = b;


            //Console.WriteLine("mybase: Type is {0}", myBase.GetType());
            //Console.WriteLine("myDerived: Type is {0}", myDerived.GetType());
            //Console.WriteLine("object o = myDerived: Type is {0}", o.GetType());
            //Console.WriteLine("MyBaseClass b = myDerived: Type is {0}", b.GetType());

            // Resultado: 
            //    mybase: Type is MyBaseClass 
            //    myDerived: Type is MyDerivedClass 
            //    object o = myDerived: Type is MyDerivedClass 
            //    MyBaseClass b = myDerived: Type is MyDerivedClass


            //MORALEJA:
            //Notese que la creacion del objeto "b", implica una relacion
            //de herencia "implicita", con la clase derivada MyDerivedClass
            //Por lo tanto, una asignacion en forma inversa, arrojaria el
            //error "Ya existe una conversion implicita", tal como
            //se ve en la linea 'Prueba de asignacion'.
            //Para mas informacion, vuelva a estudiar el ejemplo Page 28:
            //Conversion de tipos entre clases, asignacion correcta.

            //NOTESE 2: LA IMPORTANCIA DE GetType RADICA EN SU CAPACIDAD
            //PARA PROVEER INFORMACION DE COMPARACION Y EN CAPACIDAD
            //PARA ANALIZAR LA NATURALEZA DE OBJETOS A CUYO CODIGO FUENTE
            //NO SIEMPRE TENDREMOS A MANO O SERAN DE NUESTRA AUTORIA.

            //SI TE DA CURIOSIDAD UNA FORMA MAS POTENTE DE USAR
            //EL METODO GETTYPE, TE INVITO A INVESTIGAR REFLECTION C#






            //------------------------------------------------------
            //Ejemplo GetHashCode
            //No tiene ejemplo en codigo Principal (Main)
            //Escrito en la clase ED2_ObjectClass

            //Sin embargo, escribi una breve implementacion gracias al
            //"QUE PASA SI...", que siempre es bueno tenerlo presente:

            //Ejemplo 1
            //Descomentar y comentar el resto
            //int res = 0;
            //Int32 test = new Int32();
            //test.value = 125;
            //res = test.GetHashCode();
            //Console.WriteLine("El codigo hash del ejemplo es: {0}", res.ToString());





            //Ejemplo 2
            //Descomentar y comentar el resto
            //Point p = new Point();
            //p.x = 4;
            //p.y = 4;
            //Console.WriteLine("El codigo hash a partir de la operacion XOR, es {0}",p.GetHashCode().ToString());



            //Ejemplo 3
            //Invito al lector a crear una forma de implementar este codigo
            //, basado en el ejemplo anterior, por ejemplo.


            //Ejemplo 4
            //Las operaciones que explotan las capacidades Arimetico-Logicas
            //del procesador, en la actualidad no son muy comunes.
            //Estoy hablando del operador de cambio a derecha (>>)
            //que se ve en el ejemplo.
            //Por lo tanto, el lector puede obviar el ejemplo a efectos
            //de darle un uso practico "promedio", en el mercado de
            //desarrollo de software para soluciones de negocio.


            //MORALEJA:
            //GetHashCode es un metodo que provee la clase Object
            //para que cualquier tipo derivado de ella
            //pueda ser capaz de generar rapidamente un numero
            //"unico" que identifique univocamente las instancias
            //de cualquier tipo.









            //------------------------------------------------------
            //Ejemplo ToString
            //Descomentar y comentar el resto para probar
            //Object obj = new Object();
            //Console.WriteLine(obj.ToString());
            // El ejemplo muestra el siguiente resultado: 
            //      System.Object


            //Ejemplo 2:
            //Descomentar y comentar el resto para probar
            //object obj1 = new Object1();
            //Console.WriteLine(obj1.ToString());
            // El ejemplo muestra el siguiente resultado: 
            //   Examples.Object1



            //Ejemplo 3:
            //Object2 obj2 = new Object2('a');
            //Console.WriteLine(obj2.ToString());

            // El ejemplo muestra el siguiente resultado: 
            //       Object2: a

            // Nota para implementadores:

            // Cuando implementas tus propios tipos, deberias sobreescribir
            // el metodo ToString para retornar valores que tengan sentido
            // para esos tipos. Las clases derivadas que requieran mas
            // control sobre el formato que el control que provee el metodo
            // ToString pueden implementar la interface IFormattable.
            // Su metodo IFormattable.ToString(String, IFormatProvider), 
            // permite que definas strings de formato que controlan el 
            // formato y uso de un objeto que puede proveer IFormatProvider 
            // para el formato culture-specific.

            //MORALEJA:
           
            //Debido a que Object es la clase base de todos
            //los tipos referencia en el framework .NET, 
            //este comportamiento es heredado por tipos referencia
            //que no sobreescriben el metodo ToString.

            //NOTESE
            //PARA CUANDO ES NECESARIO DESCRIBIR CON PALABRAS
            //LA NATURALEZA DE UN TIPO DE DATO DEFINIDO POR EL
            //PROGRAMADOR, SE DEBE RECURRIR A SOBREESCRIBIR EL METODO
            //TOSTRING.
        
        }

        //MORALEJA DE SYSTEM.OBJECT:
        //LA CLASE SYSTEM.OBJECT PROVEE UN MINIMO CONJUNTO DE METODOS
        //QUE PERMITEN AL DESARROLLADOR TRABAJAR CON LOS TIPOS DE DATO
        //PROPIOS DEL FRAMEWORK .NET, DE MANERA CONFIABLE, EFICIENTE Y 
        //RAPIDA.
        //SIN EMBARGO, EL DESARROLLADOR TAMBIEN PUEDE CREAR Y TRABAJAR
        //CON SUS PROPIOS TIPOS DE DATO PERSONALIZADOS.
        //AUNQUE PARA ALGUNOS METODOS QUE SON ORIGINALES DE SYSTEM.OBJECT,
        //DEBERA SOBREESCRIBIRLOS.
    }
}
