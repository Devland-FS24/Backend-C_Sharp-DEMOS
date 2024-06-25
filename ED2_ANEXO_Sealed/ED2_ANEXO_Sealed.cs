using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Sealed
{
    // Page 59
  
    // En el siguiente ejemplo, Z hereda de Y pero Z no puede sobreescribir
    // la funcion virtual F que esta declarada en X y es sellada en Y.
    
    class X
    {
        //Funcion virtual F
        protected virtual void F() 
        {     
            Console.WriteLine("X.F"); 
        }

        protected virtual void F2() 
        { 
          Console.WriteLine("X.F2"); 
        }
    }

    class Y : X
    {
        //Funcion virtual F, ahora sellada en Y.
        //No se podra heredar este metodo en clases derivadas de Y.
        sealed protected override void F() 
        { 
            Console.WriteLine("Y.F"); 
        }

        protected override void F2() 
        { 
            Console.WriteLine("X.F3"); 
        }
    }

    class Z : Y
    {
        //Descomentar el metodo para visualizar el error al compilar:
        //protected override void F() 
        //{ 
        //    Console.WriteLine("C.F"); 
        //}
        //TRADUCCION DEL ERROR:
        //NO SE PUEDE SOBREESCRIBIR EL METODO HEREDADO Y.F() DEBIDO A QUE
        //ESTA SELLADO.

        // Sobreescribir F2 esta permitido por su nivel de acceso.
        protected override void F2() 
        { 
            Console.WriteLine("Z.F2"); 
        }
    }

}
