using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ReferenciaInterfaceEnlaceDinamico
{
    // Page 42
    class Program
    {
        static void Main(string[] args)
        {
            //Comentar todo el bloque para probar AFIRMACION 4
            Callback c = new Cliente();
            OtroCliente oc = new OtroCliente();

            //Implementacion de Cliente
            c.callback(42);
            c = oc;

            //Implementacion de OtroCliente
            c.callback(42);

            //MORALEJA: LA IMPLEMENTACION DINAMICA DE INTERFACES
            //PROVEE UNA PODEROSA HERRAMIENTA A LA HORA DE PENSAR
            //EN ARQUITECTURAS QUE EXPLOTEN LOS PRINCIPIOS SOLID.
            //ES UNA PODEROSA FORMA DE USAR POLIMORFISMO
            //Y DE APLICAR LOS CONCEPTOS DE ABSTRACCION PARA LOGRARLO.

            //NOTESE:
            //QUE LA AFIRMACION 4 LLEVA A DECLARAR
            //abstract AL METODO getAverage DE LA INTERFACE,
            //COMO MINIMO ESFUERZO PARA NO TENER QUE IMPLEMENTARLO EN 
            //LA CLASE. SIN EMBARGO, SE PRODUCE UNA DUPLICACION DE 
            //DECLARACION DEL METODO getAverage, LO CUAL PUEDE VOLVERSE
            //ENGORROSO EN EL CASO DE SER MUCHOS METODOS.
            
            //ESTO PUEDE INDICARSE COMO UN EFECTO NO DESEADO O PEQUEÑA
            //DESVENTAJA DEL LENGUAJE C SHARP. DADO QUE EL LENGUAJE
            //JAVA NO EXIGE LA RE-DECLARACION DE METODOS CON MODIFICAOR
            //abstract, COMO MINIMO PARA ACEPTAR LA IMPLEMENTACION DE 
            //INTERFACES POR PARTE DE CLASES ABSTRACTAS.
        }
    }
}
