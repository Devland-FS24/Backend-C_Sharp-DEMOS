using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ED2_InterfacePila;


namespace ED2_ReferenciaInterfacePilaDinamica
{
    // Page 45
    // Page 46
  public class PilaDin : IntPila
  {
      private int[] pila;
      private int n;
      
      public PilaDin(int talla) 
      {
        pila = new int[talla];
        n = -1;
      }

      public void poner(int elem) 
      {
        if(n==pila.Length-1) 
        {
          int[] temp = new int[pila.Length*2];
          for(int i=0; i<pila.Length; i++)
            temp[i] = pila[i];
          pila = temp;
        }

        pila[++n] = elem;
      }

      public int quitar() 
      {
        if(n<0) 
        {
          Console.WriteLine("La pila está vacía");
          return 0;
        } 
        else
          return pila[n--];
      }

      public void PoneteLasPilas()
      {
          Console.WriteLine("Este metodo es propio de la clase. No es una implementacion de alguna interface.");
      }
    }
}


