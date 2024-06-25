using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_GRASP_HighCohesion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Descomentar y comentar el resto para probar
            //Low coupling and high cohesion in C++ applications By 
            //By Issam Lahlali
            //CodeProject
            //Bloque Presentacion del problema

            //CDataProcessor obj = new CDataProcessor();
            //obj.GetDataFromFile();
            //obj.ProcessData("Hello I am a string :)");
           
            //The CDataProcessor class has many responsibilities, so we can’t
            //easily reuse the algorithm in other applications:
            // * High coupling: the processing is high coupled 
            //   with a console and also with a data provider.

            //Fin codigo ejemplo Presentacion del problema

            //Bloque Solucion 1 con Alta Cohesion:
            //CFileProvider obj = new CFileProvider();
            //              obj.GetDataFromFile();

            //CDataProcessing prcss = new CDataProcessing();
            //prcss.ProcessData("Hello I am a string :)");

            //So each class has its own responsibility. The advantages of this 
            // design are:
            // * Easy to understand classes.
            // * Easy to maintain.
            // * Easy to reuse classes in other applications.

            //Fin Bloque Solucion 1




            //Bloque Solucion 2 with Low Coupling:

            IDataProvider obj = new CFileProvider();
                          obj.GetDataFromImp();

            IDataProcessor prcss = new CDataProcessing();
                           prcss.ProcessData("Hello I am a string");

            // Fin Bloque Solucion 2 with Low Coupling

        }
    }
}
