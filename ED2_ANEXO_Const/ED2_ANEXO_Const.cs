using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Const
{
    // Page 66
    class MyClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public MyClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    //EJEMPLO 2
    public class MathOperations  
    {  
       public const double PI = 22.0 / 7.0;  
    }  

}
