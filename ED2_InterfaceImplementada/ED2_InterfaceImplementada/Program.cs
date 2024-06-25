using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_InterfaceImplementada
{
    // Page 41
    // Page 40
    class Program
    {
        // Referencias a interfaces y enlace dinámico
        // con interfaces
        static void Main(string[] args)
        {
            Callback c = new Cliente();
            c.callback(42);

            Callback2 X = new Cliente();
            X.callback(137);


            Cliente t = new Cliente();
            t.callback(15);
        }
    }
}
