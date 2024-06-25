using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary2
{
    //NOTESE QUE CLASS5, SE ENCUENTRA EN UNA DLL DIFERENTE DE CLASS1.
    //EN ESTE CASO, CLASS5 SE DEFINE EN LA DLL CLASS2.DLL.

    // Page 58

    public class Class5 : ClassLibrary1.Class1
    {
        //1)Comentar el metodo public static void Main() de Class4
        //2)Compilar con:
        //csc /target:library Class2.cs /reference:Class1.dll
        //public static void Main()
        //{
        //    Class5 c5 = new Class5();
        //    c5.ProInt(); //EL METODO INVOCADO ESTA EN UNA CLASE BASE(CLASS1),
        //                   QUE SE ENCUENTRA EN OTRA DLL(CLASS1.DLL). 
                           //ES PROTECTED, SI SE VE LA DLL CLASS1.DLL, COMO UN
                           //TODO. COMO SI LA DLL, FUERA UNA CLASE.
                           //NO ES INTERNAL, PORQUE EL METODO ES INVOCADO
                           //DESDE AFUERA DE LA DLL CLASS1.DLL.OK
                           
        //    c5.Pro();    //ESTA EN UNA CLASE DERIVADA, ES PROTECTED.OK

        //3)Descomentar para visualizar el error
        //    c5.Inte();//"NO ES INTERNAL", POR NO ESTAR
                        //EN LA MISMA DLL. 
                        //DEBIDO A SU NIVEL DE PROTECCION, C5 NO ENCUENTRA
                        //EL METODO INTE(). ERROR.
        //}
    }
}

