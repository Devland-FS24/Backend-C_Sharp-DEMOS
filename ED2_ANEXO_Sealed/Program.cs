using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Sealed
{
    // Page 59
    class Program
    {
        static void Main(string[] args)
        {
            //Comentar lineas 16 a 19 para probar el comportamiento de las
            //clases X,Y,Z.

            SealedClass sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;

            SealedClass sc2 = new SealedClass();
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
            Console.WriteLine("NUEVA INSTANCIA x = {0}, y = {1}", sc2.x, sc2.y);
            // Salida: x = 110, y = 150

            //Comentar lineas 16 a 19 para probar el comportamiento de las
            //clases X,Y,Z.
        }
    }
}
