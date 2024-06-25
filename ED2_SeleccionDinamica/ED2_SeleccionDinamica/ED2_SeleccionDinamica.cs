using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SeleccionDinamica
{
      // Page 20
   public class A 
   {
       //Creo que es importante destacar la forma en que se relaciona
       //este ejemplo con el Page 13.
       //Aqui se presenta una variacion del concepto de "Ocultacion",
       //solo que la misma se aplica a metodos en lugar de parametros
       //del constructor.

      //EPA, EPAAAA, que pachó acá ?
      //En JAVA esta palabrita "virtual" no hace falta.
      //JAVA ofrece ocultacion implicita de metodos de clase base
      //Pero en c#, hay que ser mas preciso en este tema.
      //Por ello la palabrita "virtual" es necesaria.
      //De lo contrario, el ejemplo de implementacion de estas
      //selecciones dinamicas no funcionaria, dado que en cada caso
      //siempre se estara llamando al metodo "llamame()" de la 
      //clase base (clase A) y no a los metodos de cada Objeto "hijo"
      // (clase B o clase C).
      public virtual void llamame() 
      {
        Console.WriteLine("Llama a \"llamame\" dentro de A");
      }

      //En JAVA esto funcionaria:
      //public void llamame()
      //{
      //    Console.WriteLine("Llama a \"llamame\" dentro de A");
      //}

   }

   public class B : A
   {
     public override void llamame()
     {
      Console.WriteLine("Llama a \"llamame\" dentro de B");
     }

     //En JAVA esto funcionaria:
     //public void llamame()
     //{
     //    Console.WriteLine("Llama a \"llamame\" dentro de B");
     //}
   }

   public class C : A
   {
      public override void llamame() 
      {
       Console.WriteLine("Llama a \"llamame\" dentro de C");
      }

      //En JAVA esto funcionaria:
      //public void llamame()
      //{
      //    Console.WriteLine("Llama a \"llamame\" dentro de B");
      //}
   }
}
