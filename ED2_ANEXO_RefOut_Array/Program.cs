using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_RefOut_Array
{
    // Page 63
    // Page 62
    class Program
    {
        //Como todos los parametros 'out', un parametro out de un 
        //tipo array(vector)
        //debe ser asignado antes de ser usado; quiero decir, 
        //debe ser asignado con un valor final, por parte del codigo que 
        //lo implementa(metodo o callee, en este caso). Por ejemplo: 

        static void TestMethod1(out int[] arr)
        {
            arr = new int[10];   // asignacion final de arr
        }


        //Un parametro 'ref' de un tipo array puede ser modificado como
        //resultado de la invocacion. Por ejemplo, se puede asignar 
        //valor 'null' al array o se puede asignar a un array diferente.
        //Por ejemplo:

        static void TestMethod2(ref int[] arr)
        {
            arr = new int[10];   // arr inicializado a un array diferente
        }

        //Los siguientes dos ejemplos demuestran la diferencia entre
        //'out' y 'ref' cuando se utilizan en el pasaje de arrays a metodos.
        
        //En este ejemplo, el array theArray es declarado en el
        //codigo que lo invoca, el programa principal o Main en este caso.
        //Luego es inicializado en el metodo FillArray.
        //Despues, los elementos del array son retornados al programa 
        //principal o Main y mostrados en pantalla.
        
        //Comentar para probar TestRef
        //TestOut
        //static void FillArray(out int[] arr)
        //{
        //    // Inicializo el array:
        //    arr = new int[5] { 1, 2, 3, 4, 5 };
        //}

        //En este ejemplo, el array theArray es inicializado en el 
        //codigo que lo invoca(metodo Main o programa principal) y pasado
        //al metodo FillArray por medio del uso del parametro 'ref'. Algunos
        //elementos del array son actualizados en el metodo FillArray. 
        //Luego, los elementos del array son retornados al programa
        //principal(caller) y mostrados en pantalla.

        //TestRef
        //Comentar TestOut para probarlo
        //Descomentar esta version de FillArray para probar TestRef:
        static void FillArray(ref int[] arr)
        {
            // Crear el array a pedido: 
            if (arr == null)
            {
                arr = new int[10];
            }
            // Llenar el array:
            arr[0] = 1111;
            arr[4] = 5555;
        }


        static void Main(string[] args)
        {
            //Descomentar para probar TestOut
            //int[] theArray; // No se requiere inicializacion

            ////Automaticamente se asigna null al array, en tiempo de 
            ////ejecucion.


            //// Paso el array al metodo que usa 'out':
            //FillArray(out theArray);

            //// Muestro los elementos del array:
            //Console.WriteLine("Array elements are:");
            //for (int i = 0; i < theArray.Length; i++)
            //{
            //    Console.Write(theArray[i] + " ");
            //}

            //// Mantengo la consola abierta en modo 'debug'
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            //Resultado:
            //Array elements are:
            //1 2 3 4 5       
 

            //Descomentar para probar la version TestRef de FillArray
            //Comentar el bloque anterior, para probar TestRef:

            // Inicializo el array(necesario para ref): 
            int[] theArray = { 1, 2, 3, 4, 5 };

            // Paso el array utilizando ref:
            FillArray(ref theArray);

            // Muestro el array actualizado:
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.Write(theArray[i] + " ");
            }

            // Mantengo la consola abierta en modo 'debug'
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            //Resultado:
            //Array elements are:
            //1111 2 3 4 5555
        }
    }
}
