using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2__DependencyInversion
{
    //DESCOMENTAR PARA PROBAR Y COMENTAR LAS OTRAS VERSIONES DE LA CLASE
    //CUSTOMER
    //public class Customer
    //{

    //    //--> Problema 1: Referencias. El campo _address depende de la clase
    //    // Address:

    //    private Address _address;


    //    public Customer()
    //    {
    //        //--> Problema 2: Dependiente de clases concretas
    //        _address = new Address();

    //        Console.WriteLine("Ha nacido un nuevo problema de dependencia.");
            
    //    }

    //    //.......
    //    //.......Rest of the class

    //} // End of Class

    //LO QUE PERSIGUE LA INYECCION DE DEPENDENCIA, ES QUE LA CLASE QUE USA
    //LA REFERENCIA A OTRA CLASE, NO SEA LA RESPONSABLE DE CREAR ESA REFERENCIA
    //SINO, MAS BIEN QUE SEA UN TERCERO (CLASE O INTERFACE) QUE SE ENCARGUE
    //DE ROMPER LA DEPENDENCIA ENTRE ELLAS, MEDIANTE UNA ABSTRACCION
    //(CLASE ABSTRACTA O ENLACE DINAMICO TIENEN MUCHO SENTIDO)
}
