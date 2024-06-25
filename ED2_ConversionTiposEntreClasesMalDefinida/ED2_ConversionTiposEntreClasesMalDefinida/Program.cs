using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ConversionTiposEntreClasesMalDefinida
{
    class Program
    {
        // Page 25
        static void Main(string[] args)
        {
            A a = new A();
            B b;

           //No se puede convertir a en b, porque B no esta heredando de A
            //Descomentar la siguiente linea para que el proyecto no compile.
           //b = (B)a;
        }
    }
}
