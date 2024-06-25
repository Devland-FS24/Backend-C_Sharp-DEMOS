using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnlaceDinamico
{
    class Base
    {
        virtual public void metodoVirtual()
        {
            Console.WriteLine("Base.metodoVirtual()");
        }
        public void noVirtual()
        {
            Console.WriteLine("Base.noVirtual()");
        }
    }

    class Derivada : Base
    {
        //Method encapsulation using Inheritance
        override public void metodoVirtual()
        {
            //Hiding method through base modifier.
            base.metodoVirtual();
            Console.WriteLine("Derivada.metodoVirtual()");
        }

        //Name Hiding using new as modifier method
        new public void noVirtual()
        {
            Console.WriteLine("Derivada.noVirtual()");
        }


    }

}
