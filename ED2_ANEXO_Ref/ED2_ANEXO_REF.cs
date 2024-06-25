using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Ref
{
    // Page 63

    //Los miembros de una clase no pueden tener firmas que difieran
    //unicamente en los modificadores 'ref' y 'out'. Un error de compilacion
    //ocurre si la unica diferencia entre dos miembros de un tipo esta en
    //que uno de ellos tiene un parametro 'ref' y el otro tiene un 
    //parametro 'out'. El siguiente codigo, por ejemplo, no compila:


    class CS0663_Example
    {
        // Error de compilacion CS0663: "No se puede sobrecargar
        // metodos que se diferencien unicamente en 'ref' y 'out'".

        //Descomentar y compilar para visualizar el error.
        //public void SampleMethod(out int i) 
        //{ 

        //}

        public void SampleMethod(ref int i) 
        { 

        }
    }

    //Sin embargo, la sobrecarga puede realizarse cuando un metodo tiene
    //un parametro 'ref' o 'out' y el otro tiene un parametro valor, 
    //tal como se ve en el siguiente ejemplo:

    class RefOverloadExample
    {
        //Metodo original
        public void SampleMethod(int i) 
        { 
        
        }

        //Metodo sobrecargado
        public void SampleMethod(ref int i) 
        { 
        
        }
    }

    //En otras situaciones que requieran coincidencia de firmas, tales
    //como 'ocultamiento' o 'sobreescritura', 'ref' y 'out' son parte de la
    //firma y no coinciden entre ellos.
    //Las propiedades no son variables. Estas son metodos y por tanto
    //no pueden ser pasados como parametros 'ref'.


    //RefExample2
    class Product
    {
        public Product(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }

        public string ItemName { get; set; }
        public int ItemID { get; set; }
    }

}
