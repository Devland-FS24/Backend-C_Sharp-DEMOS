using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_GRASP_HighCohesion
{
    //Low coupling and high cohesion in C++ applications By 
    //By Issam Lahlali
    //CodeProject

    //The problem of Low Cohesion and High Coupling
    //Presentacion del problema
    //public class CDataProcessor 
    //{
    //    public string GetDataFromFile()
    //    { 
    //       string st ="ff";

    //       return st;
    //    }

    //    public void ProcessData(string dataString)
    //    { 
    //        // Process string
    //        PrintResult(dataString);
           
    //    }

    //    public void PrintResult(string dataToPrint)
    //    {
    //        //High coupling with a console
    //        Console.WriteLine("Information: {0}", dataToPrint);
    //    }
    //}
    //Fin Presentacion del problema


    //Solution 1 with High Cohesion
    //public class CFileProvider
    //{
    //    public string GetDataFromFile()
    //    {
    //        string st = "ff";

    //        return st;
    //    }
    //}
    
    //public class CDataProcessing
    //{
    //    public void ProcessData(string dataString)
    //    {
    //        // Process string
    //        CResultReporting.PrintResult(dataString);

    //    }
    //}

    //public static class CResultReporting 
    //{
    //    public static void PrintResult(string dataToPrint)
    //    {
    //        //High coupling with a console
    //        Console.WriteLine("Information: {0}", dataToPrint);
    //    }
    //}
    // End of Solution 1



    //Solution 2 with Low Coupling:

    // What happens if data exists in a database rather than a file? 
    // In our last design, our application is high coupled with a 
    // file provider.

    //For that, using NVI(Non-Virtual-Interface), also known as
    //Template Method Pattern, can be good solution. 

    //This pattern is more useful than using only abstract classes 
    //because it's possible to define a pre- and post-condition. 
    //It's a useful object-oriented programming technique, 
    //particularly at development time. 
    //Pre- and post-conditions 
    //ensure that invariants of a class hierarchy (and in general, 
    //an abstraction) are not violated at designated points during 
    //execution of a program.

    public interface IDataProvider
    {
         string GetData();
         string GetDataFromImp();
    }

    //The same design can be used for CDataProcessing and CReportResult.
    public interface IDataProcessor
    {
         void ProcessData(string dataString);
    }

    public interface IReportResult
    {
         void PrintResult(string dataToPrint);
    }

    //Now, you have to implement each Interface to its appropiate responsibility

    public class CFileProvider:IDataProvider
    {
        public string GetData()
        {
            string st = "File from another Source";
            return st;
        }

        public string GetDataFromImp()
        {
            string implementation = GetData(); ;
            return implementation;
        }
    }

    public class CDataProcessing:IDataProcessor
    {
        public void ProcessData(string dataString)
        {
            // Process string
            IReportResult rr = new CResultReportingOnScreen();
                          rr.PrintResult(dataString);
        }
    }

    public class CResultReportingOnScreen:IReportResult
    {
        public void PrintResult(string dataToPrint)
        {
            Console.WriteLine("Information: {0}", dataToPrint);
        }
    }

    //Optional for test purpose:
    public class CResultReportingToPrinter:IReportResult
    {
        public void PrintResult(string dataToPrint)
        {

            //Enviar dataToPrint por impresora por defecto (local)
        }
    
    }
    // End of Solution 2




    // Solution 3 with Factory and Controller classes: 

    // Factory Class:

    // In the latest design, the creation of concrete instances 
    // of IDataProvider, IDataProcessing, and IReportResult are created 
    // by the main method. A better approach is to assign this responsibility 
    // to a factory class, so a logic to instantiate a family of instances 
    // needed, is isolated.

    //Controller Class:

    // The orchestration between all classes is implemented in the main
    // method. It's better to assign this responsibility to a 
    // Controller class, so we can use it in other applications.

    // The controller needs three classes to interact with them, 
    // so the question is how do we bind instances to the controller.

    //In C#, two solutions can be used:
    // * Add a method named 
    //   Bind<IDataProviderPtr,IDataProcesingPtr,IReportResultPtr>().To<Impl>().InSingletonScope();
   

    // * Use a template so the controller will be instantiated like that:

    //  CController<CFileProvider,CDataProcessor,CConsoleReport> 

    // The difference between the two solutions is that for the first one, 
    // each Data Provider must inherit from IDataProvider, and for the 
    // second one, CFileProvider only needs the method GetData(Data&) 
    // even if it’s inherited from another class than IDataProvider.

    //There are many discussions between C# gurus about using OOP or 
    //templates. 

    public class CController
    { 
      //Al estudiar MVC, podras imaginar como resolver este punto.
    }

    public class CFactory
    { 
       //Al estudiar Factory, podras imaginar como resolver este punto.
    }
}
