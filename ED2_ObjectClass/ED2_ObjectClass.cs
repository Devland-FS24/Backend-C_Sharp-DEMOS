using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace ED2_ObjectClass
{
    // Page 35

    //Ejemplo MemberwiseClone:
    // public class IdInfo
    // {
    //     public int IdNumber;

    //     public IdInfo(int IdNumber)
    //     {
    //         this.IdNumber = IdNumber;
    //     }
    // }


    // public class Person 
    // {
    //     public int Age;
    //     public string Name;
    //     public IdInfo IdInfo;

    //     public Person ShallowCopy()
    //     {
    //        return (Person)this.MemberwiseClone();
    //     }

    //     public Person DeepCopy()
    //     {
    //        Person other = (Person) this.MemberwiseClone(); 
    //        other.IdInfo = new IdInfo(this.IdInfo.IdNumber);
    //        return other;
    //     }
    //}



    //Ejemplo Equals(Object):
    //Defina un tipo referencia que no sobreescriba Equals.
    //Descomentar y comentar el resto del codigo de esta clase, 
    //para probar:
    //public class Person
    //{
    //    private string personName;

    //    public Person(string name)
    //    {
    //        this.personName = name;
    //    }

    //    public override string ToString()
    //    {
    //        return this.personName;
    //    }
    //}


    //Ejemplo 3

    // Los valores de campos publicos y privados de los dos
    // objetos son iguales. El siguiente ejemplo prueba la
    // igualdad de valores. Define una estructura (struct) 
    // Persona, 
    // la cual es tipo valor e invoca al constructor del struct
    // Persona para instanciar dos nuevos objetos Persona, 
    // person1 y person2, los cuales tienen el mismo valor.
    // Tal como muestra el resultado del ejemplo, aunque las
    // dos variables objeto se refieren a diferentes objetos,
    // person1 y person2 son iguales debido a que ellos tienen
    // el mismo valor para el campo privado personName.

    // Defina un tipo valor que no sobreescriba Equals.

    // Descomentar y comentar el resto para probar:
    //public struct Person
    //{
    //    private string personName;

    //    public Person(string name)
    //    {
    //        this.personName = name;
    //    }

    //    public override string ToString()
    //    {
    //        return this.personName;
    //    }
    //}


    //Ejemplo Finalize, se indica en codigo con el simbolo 
    //" ~ ":

    //El siguiente ejemplo verifica que el metodo Finalize sea 
    //llamado cuando un objeto que sobreescribe Finalize
    //es destruido. Notese que, en una aplicacion de produccion,
    //el metodo Finalize podria ser sobreescrito para liberar
    //recursos no referenciados contenidos por el objeto. 
    //Notese tambien que el ejemplo C# provee un destructor en 
    //lugar de sobreescribir el metodo Finalize.
    //public class ExampleClass
    //{
    //    Stopwatch sw;

    //    public ExampleClass()
    //    {
    //        sw = Stopwatch.StartNew();
    //        Console.WriteLine("Instantiated object");
    //    }

    //    public void ShowDuration()
    //    {
    //        Console.WriteLine("This instance of {0} has been in existence for {1}",
    //                          this, sw.Elapsed);
    //    }

    //    //Esto es el 'destructor' de la clase base ExampleClass
    //    ~ExampleClass()
    //    {
    //        Console.WriteLine("Finalizing object");

    //        //Esto es Finalize
    //        sw.Stop();
    //        Console.WriteLine("This instance of {0} has been in existence for {1}",
    //                          this, sw.Elapsed);
    //    }
    //}

    //Ejemplo GetType:

    //El siguiente ejemplo de codigo demuestra que GetType
    //retorna el tipo de ejecucion de instancia actual.

    //Ejemplo Test
    //public class MyBaseClass
    //{
    //}

    //public class MyDerivedClass : MyBaseClass
    //{
    //}



    //Ejemplo GetHashCode:

    //Ejemplo 1
    //En algunos casos, el metodo GetHashCode es
    //implementado para simplemente retornar un valor entero.
    //El siguiente ejemplo de codigo ilustra una 
    //implementacion de GetHashCode que retorna un valor 
    //entero.

    // Existen otras formas mas complicadas de combinar
    // codigos hash que puedan dar mejor rendimiento
    // para tablas hash.

    //public struct Int32
    //{
    //    public int value;

    //    //other methods... 

    //    public override int GetHashCode()
    //    {
    //        return value;
    //    }
    //}

    //Frecuentemente, un tipo tiene multiples campos
    //de datos que pueden participar en la generacion 
    //de codigo hash. Una forma de generar un codigo hash
    //consiste en combinar estos campos utilizando una 
    //operacion XOR(OR exclusivo), tal como se muestra en 
    //el siguiente ejemplo de codigo:

    //Ejemplo 2
    //public struct Point
    //{
    //    public int x;
    //    public int y;

    //    //other methods 

    //    public override int GetHashCode()
    //    {
    //        return x ^ y;
    //    }
    //}


    //El siguiente codigo de ejemplo ilustra otro caso, 
    //en donde los campos de tipo son combinados utilizando
    // XOR(OR exclusivo) para generar el codigo hash.
    //Notese que en este ejemplo de codigo, los campos
    //representan tipos definidos por usuario, cada uno de
    //los cuales implementa GetHashCode e Equals.

    //Ejemplo 3:
    //public class SomeType
    //{
    //    public override int GetHashCode()
    //    {
    //        return 0;
    //    }
    //}

    //public class AnotherType
    //{
    //    public override int GetHashCode()
    //    {
    //        return 1;
    //    }
    //}

    //public class LastType
    //{
    //    public override int GetHashCode()
    //    {
    //        return 2;
    //    }
    //}

    //public class MyClass
    //{
    //    SomeType a = new SomeType();
    //    AnotherType b = new AnotherType();
    //    LastType c = new LastType();

    //    public override int GetHashCode()
    //    {
    //        return a.GetHashCode() ^ b.GetHashCode() ^ c.GetHashCode();
    //    }
    //}

    //Ejemplo 4

    //Si el miembro dato de la clase derivada es mayor que
    //un Int32, puede combinar los bits de alto orden
    //del valor con los bits de bajo orden utilizando
    //una operacion XOR(OR exclusivo), tal como muestra
    //el siguiente codigo de ejemplo:

    //public struct Int64
    //{
    //    public long value;

    //    //other methods... 

    //    public override int GetHashCode()
    //    {
    //        return ((int)value ^ (int)(value >> 32));
    //    }
    //}



    //Ejemplo ToString:

    //La implementacion por defecto del metodo ToString
    //retorna el nombre completamente calificado del
    //tipo del objeto, tal como muestra el siguiente ejemplo:


    //Ejemplo 2:

    //Debido a que Object es la clase base de todos
    //los tipos referencia en el framework .NET, 
    //este comportamiento es heredado por tipos referencia
    //que no sobreescriben el metodo ToString.
    //El siguiente ejemplo ilustra esto. Define una clase
    //llamada Object1 que acepta la implementacion por
    //defecto de todos los miembros del objeto. Su metodo
    // ToString retorna el nombre completamente calificado 
    //del objeto.



    //Ejemplo 3:


    //Los tipos comunmente sobreescriben el metodo ToString
    //para retornar un string que representa la instancia
    // del objeto. Por ejemplo, los tipos base tales como
    //Char, Int32 y String proveen implementaciones de ToString
    //que retornan la forma string del valor que el objeto 
    //representa. El siguiente ejemplo define una clase, 
    //Object 2, que sobreescribe el metodo ToString para retornar
    //el nombre del tipo junto con su valor.


    //public class Object2
    //{
    //    private object value;

    //    public Object2(object value)
    //    {
    //        this.value = value;
    //    }

    //    public override string ToString()
    //    {
    //        return base.ToString() + ": " + value.ToString();
    //    }
    //}


}

//Ejemplo ToString
//Ejemplo 2
//Descomentar para probar y comentar el resto:
//namespace Examples
//{
//    public class Object1
//    {
//    }
//}

