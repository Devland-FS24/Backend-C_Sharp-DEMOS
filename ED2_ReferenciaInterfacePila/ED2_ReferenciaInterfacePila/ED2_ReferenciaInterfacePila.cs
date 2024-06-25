using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ED2_InterfacePila;

namespace ED2_ReferenciaInterfacePila
{
        // Page 44
        // Page 46
    public class PilaFija:IntPila
    {
     
      private int[] pila;
      private int n;
      
      public PilaFija(int talla) 
      {
        pila = new int[talla];
        n = -1;
      }

      public void poner(int elem) 
      {
        if(n==pila.Length-1)
          Console.WriteLine("La pila está llena");
        else
          pila[++n] = elem;
      }

      public int quitar() 
      {
        if(n<0) 
        {
          Console.WriteLine("La pila está vacía");
          return 0;
        } else
          return pila[n--];
      }
    }
}
