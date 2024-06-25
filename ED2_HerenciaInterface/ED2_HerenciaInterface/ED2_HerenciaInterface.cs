using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_HerenciaInterface
{
     // Page 48
    public interface A 
    {
       void meth1();
       void meth2();
    }

    public interface B:A 
    {
      void meth3();
    }

    public class Miclase : B 
    {
      public void meth1() {
        Console.WriteLine("Implementa meth1");
      }
      public void meth2() {
        Console.WriteLine("Implementa meth2");
      }
      public void meth3() {
       Console.WriteLine("Implementa meth3");
      }
    }
}
