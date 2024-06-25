using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_SeleccionDinamicaConInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new C();
            int x = 23;
            b.Add(23);        
            b.Add(x);    
            (b as A).Add(x);  
            b.Add(x);       
        }
    }
}
