using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ED2_ANEXO_Internal;

namespace ED2_ANEXO_TestInternal
{
    class Program
    {
        static void Main(string[] args)
        {

            // Assembly1_a.cs
            // compilar con: /reference:ED2_ANEXO_Internal.dll
            //Linea 1
            BaseClass1 myBase = new BaseClass1();   // CS0122

            //NOTESE: AQUI NO SE PRODUCE EL ERROR PORQUE TODOS
            //LOS EJEMPLOS ESTAN DEFINIDOS EN LA MISMA DLL.


            //Descomentar para probar esta porcion de codigo
            //Comentar Linea 1
            // Assembly2_a.cs
            // compile with: /reference:ED2_ANEXO_Internal.dll
            //BaseClass2 myBase = new BaseClass2();   // Ok.
            //BaseClass1.intM = 444;    // CS0117

        }
    }
}
