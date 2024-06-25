using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Internal
{
    // Page 57

    // Assembly2.cs
    // compile with: csc /target:library Assembly1.cs
    public class BaseClass2
    {

        //En este ejemplo, utilice los mismos archivos que utilizo en el ejemplo1,
        //y cambie el nivel de accesibilidad o de "visibilidad" de la clase
        //BaseClass2 para que sea "public". 
        //Ademas, cambie el nivel de accesibilidad del miembro IntM para que sea
        //"internal".
      
        internal static int intM = 0;
    }

}
