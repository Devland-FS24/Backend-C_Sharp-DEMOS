using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_InterfaceConstantes
{
     // Page 47
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            ConstClass tareas = new ConstClass();

            if (test != 0)
                Console.WriteLine("No tardes mas de {0} en hacerlo", test);
            else
                tareas.CuandoHacerAlgo();

            //MORALEJA:
            //NO SE DEBEN DEFINIR CAMPOS CONSTANTES EN UNA INTERFACE
            //DADO QUE LAS PROPIEDADES SON UNA CLASE ESPECIAL DE METODOS,
            //POR ELLO NO DEJAN DE SERLO.
            //DEBE ASEGURARSE DE IMPLEMENTAR CORRECTAMENTE UNA PROPIEDAD,
            //DECLARADA EN UNA INTERFACE.
        }
    }
}
