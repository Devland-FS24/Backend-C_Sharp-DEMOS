using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Sealed
{
    //Page 59
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

     //En el ejemplo anterior, podría intentar heredar de la 
     //clase sealed utilizando la siguiente instrucción:


     //Descomentar para visualizar el error al compilar.
     // class MyDerivedC: SealedClass 
     // {
     // } 
     // Error

     //El resultado es un mensaje de error: 
     //'MyDerivedC' no puede derivar del tipo sellado 'SealedClass'.

}
