using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_ReadOnly
{
    // Page 65
    class Program
    {
        static void Main(string[] args)
        {

            MyClass p1 = new MyClass(11, 21, 32);   // OK
            Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
            MyClass p2 = new MyClass();
            p2.x = 55;   // OK
            
            //Descomentar para ver el error:
            //p2.y = 66;
            Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z);


            //Resultado:
            //p1: x=11, y=21, z=32
            //p2: x=55, y=25, z=24

        }

        //En el ejemplo anterior, si escribe una sentencia como esta:
        //p2.y = 66;        // Error

        //obtendra el mensaje de error del compilador:

        //A un campo readonly no se le puede asignar un valor, excepto en
        //la declaracion del campo o en un constructor.
        
        //el cual es el mismo error que obtiene cuando intenta asignar un 
        //valor a una constante.

        //NOTESE: La palabra clave readonly es  distinta a la palabra clave
        //const. Un campo const puede inicializarse unicamente en la 
        //declaracion del campo. Un campo readonly puede inicializarse
        //ya sea en la declaracion o en un constructor. Por lo tanto, los
        //campos readonly pueden tener diferentes valores dependiendo del
        //constructor utilizado. 
        //Ademas, mientras que un campo const es una constante en tiempo
        //de compilacion, el campo readonly puede se utilizado por 
        //constantes en tiempo de ejecucion, como en el siguiente ejemplo:

       // public static readonly uint l1 = (uint) DateTime.Now.Ticks;
       
       //Se declara un campo readonly 'l1', al cual se le asigna, 
       //en la misma declaracion, la cantidad de ticks de la fecha actual,
       //al momento de realizar la asignacion.
        
    }
}
