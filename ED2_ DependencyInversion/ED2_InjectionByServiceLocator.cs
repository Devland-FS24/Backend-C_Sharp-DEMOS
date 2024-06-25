using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2__DependencyInversion
{
    //External Service Locator
    //Se sugiere repasar el concepto del modificador "static", 
    //en el documento ANALISIS INTERFACE, previo a este.
    static class LocateAddress
    {

        public static IAddress getAddress()
        {

            IAddress direccionAfiliado = new Address("Las Heras 1534", 48589632);

            return direccionAfiliado;
        }

    }


    public class Customer
    {
        //Field
        private IAddress _address;


        //Object injected through Service Locator
        //Se inyecta la dependencia a traves del propio constructor por defecto
        //, por medio de la utilizacion de un metodo estatico que devuelve
        //un objeto del tipo IAddress.

        //Notese que esta forma de inyeccion, evita la necesidad de que la
        //clase Customer implemente la interface IAddress 
        // y/o que deba agregar una sobrecarga
        // al constructor de la clase.

        public Customer()
        {
            //Se delega a la clase LocateAddress, la instanciacion del objeto
            // Address 
            _address = LocateAddress.getAddress();
        }


        //.......
        //....... Rest of the class

    } // End of Class
}
