using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_GRASP_ProtectedVariations
{
    //Delegation Pattern

   //SIMPLE EXAMPLE

    public class RealPrinter
    {
        // the "delegate"
        public void print()
        {
            Console.WriteLine("something");
        }
    }

    public class Printer
    {
        // the "delegator"
        RealPrinter p = new RealPrinter(); // create the delegate 
        public void print()
        {
            //Send and order to the delegate
            p.print(); // delegation
        }
    }

    //END OF SIMPLE EXAMPLE
    //****************************************

    //COMPLEX EXAMPLE
   //public interface I 
   //{
   //  void f();
   //  void g();
   //}
 
   // public class A:I 
   // {
   //   public void f() 
   //   {
   //       Console.WriteLine("A: doing f()"); 
   //   }
      
   //   public void g() 
   //   { 
   //       Console.WriteLine("A: doing g()"); 
   //   }
   // }
 
   // public class B:I 
   // {
   //    public void f() 
   //    { 
   //        Console.WriteLine("B: doing f()"); 
   //    }

   //    public void g() 
   //    { 
   //        Console.WriteLine("B: doing g()"); 
   //    }
   // }
 
   // public class C:I 
   // {
   //   // delegation
   //    I i = new A();

   //     //AQUI EL TIPO DINAMICO ES A
 
   //    public void f() 
   //    {
   //        //Ejecuta implementacion de f en  clase A
   //        i.f(); 
   //    }

   //    public void g() 
   //    {
   //        //Ejecuta implementacion de g en  clase A
   //        i.g(); 
   //    }
 
   //    // normal attributes
   //    public void toA() 
   //    { 
   //        //Redefine i al tipo dinamico A
   //        i = new A(); 
   //    }

   //    public void toB() 
   //    {
   //        //Redefine i al tipo dinamico B
   //        i = new B(); 
   //    }
   // }
 
    //END OF COMPLEX EXAMPLE
}
