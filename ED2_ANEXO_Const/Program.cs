using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Const
{
    class Program
    {
        // Page 66
        static void Main(string[] args)
        {
            //Comentar este bloque de codigo, para probar Ejemplo 2
            //MyClass mC = new MyClass(11, 22);
            //Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
            //Console.WriteLine("c1 = {0}, c2 = {1}", MyClass.c1, MyClass.c2);
       
            // EJEMPLO 2:

            //La variable constante "PI" declarada en la clase 
            //MathOperations puede ser accesada utilizando el operador 
            //punto '.', con el nombre de la clase MathOperations, de la 
            //siguiente manera:
         
            //Descomentar para probar Ejemplo 2
            Console.WriteLine("PI= {0}", MathOperations.PI);  
  
            //Resultado:
            // PI = 3.14285714285714  

            //MORALEJA:
            //BASICAMENTE, EL MODIFICADOR READONLY SE PUEDE USAR PARA CLASES
            //ESTRUCTURAS E INTERFACES, MIENTRAS QUE EL CONST, NO.
            //La otra diferencia importante es que el campo definido
            //con const, es constante en tiempo de compilacion, mientras
            //que el readonly puede ser usado por constantes en tiempo de 
            //ejecucion.
            //Por ultimo, un campo readonly puede tomar diferentes valores
            //iniciales, dependiendo del constructor que sea llamado.
            //Mientras que campo const solo puede tener un unico valor
            //que se mantendra en toda la vida del programa.

        }
    }
}
