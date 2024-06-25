using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SeleccionDinamicaFiguras
{
       // Page 23

    //Clase base.
     public class Figura 
     {
         //Variables de inicializacion
      public double dim1;
      public double dim2;
      
         //Constructor sobrecargado
      public Figura(double a, double b) 
      {

          //a y b son "valores" de inicializacion del objeto Figura

            //Implementacion del constructor de la clase base
          dim1 = a; 
          dim2 = b;
      }
         //Unico metodo
      public virtual double area() 
      {
        Console.WriteLine("Area de Figura no def.");
        return 0;
      }
    }
    
    public class Rectangulo:Figura 
    {
        //Constructor sobrecargado que sobreescribe los valores de los parametros
        //asginados a la clase base. En caso que se hubiera creado un objeto Figura
        //y luego de hubiera creado un objeto Rectangulo, entonces los parametros
        //de inicializacion del objeto Figura, son reemplazados por los nuevos valores
        //suministrados para la creacion del objeto Rectangulo.
      public Rectangulo(double a, double b): base(a, b)
      {
          //Notese que al no existir una implementacion aqui, el compilador
          //procedera a ejecutar la implementacion del constructor de la clase base.
      }

      // Si no usara virtual, ni override, este metodo nunca seria llamado.
      // Siempre seria llamado el metodo de la clase base y la Figura,
      // nunca seria definida.
      public override double area() 
      {
        Console.WriteLine("Dentro de area Rectang.");
        return dim1 * dim2;
      }
    }

    public class Triangulo:Figura 
    {
        //El proposito y naturaleza de este constructor es igual al de la clase
        //Rectangulo
      public Triangulo(double a, double b):base(a,b) 
      { 
           
      }

      // Si no usara virtual, ni override, este metodo nunca seria llamado.
      // Siempre seria llamado el metodo de la clase base y la Figura,
      // nunca seria definida.
      public override double area() 
      {
        Console.WriteLine("Dentro de area Triang.");
        return dim1 * dim2 / 2;
      }
    }
}
