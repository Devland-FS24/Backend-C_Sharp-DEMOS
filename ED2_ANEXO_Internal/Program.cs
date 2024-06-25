using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Internal
{

    // Page 57

    // Assembly1_a.cs
    // compile with: /reference:Assembly1.dll

    class Program
    {
        static void Main(string[] args)
        {

            //Un uso comun para el modificador "internal" es en el desarrollo
            //basado en componentes, dado que permite a un grupo de componentes
            //cooperar de forma privada sin quedar expuestos al resto del codigo de
            //la aplicacion. Por ejemplo, un framework para la construccion de
            //interfaces de usuario podria proveer clases para Controles y Formularios
            //que cooperan utilizando miembros con visibilidad "internal".
            //Dado que estos miembros son "internal", no quedan accesibles para el
            //codigo que utiliza el framework.

            //Es un error referenciar a un tipo o miembro con visibilidad
            //o modificador de acceso "internal" desde afuera de la DLL dentro
            //de la cual fue definido.

            //Nota:

            // Un metodo "internal virtual" puede ser sobreescrito en algunos
            //lenguajes, tal como el de tipo textual Intermedio de Microsoft (MSIL)
            //utilizando el comando "Ilasm.exe", aunque no se pueda sobreescribir
            //utilizando c#

            // Assembly1_a.cs
            // compilar con: csc Program.cs /reference:Assembly1.dll

            //Linea 1
            BaseClass1 myBase = new BaseClass1();   //ERROR CS0122

            //TRADUCCION DEL ERROR: NO COMPILA.
            //BaseClass1 es inaccesible debido a su nivel de proteccion.

            //NOTESE: AQUI NO SE PRODUCE EL ERROR PORQUE TODOS
            //LOS EJEMPLOS ESTAN DEFINIDOS EN LA MISMA DLL.


            //Descomentar para probar esta porcion de codigo
            //Comentar Linea 1
            // Assembly2_a.cs
            // compile with: csc Program.cs /reference:Assembly2.dll
            //BaseClass2 myBase = new BaseClass2();   // Ok.
            //BaseClass2.intM = 444;    // CS0117


            //Como resultado, si bien puede instanciar la clase BaseClass2, 
            //no puede tener acceso al miembro "interno". 


            //MUY IMPORTANTE !!
            //SI COMPILAS EL PROYECTO ED2_ANEXO_INTERNAL, VAS A VER QUE
            //COMPILA Y QUE NO TE DA NINGUN ERROR.
            //ESTO SE DEBE A QUE POR DEFECTO, LOS PROYECTOS DE CONSOLA
            //COMO ESTE, ESTAN "SETEADOS" PARA OBTENER UN ARCHIVO 
            //EJECUTABLE '.EXE', EN LUGAR DE UNA DLL.

            //SIN EMBARGO, ES POSIBLE SETEAR EL PROYECTO PARA QUE COMPILE
            //Y GENERE ARCHIVOS '.DLL', EN LUGAR DE EXE. PARA ELLO TE SUGIERO
            //QUE INVESTIGUES LAS DIRECTIVAS DE POSTCOMPILACION.
            //CONSULTAR ANALISIS INTERFACE, para una breve introduccion al manejo
            //de ambiente de desarrollo de Visual Studio 2008. 

            //MORALEJA:
            //TAL COMO SE OBSERVA CLARAMENTE EN LOS EJEMPLOS CON CLASS1
            //Y CLASS2, EL CONCEPTO PARA PROTECTED INTERNAL ES
            //EXCLUYENTE. EL MIEMBRO INVOCADO SERA PROTECTED O INTERNAL
            //YA SEA QUE SE TRATE DESDE UNA CLASE O DESDE UNA DLL

        }
    }
}
