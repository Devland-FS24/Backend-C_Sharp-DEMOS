using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ClaseAbstractaFiguras
{
    // Page 32
    public abstract class Figura 
    {
      public double dim1;
      public double dim2;
      public Figura(double a, double b) 
      {
         dim1 = a; 
         dim2 = b;
      }

      public abstract double area();
    }

    public class Rectangulo:Figura 
    {
     public Rectangulo(double a, double b):base(a,b) 
     { 
  
     }

     public override double area() 
     {
        Console.WriteLine("Dentro de area Rectang.");
        return dim1 * dim2;
     }

    }

    public class Triangulo:Figura 
    {
      public Triangulo(double a, double b):base(a,b) 
      { 
    
      }

      public override double area() 
      {
        Console.WriteLine("Dentro de area Triang.");
        return dim1 * dim2 / 2;
      }
    }
}
