using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_AccesoMiembrosOcultados
{
    //Page 15
   public class A 
   {
     public int i;
   }

   public class B:A 
   {
      public int i; //esta i oculta a la i(heredada) de A
                    //Esto es muy importante...
       //Reflexionar con que principio SOLID se relaciona.
       //Recordar cual era el peligro de romper la "Relacion Polimorfica"
       //entre clase base y clase heredada. Con que principio S.O.L.I.D, se relacionaba?
       //Si no te acordas, te sugiero repasar el documento ANALISIS PRINCIPIO SOLID.

       //Que pasa si le pongo new ?
       //public new int i;
       //El resultado es el mismo !! Solo que el compilador no te
       //tira un warning.

       //Constructor sobrecargado
      public B(int a, int b)
      {
        base.i = a;  // i de A
             i = b;  // i de B
      }

      public void mostrar() 
      {
        Console.WriteLine("i de la superclase: " + base.i);
        Console.WriteLine("i de la subclase: " + i);
      }
}
}
