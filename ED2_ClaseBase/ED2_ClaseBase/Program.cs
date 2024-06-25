using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ClaseBase
{
    class Program
    {
        static void Main(string[] args)
        {
               //Page 13
             //No me equivoque al nombrar a este ejemplo Page 13.
             //Sirve como guia directa, para analizar las diferencias
             //y similitudes con el ejemplo de Page 10
             Caja caja;

             //Notese el numero de argumentos(parametros), tanto en Caja, como en
             //CajaPeso.
             CajaPeso cajap = new CajaPeso(3, 5, 7, 8.37);
             double vol = cajap.volumen();

             Console.WriteLine("El volumen de cajap es " + vol);
             Console.WriteLine("El peso de cajap es " + cajap.peso);
             Console.WriteLine();

            //             ¡Importante!:
            //A una variable de la superclase se le puede
            //asignar una referencia a cualquier subclase
            //derivada de dicha superclase.

             caja = cajap;
             
             vol = caja.volumen();
             Console.WriteLine("El volumen de caja es " + vol);
             Console.WriteLine("Caja no tiene peso.");
            //Pero eso no significa que variables propias de la
            //clase derivada puedan ser utilizadas por la clase
            //base. En este caso, la siguiente linea no funciona:
             
            //Console.WriteLine("El peso de caja es " + caja.peso);

            //Moraleja: Todos estos analisis y reflexiones, acerca de los ejemplos
            //citados, son para darnos una idea del concepto central en la definicion de
            //HERENCIA: Un objeto de una clase derivada "tiene al menos" los mismos
            //miembros de la clase base. Por ello un objeto de la clase base "NO ES IGUAL"
            //a un objeto de la clase derivada.
            //De aqui tambien sale el concepto de HERENCIA, como solucion al problema
            //de extender un sistema con un conjunto de clases ya existente, sin tener
            //que volver a escribir o redefinir codigo existente en forma masiva, dentro
            //del sistema.

            //Si CajaPeso fuera la clase base, seria posible acceder a la variable "peso"
            //desde la clase derivada. Pero a nivel "Buenas Practicas", eso de asignar
            //a cada clase las responsabilidades necesarias y suficientes que 
            //debe cumplir, suena a "SINGLE RESPONSIBILITY", verdad ?
            //Si no te acordas, te sugiero repasar el documento
            //ANALISIS PRINCIPIO SOLID
        }
    }
}
