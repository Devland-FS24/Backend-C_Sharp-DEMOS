using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SobreCarga
{
    class Program
    {
        // Page 10
        static void Main(string[] args)
        {
            CajaPeso cajap = new CajaPeso(3, 5, 7, 8.37);

            //Notese que ningun constructor de Caja, contempla la variable "peso"
            Caja caja;

            double vol;
            vol = cajap.volumen();

            Console.WriteLine("El volumen de cajap es " + vol);
            Console.WriteLine("El peso de cajap es " + cajap.peso);
            Console.WriteLine();

            caja = cajap;
            
            vol = caja.volumen();

            Console.WriteLine("El volumen de caja es " + vol);

            //Descomentar esta linea, para que el proyecto NO compile:
            //Console.WriteLine("El peso de caja es " + caja.peso);

            //Traduccion del error:
            //La clase Caja no contiene una definicion para la variable "peso", 
            //ni ningun metodo extendido que se llame "peso" y que acepte como primer
            //parametro el objeto "caja"

            //Moraleja: Se menciona que 
            // " A una variable de la superclase se le puede asignar una referencia a 
            //   cualquier subclase derivada de dicha superclase." 
            //Sin embargo, en este ejemplo se verifica claramente que la inversa 
            //no es cierta:
            // " A una variable de la subclase, NO se le puede asignar una referencia
            //   a la superclase."
            //En este caso, se intenta acceder a la variable "peso", propia de la clase
            //derivada, desde un objeto creado a partir de la superclase o clase base,
            //la cual no tiene definida una variable "peso".
            //Sin embargo, es posible acceder a las otras tres variables "heredadas".
            

            //Este es un ejemplo acerca del cual se debe meditar. Una posible
            //solucion o forma correcta de manejar esta forma de acceder a variables
            //entre clase base y clase derivada, se muestra y debate en el proximo
            //ejemplo de Page 13.
          
             
        }
    }
}
