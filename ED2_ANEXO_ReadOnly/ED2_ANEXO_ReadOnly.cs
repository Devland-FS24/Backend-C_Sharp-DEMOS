using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_ReadOnly
{
    // Page 65
    class MyClass
    {
        public int x;
        public readonly int y = 25; // Inicializo un campo readonly
        public readonly int z;

        public MyClass()
        {
            z = 24;   // Inicializo una instancia de campo readonly
        }

        public MyClass(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }
    }
}
