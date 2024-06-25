using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary1
{

    // Page 58
    public class Class1
    {
        //Metodo Protected Internal
        protected internal void ProInt()
        {
           //EN LA MISMA DLL O POR CUALQUIER CLASE DERIVADA, EN OTRA DLL
        }

        //Metodo Protected
        protected void Pro()
        {
              //UNICAMENTE EN LA MISMA CLASE, ESTRUCTURA O EN 
              //UNA CLASE DERIVADA.
        }


        //Metodo Internal
        internal void Inte()
        {
             //EN LA MISMA DLL, EN EL MISMO ARCHIVO,  
             //PERO NO DESDE OTRA DLL O DESDE OTRO ARCHIVO.
        }
    }


    public class Class3 : Class1
    {
        public Class3()
        {
            Console.WriteLine("class3");
            Inte(); // ESTA EN EL MISMO ARCHIVO. OK
            Pro();  //ESTA EN UNA CLASE DERIVADA DESDE DONDE SE DEFINIO.OK
            ProInt(); //ESTA EN LA MISMA DLL CLASS1.DLL. ADEMAS DERIVA DE LA 
                      //CLASE EN QUE ESTA DEFINIDO.OK
        }
    }


    public class class4
    {
        public static void Main()
        {
            Class1 c3 = new Class1();
            c3.ProInt();//ESTA EN LA MISMA DLL CLASS1.DLL.OK
                        //ES INTERNAL, SI SE VE LA DLL CLASS1.DLL, COMO UN TODO.
                        //NO ES PROTECTED, PORQUE NO ESTA EN UNA CLASE DERIVADA.
                        //AUN CUANDO SE ENCUENTRA EN LA MISMA DLL.OK

            c3.Inte();//ESTA EN EL MISMO ARCHIVO. OK
                      //ES INTERNAL, SI SE VE LA DLL CLASS1.DLL, COMO UN TODO.OK

            //Descomentar esta linea para visualizar la naturaleza del error
            //Compilar con: csc /target:library Class1.cs
            //c3.Pro();
            //TRADUCCION DEL ERROR:
            //El metodo Class1.Pro() es inaccesible debido a 
            //su nivel de proteccion
            //EL METODO ES INVOCADO EN UNA CLASE QUE NO DERIVA DE CLASS1. ERROR.

        }


    }

}



