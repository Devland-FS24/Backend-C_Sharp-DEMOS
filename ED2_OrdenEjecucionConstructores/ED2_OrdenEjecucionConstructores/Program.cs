using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_OrdenEjecucionConstructores
{
    class Program
    {
           // Page 16
        static void Main(string[] args)
        {
            //Siempre comenzara buscando en la clase Padre o 
            //clase base y luego continuara hacia abajo hasta encontrar
            //el constructor de si mismo, el cual ejecutara en ultimo lugar.
            
            C c = new C();

            //Este ejemplo tiene como proposito presentar el concepto de "Jerarquias"
            //entre clase base y clases derivadas.
            //Notese la relacion con el ejemplo de Clase Base en Page 13.
            //Se hace enfasis en la relacion TOP-DOWN entre las clases.
            //Volviendo a los temas detallados en el documento 
            //de ANALISIS PRINCIPIO SOLID, la idea centra del ejemplo Page 16,
            //es indicar la responsabilidad que se asigna a cada clase, basicamente.
        }
    }
}
