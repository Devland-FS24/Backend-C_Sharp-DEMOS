using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_MetodoSellado
{
     // Page 34
   public class A 
   {
       //Descomentar esta linea para averiguar porque no se puede
       //especificar un constructor sellado de esta manera.
       //sealed A() { }

       //Descomentar este metodo y compilar, para visualizar el error.
       //sealed void math()
       //{
       //    Console.WriteLine("Este es un método final");
       //}
       //Explicacion del error: Solo se puede "sellar" un metodo
       //que ha sido declarado como virtual, previamente y solo a traves
       //de una operacion de sobreescritura (override)

       //NOTESE: QUE EL LENGUAJE JAVA, SI PERMITE ESTA DEFINICION DE METODO,
       //CON EL EQUIVALENTE PARA JAVA QUE ES LA PALABRA CLAVE 'final'


       //Comentar este metodo, para visualizar el error.
       public virtual void math()
       {
           //Tu codigo aqui.
       }
   }

   public class B:A 
   {
       // 'sealed', evita la sobreescritura del metodo math
      public sealed override void math()
      { 
        Console.WriteLine("Este metodo no sera heredado a otras clases.");
      }
   }

   public class C : B
   {
       //Descomentar el metodo para visualizar el error al compilar:
       //Evitar la sobreescritura 
       //public override void math()
       //{
       //    //ERROR! No se puede sobreescribir un metodo sellado.
       //    Console.WriteLine("No es correcto");
       //}
   }


    // EVitar la Herencia

    sealed class D
    {
       //. . .
    }

    //Descomentar para visualizar el error
    //class E:D 
    //{ 
    //    // ERROR! No se puede heredar del tipo sellado D.

    //}
}
