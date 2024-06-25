using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ED2_InterfacePila;

namespace ED2_ReferenciaInterfacePilaDinamica
{
    // Page 45
    // Page 46
    class Program
    {
        static void Main(string[] args)
        {

          
            //Ejemplo 1
            IntPila piladinamicaInterface = new PilaDin(25);
            
            //Descomentar esta linea y compilar para ver el error:
            //Prueba para AFIRMACION 3 en Page 41:
            //piladinamicaInterface.PoneteLasPilas();
              piladinamicaInterface.poner(5); 


            //Ejemplo 2

              PilaDin pd = new PilaDin(38);
              pd.PoneteLasPilas();
              pd.quitar();

         
            //MORALEJA:
            //Mediante una variable tipo IntPila se puede
            //utilizar los métodos poner y quitar de una
            //pila fija o una pila dinámica dependiendo de a que
            //instancia se refiera la variable en un momento
            //dado.
            //GRACIAS A LA DLL DEL PROYECTO ED2_InterfacePila ES POSIBLE
            //REALIZAR IMPLEMENTACIONES DINAMICAS TANTO PARA 
            //PILA DINAMICA, COMO PARA PILA FIJA, USANDO LA 
            //MISMA INTERFACE.

            //NOTESE: QUE EL EJEMPLO CITADO PARA
            //Prueba para AFIRMACION 3 en Page 41, DEMUESTRA DE QUE FORMA
            //SE PUEDE UTILIZAR EL ENLACE DINAMICO EMPLEANDO INTERFACES.
            //EN ESTE CASO, SE INSTANCIA UNA INTERFAZ A TRAVES DE LA CLASE
            //PilaDin QUE LA ESTA IMPLEMENTANDO.
            //SOLO ES POSIBLE USAR LOS METODOS IMPLEMENTADOS DE LA INTERFACE
            //, EN ESE CASO Y NO ES POSIBLE UTILIZAR LOS METODOS PROPIOS
            //DE LA CLASE PilaDin, COMO POR EJEMPLO PoneteLasPilas()

            //ESTA PRACTICA ES BUENA A LA HORA DE PENSAR EN SEGURIDAD
            //PARA EL CASO EN QUE SE PIENSE EN PERMITIR A TERCEROS
            //EL USO DE LA INTERFACE Y/O DE OBJETOS QUE LA IMPLEMENTEN
        }
    }
}
