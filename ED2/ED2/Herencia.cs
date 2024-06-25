using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2
{
  public class A 
  {
      //Page 3
    public int i, j;

    public void mostrarij() 
    {
       Console.WriteLine("i y j: " + i + " " + j);
    }
  }

  public class B:A 
  {
    public int k;

    public void mostrark() 
    {
     Console.WriteLine("k: " + k);
    }

    public void sum() 
    {
      Console.WriteLine("i+j+k: " + i + j + k);
      Console.WriteLine("Sum Result is: {0}",i + j + k);
    }
 }
}
