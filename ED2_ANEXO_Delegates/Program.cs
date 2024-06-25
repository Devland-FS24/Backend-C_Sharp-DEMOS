using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //string message = "Hello World";

            //// Instanciar el Tipo Delegado
            //ED2_ANEXO_Delegates.Del handler = ED2_ANEXO_Delegates.DelegateMethod;

            //// Invocar el metodo delegado.
            //handler(message);

            //// Delegar la tarea de imprimir string en pantalla al metodo
            //// handler
            //NonStaticClass obj = new NonStaticClass();

            //obj.MethodWithCallback(1, 2, handler);

            //MethodClass obj2 = new MethodClass();
            //ED2_ANEXO_Delegates.Del d1 = obj2.Method1;
            //ED2_ANEXO_Delegates.Del d2 = obj2.Method2;
            //ED2_ANEXO_Delegates.Del d3 = ED2_ANEXO_Delegates.DelegateMethod;

         

            ////Both types of assignment are valid.
            //ED2_ANEXO_Delegates.Del allMethodsDelegate = d1 + d2;
            //allMethodsDelegate += d3;

            //// At this point allMethodsDelegate contains three methods 
            //// in its invocation list: Method1, Method2, and DelegateMethod.

            //// The original three delegates, d1, d2, and d3, remain unchanged.
            //// When allMethodsDelegate is invoked, all three methods 
            //// are called in order. 

            ////remove Method1
            //allMethodsDelegate -= d1;

            //// copy AllMethodsDelegate while removing d2
            //ED2_ANEXO_Delegates.Del oneMethodDelegate = allMethodsDelegate - d2;

            ////To find the number of methods in a delegate's invocation list
            //int invocationCount = d1.GetInvocationList().GetLength(0);

            //// Instantiate the delegate using the method as a parameter:
            //NamedMethods nm = new NamedMethods();
            //       Del2 dlg = nm.DoWork;
            //       dlg(36);

            //EXAMPLE 1:
          // MathClass m = new MathClass();

          //         // Delegate instantiation using "MultiplyNumbers"
          // Del3 d = m.MultiplyNumbers;

          //         // Invoke the delegate object.
          //Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
          //         for (int i = 1; i <= 5; i++)
          //         {
          //             d(i, 2);
          //         }

            //EXAMPLE 2
            //SampleClass sc = new SampleClass();

            //// Map the delegate to the instance method:
            //Del4 d = sc.InstanceMethod;
            //     d();

            //// Map the delegate mapped to instance method, to the static method:
            //d = SampleClass.StaticMethod;
            //d();

            //ANONYMOUS METHODS
            
            // Instantiate the delegate using an anonymous method
            //DelAM d5 = delegate(int k)
            //{
            //    Console.WriteLine("There are {0} reasons to be anonymous today",k);
            //};

            //d5(6);

            //MORALEJA:
            // By using anonymous methods, you reduce the coding overhead 
            // in instantiating delegates by eliminating the need to create 
            // a separate method.

            // A good example would be when launching a new thread. 
            // This class creates a thread and also contains the code 
            // that the thread executes, without the need for creating 
            // an additional method for the delegate.

 //System.Threading.Thread t1 = new System.Threading.Thread(delegate()
 //                                                         {
 //                                                           Console.Write("Hello, ");
 //                                                           Console.WriteLine("World!");
 //                                                         });
 //                        t1.Start();

            // For example, in the following code segment, n is an outer 
            // variable:
              //           int n = 0;
                        
            //Declaracion del Metodo Anonimo
            //DelOV d8 = delegate()
            //{
            //    Console.WriteLine("Copy #:{0}", ++n);
            //};

            ////Invocacion del metodo anonimo
            //d8();

            //Dos formas de instanciar un delegado:

            // Instatiate the delegate type using an anonymous method:
            //Printer p = delegate(string j)
            //{
            //    System.Console.WriteLine(j);
            //};

            //// Results from the anonymous delegate call:
            //p("The delegate using the anonymous method is called.");

            //// The delegate instantiation using a named method "DoWork":
            //p = new Printer(TestClass.DoWork);

            //// Results from the old style delegate call:
            //p("The delegate using the named method is called.");

            //COVARIANCE

            //HandlerMethod handler1 = ProgramX.FirstHandler;

            //// Covariance allows this delegate.
            //HandlerMethod handler2 = ProgramX.SecondHandler;
            //handler1();
            //handler2();

            //MULTICAST DELEGATES
            //Del9 a, b, c, d;

            //// Create the delegate object "a" that references 
            //// the method Hello:
            //a = TestClass2.Hello;

            //// Create the delegate object "b" that references 
            //// the method Goodbye:
            //b = TestClass2.Goodbye;

            //// The two delegates, a and b, are composed to form c: 
            //c = a + b;

            //// Remove a from the composed delegate, leaving d, 
            //// which calls only the method Goodbye:
            //d = c - a;

            //Console.WriteLine("Invoking delegate a:");
            //a("A");
            //Console.WriteLine("Invoking delegate b:");
            //b("B");
            //Console.WriteLine("Invoking delegate c:");
            //c("C");
            //Console.WriteLine("Invoking delegate d:");
            //d("D");


            //How to: Declare, Instantiate, and Use a Delegate

            //GenericDelegates gd = new GenericDelegates();
            //Del<int> d1 = new Del<int>(gd.Notify);


            ////In C# 2.0, it is also possible to declare a delegate 
            ////using this simplified syntax:

            //Del<int> d2 = gd.Notify;


            //BookStore TEST
            // Execution starts here.
            //BookDB bookDB = new BookDB();

            //// Initialize the database with some books:
            //TestBookDB.AddBooks(bookDB);

            //// Print all the titles of paperbacks:
            //Console.WriteLine("Paperback Book Titles:");

            //// Create a new delegate object associated with the static 
            //// method Test.PrintTitle:
            //bookDB.ProcessPaperbackBooks(TestBookDB.PrintTitle);
            ////ESO ES EQUIVALENTE AL EJEMPLO DE NAMED METHODS
            ////    Del2 dlg = nm.DoWork;
            ////ANALOGAMENTE:
            ////ProcessBookDelegate processBook = TestBookDB.PrintTitle;

            //// Get the average price of a paperback by using
            //// a PriceTotaller object:
            //PriceTotaller totaller = new PriceTotaller();

            //// Create a new delegate object associated with the nonstatic 
            //// method AddBookToTotal on the object totaller:
            //bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);
            ////ANALOGAMENTE:
            ////ProcessBookDelegate processBook = totaller.AddBookToTotal;

            //Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice());

            //END BookStore TEST

            //GENERIC DELEGATES PART 2
            //private static void DoWork(float[] items) { }

            //public static void TestStack()
            //{
            //    Stack<float> s = new Stack<float>();
            //    Stack<float>.StackDelegate d = DoWork;
                
            //}

           //STACK 2
            
            Stack<double> s = new Stack<double>();
            SampleClass o = new SampleClass();
            s.stackEvent += o.HandleStackChange;
            s.StackIt();
            //HandleStackChange PROVEE UNA IMPLEMENTACION AL
            //METODO TIPO EVENTO-DELEGADO stackEvent
            //DE FORMA DINAMICA.
            //USA EL CONCEPTO DE NAMED METHODS, PERO APLICADO A EVENTOS
            //(?) CONFIRMAR ESTA HIPOTESIS, LUEGO DE ANALIZAR EVENTOS.
        }
    }
}
