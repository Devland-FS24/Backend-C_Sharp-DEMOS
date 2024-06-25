using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ED2_ANEXO_Delegates
{
   
    public static class ED2_ANEXO_Delegates
    {

        //Declarar un Tipo Delegado
        public delegate void Del(string message);

        //Crear un metodo con la firma del Tipo Delegado.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
                               
    }

    public class NonStaticClass
    {
        //Crear un metodo que recibe como parametro el Tipo Delegado y lo invoca.
        public void MethodWithCallback(int param1, int param2, ED2_ANEXO_Delegates.Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }

    public class MethodClass
    {
        //Metodos con la misma firma del Tipo Delegado
        public void Method1(string message) { }
        public void Method2(string message) { }

  
        //Comparacion de Tipos Delegados
        public delegate void Delegate1();
        public delegate void Delegate2();
        // Declare a delegate:
       
        static void method(Delegate1 d, Delegate2 e, System.Delegate f)
        {
            // Compile-time error.
            //Console.WriteLine(d == e);

            // OK at compile-time. False if the run-time type of f 
            //is not the same as that of d.
            Console.WriteLine(d == f);
        }

    }

    // Declare a delegate:
    public delegate void Del2(int x);
    public class NamedMethods
    {
        // Define a named method:
        public void DoWork(int k) 
        {
            Console.WriteLine("Soy un Metodo Nombrado!!");
        }
    }

    //EXAMPLE 1
    // Declare a delegate
    delegate void Del3(int i, double j);

    public class MathClass
    {
       // Declare the associated method.
        public void MultiplyNumbers(int m, double n)
        {
            Console.Write(m * n + " ");
        }
    }

    // Notice that both the delegate, Del, and the associated method, 
    // MultiplyNumbers, have the same signature 


    // Example 2
    // In the following example, one delegate is mapped to both static 
    // and instance methods and returns specific information from each.
    // Declare a delegate
    public delegate void Del4();

    //public class SampleClass
    //{
    //    public void InstanceMethod()
    //    {
    //        Console.WriteLine("A message from the instance method.");
    //    }

    //    public static void StaticMethod()
    //    {
    //        Console.WriteLine("A message from the static method.");
    //    }
    //}

     //ANONYMOUS METHODS
    public delegate void DelAM(int x);

    //TEST FOR OUTER VARIABLE
    public delegate void DelOV();

     public class AnonymousMethod
     { 
        // Create a handler for a click event
        //Button button1 = new Button();
               
        //button1.Click += delegate(Object o, System.EventArgs e)
        //                 { 
        //                    MessageBox.Show; 
        //                  };

         //or

           
     }

     // The following example demonstrates the two ways of instantiating 
     // a delegate:

     public delegate void Printer(string s);

     public class TestClass
     {
         // The method associated with the named delegate:
         public static void DoWork(string k)
         {
             Console.WriteLine(k);
         }
        
     }

    //Example 1 (Covariance)

    //This example demonstrates how delegates can be used with 
    //methods that have return types that are derived from the 
    //return type in the delegate signature. The data type 
    //returned by SecondHandler is of type Dogs, which derives 
    //from the Mammals type that is defined in the delegate.

    public class Mammals
    {
    }

    public class Dogs : Mammals
    {
    }

    // Define the delegate.
    public delegate Mammals HandlerMethod();
    public class ProgramX
    {
        public static Mammals FirstHandler()
        {
            return null;
        }

        public static Dogs SecondHandler()
        {
            return null;
        }       
    }

    //MULTICAST DELEGATES
    public delegate void Del9(string s);

    public class TestClass2
    {
        public static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
        }

        public static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
        }
   }

    //How to: Declare, Instantiate, and Use a Delegate
    public delegate void Del<T>(T item);
    public class GenericDelegates
    {
        public void Notify(int i) { }
    }

    //****************************************

    //BookStore Definition
    // Describes a book in the book list:
    public struct Book
    {
        public string Title;        // Title of the book.
        public string Author;       // Author of the book.
        public decimal Price;       // Price of the book.
        public bool Paperback;      // Is it paperback?

        public Book(string title, string author,decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            Paperback = paperBack;
        }
    }

    // Declare a delegate type for processing a book:
    public delegate void ProcessBookDelegate(Book book);

    // Maintains a book database.
    public class BookDB
    {
        // List of all books in the database:
        ArrayList list = new ArrayList();

        // Add a book to the database:
        public void AddBook(string title, string author,decimal price, bool paperBack)
        {
            list.Add(new Book(title, author, price, paperBack));
        }

        // Call a passed-in delegate on each paperback book to process it: 
        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            foreach (Book b in list)
            {
                if (b.Paperback)
                    // Calling the delegate:
                    processBook(b);
            }
        }
    }

    // Using the Bookstore classes:



    // Class to total and average prices of books:
    public class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }

        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }

    // Class to test the book database:
    public static class TestBookDB
    {
        // Print the title of the book.
        public static void PrintTitle(Book b)
        {
            Console.WriteLine("   {0}", b.Title);
        }

        // Initialize the book database with some test books:
        public static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language","Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia","Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless","Scott Adams", 12.00m, true);
        }

      
    }

    //****************************************

    //GENERIC DELEGATES PART 2:

    //public class Stack<T>
    //{
    //    T[] items;
    //    int index;

    //    public delegate void StackDelegate(T[] items);
    //}

    //STACK 2
    //Generic delegates are especially useful in defining 
    //events based on the typical design pattern(OBSERVER)
    //because the sender argument can be strongly typed and no longer has
    //to be cast to and from Object. 

    delegate void StackEventHandler<T, U>(T sender, U eventArgs);

    class Stack<T>
    {
        public class StackEventArgs : System.EventArgs { }
        public event StackEventHandler<Stack<T>, StackEventArgs> stackEvent;

        //Method to test stackEvent invocation
        public virtual void StackIt()
        {
            StackEventArgs kk = new Stack<T>.StackEventArgs();
            OnStackChanged(kk);
        
        }

        protected virtual void OnStackChanged(StackEventArgs a)
        {
            stackEvent(this, a);
        }
    }

    class SampleClass
    {
        public void HandleStackChange<T>(Stack<T> stack, Stack<T>.StackEventArgs args) 
        {
            Console.WriteLine("I am a Stack being handled");
        }
    }



}
