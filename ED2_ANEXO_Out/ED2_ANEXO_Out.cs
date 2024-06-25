using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Out
{
    // Page 62

    //Aunque las palabras clave 'ref' y 'out' ocasionan diferentes
    //comportamientos en tiempo de ejecucion, estos no son considerados
    //parte de la firma del metodo en tiempo de compilacion. Por lo tanto,
    //los metodos no pueden sobrecargarse si la unica diferencia esta 
    //en que un metodo toma un argumento 'ref' y el otro toma un argumento
    //'out'. El siguiente codigo por ejemplo, no compilara:

    class CS0663_Example
    {
        // Error de compilacion CS0663: "No se puede definir metodos
        // sobrecargados que difieran solamente en 'ref' y 'out'."

        //Descomentar el metodo para compilar y ver el error:
        //public void SampleMethod(out int i) 
        //{
        //}
        
        public void SampleMethod(ref int i) 
        {
        }
    }

    //La Sobrecarga puede ser realizada, sin embargo, si uno de los metodos
    //toma un argumento 'ref' o 'out' y el otro no usa ninguno, como este:

    class OutOverloadExample
    {
        public void SampleMethod(int i) 
        {
 
        }

        public void SampleMethod(out int i) 
        { 
            i = 5; 
        }
    }

    //Las propiedades no son variables. Estas son metodos y por tanto
    //no pueden ser pasados como parametros 'out'.
}
