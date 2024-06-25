using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2__DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Descomentar y probar: Inyeccion basada en Constructor,
            //                      Inyeccion basada en Getter/Setter
            //                      Inyeccion basada en Interface              
            //Comentar el resto.
            //IAddress direccionAfiliado = new Address("Las Heras 1534",48589632);

            Console.WriteLine("Probando el cliente");

            //Descomentar y probar Problema de dependencia original
            //Comentar el resto.
            //Customer cu = new Customer();


            //Descomentar y probar Inyeccion basada en Constructor
            //Comentar el resto.
            //Customer cu = new Customer(direccionAfiliado);
          
            //AQUI EL OBJETO CLIENTE "cu", SE ENCARGO DE CARGAR
            //UNA "VERSION" DINAMICA DE IADDRESS, A TRAVES DE EL
            //TIPO DINAMICO ADDRESS.
            //SI BIEN EL EJEMPLO NO HACE MAS QUE ESO. DEJA LA PUERTA ABIERTA
            //A "PARA QUE PODRIA USARSE EL OBJETO "CARGADO" EN MEMORIA
            //IMPLICITAMENTE CON LA CREACION DEL OBJETO CLIENTE??"...
            

            //Descomentar y probar Inyeccion basada en Getter/Setter
            //Comentar el resto.
            //Customer cu = new Customer();
            //cu.Address = direccionAfiliado;
            //EL EJEMPLO TERMINA AQUI.

            //ESTO ES UNA IDEA MIA.
            //PODRIA ESTAR EN OTRA PARTE DEL CODIGO, QUIZAS EN OTRA CLASE
            //O COMPONENTE.
            //Address ad = new Address();
            //ad = (Address)cu.Address;
            //Console.WriteLine("Direccion empleado: {0}",ad.Addr);
            //Console.WriteLine("Telefono empleado: {0}",ad.Pho);

            //ES MUY INTERESANTE ESTE ENCAPSULAMIENTO(??) DEL OBJETO ADDRESS

            //IMAGINAR DE QUE FORMA PUEDO EXPLOTARLO...LUEGO DE 
            //ESTUDIAR LOS PATRONES PRIORIDAD DOFACTORY 

            //Descomentar y probar Inyeccion basada en Interface
            //Comentar el resto.
            //Customer cu = new Customer();
            //cu.setAddress(direccionAfiliado);
            

            //TAL PARECE QUE SIRVE PARA CARGAR UN OBJETO Y POR EJEMPLO
            //PERSISTIRLO EN LA BD O TENERLO EN MEMORIA POR ALGUNA RAZON.
            //Dado que mi imaginacion no tiene limites, prefiero dejar el 
            //tema en el aire y seguir estudiando patrones.
            //Quizas al final tenga algun razonamiento util de para que sirve
            //esto o cual es el uso mas apropiado.
            //Consultar en los foros no es mala idea.

            //Descomentar y probar Inyeccion basada en Service Locator
            //Comentar el resto.
            Customer cu = new Customer();

            //ESTO ES PERFECTO. LA CREACION DEL OBJETO CUSTOMER, PROVOCO
            //INDIRECTAMENTE LA CREACION DEL OBJETO ADDRESS, EL CUAL
            //POR EJEMPLO PUEDE MOSTRAR EN PANTALLA LOS DATOS INGRESADOS
            //DE ADDRES(DIRECCION Y TELEFONO), EN ALGUN FORMULARIO.

            //EN REALIDAD SE DELEGO LA CREACION DE UNA IMPLEMENTACION
            // DE LA INTERFACE IADDRESS, A TRAVES DEL OBJETO ADDRESS.

            //VA A ESTAR BUENO A VER QUE CLASE DE DIAGRAMA DE CLASE
            //UML, RESPONDE A ESTOS CONCEPTOS.

            //UPDATE: ME VIENE A LA MENTE, LA POSIBILIDAD DE USAR GETTYPE
            //, QUIZAS REFLECTION (??), PARA PODER DETERMINAR
            //EN TIEMPO DE EJECUCION QUE TIPO DE OBJETO ADDRESS SE CREO.
            //POR EJEMPLO, PODRIA TENER CLASES ADDRESSOFFICE, ADDRESSHOME, ETC
            //COMO TIPOS DINAMICOS A LA HORA DE ENLAZAR DINAMICAMENTE LA 
            //INTERFACE IADDRESS...

        }
    }
}
