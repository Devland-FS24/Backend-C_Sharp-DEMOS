using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_OrdenEjecucionConstructores
{
     // Page 16
   public class A 
   {
      public A() 
      {
        Console.WriteLine("En el constructor de A.");
      }
   }

   public class B:A 
   {
      public B() 
      {
        Console.WriteLine("En el constructor de B.");
      }
   }

   public class C:B 
   {
      public C() 
      {
        Console.WriteLine("En el constructor de C.");
      }
   }
}
