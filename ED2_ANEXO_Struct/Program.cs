using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Struct
{
    // Page 60

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize:   
            Point myPoint = new Point();
            Point yourPoint = new Point(10, 10);

            // Display results:
            Console.Write("My Point:   ");
            Console.WriteLine("x = {0}, y = {1}", myPoint.x, myPoint.y);
            Console.Write("Your Point: ");
            Console.WriteLine("x = {0}, y = {1}", yourPoint.x, yourPoint.y);


            //NOTESE: AUN CUANDO LOS VALORES PARA LAS COORDENADAS DE
            // 'MY POINT' NO FUERON SETEADOS O INICIALIZADOS, EL TIPO
            //STRUCT SE ENCARGO DE INVOCAR AL CONSTRUCTOR POR DEFECTO
            // AL UTILIZAR 'new Point()' Y ESTE, SE ENCARGO DE INICIALIZAR
            //LOS VALORES DE X e Y (X=0; Y=0)
        }
    }
}
