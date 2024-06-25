using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Static
{
    // Page 61
    class Program
    {
        static void Main(string[] args)
        {
            //Modo de utilizar los metodos estaticos.
            //NOTESE QUE LA CLASE MyStaticClass NO ES ESTATICA.
            //SIN EMBARGO, EL CONSTRUCTOR LO ES.

            //Las clases estaticas se utilizan a menudo como servicios
            //y se pueden utilizar ,por ejemplo, de esta forma:
            MyStaticClass.SetMyData();

            //MORALEJA: SE VE QUE NO HACE FALTA INSTANCIAR LA CLASE, 
            //AUN CUANDO ESTA NO SEA DECLARADA COMO STATIC.

        }
    }
}
