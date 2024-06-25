using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SobreescrituraMetodo
{
   public class A {

       // Page 17
      public int i, j;
      
      public A(int a, int b) 
      {
        i = a; 
        j = b;
      }

      public void mostrar() 
      {
        Console.WriteLine("i y j: " + i + " " + j);
      }
    }

    public class B:A {
      public int k;
      public B(int a, int b, int c):base(a,b)
      {
        
        k = c;
      }

      public void mostrar() 
      {
          //Primer Linea.
        Console.WriteLine("k: " + k);

        // Si se desea acceder a la versión de la superclase del
        // metodo "mostrar()",
        // descomente las siguientes lineas:

          // Page 18

         //base.mostrar();
         //Console.WriteLine("k: " + k);

        // y comente la primer linea.

        // Aunque la sintaxis c# correcta para este metodo 
        // seria:

        // public new void mostrar(). Igual compila.

        //Aunque la advertencia del compilador es bastante clara:
        // B.mostrar() oculta al miembro heredado A.mostrar()
        //Utilice la palabra "new", si esa fue su intencion.

        // Este metodo "oculta" al metodo del "mismo nombre"
        // de la clase base. Lo cual implica que se ejecutara
        // este metodo de la clase derivada y el de la clase base
        // sera ignorado. A menos que se especifique lo contrario con 
        // base.mostrar()  o se cambie el nombre
        // del metodo de la clase derivada por otro que no entre
        // en conflicto con la clase base.

      }
    }
}
