using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ClaseBase
{
    public class Caja
    {
          //Page 13 
        public double ancho;
        public double alto;
        public double prof;

        public Caja(Caja ob)
        {
            ancho = ob.ancho; 
            alto = ob.alto; 
            prof = ob.prof;
        }

        public Caja()
        {
            ancho = alto = prof = -1;
        }

        public Caja(double w, double h, double d)
        {
            ancho = w; 
            alto = h; 
            prof = d;
        }

        public Caja(double longi)
        {
            ancho = alto = prof = longi;
        }

        public double volumen()
        {
            return ancho * alto * prof;
        }
    }

    public class CajaPeso:Caja 
    {
        //FROM ED2_SobreCarga
       public double peso;

       //First Constructor
       //public CajaPeso(double w, double h, double d, double p)
       //{
       //    ancho = w;
       //    alto = h;
       //    prof = d;
       //    peso = p;
       //}

       //Exposicion de parametros en el constructor
       //Es otra forma de declarar el mismo constructor escrito en First Constructor
       //Por esa razon no pueden convivir. Se declara una forma o la otra, pero no ambas.
    
        //Second Constructor
       public CajaPeso(double w, double h, double d, double p)
       {
           ancho = w; 
           alto = h; 
           prof = d; 
           peso = p;
       }

       //Ocultacion de parametros en el constructor
       //Es otra forma de declarar el mismo constructor escrito en First Constructor
       //Por esa razon no pueden convivir. Se declara una forma o la otra, pero no ambas.
       //Esta forma puede convivir con Second Constructor, pero no con las otras.
      
       //Alternative for First Constructor
       //public CajaPeso(CajaPeso ob)
       //{
       //    ancho = ob.ancho; 
       //    alto = ob.alto; 
       //    prof = ob.prof;
       //    peso = ob.peso;
       //}

         //    Objetivo del método "base":
         // * Acceso al constructor de la clase base.
         // * Acceso a un miembro de la clase base ocultado
         //   en la clase derivada.


       //Acceso al constructor de la clase base con parametros sin encapsular
       //Es otra forma de declarar el mismo constructor escrito en First Constructor
       //Por esa razon no pueden convivir. Se declara una forma o la otra, pero no ambas.
       //Tampoco funcionara simultaneamente con Second Constructor.
   
       //Another alternative for First Constructor
       //public CajaPeso(double w, double h, double d, double p): base(w, h, d)
       //{
             //Notese la diferencia con JAVA que utiliza la palabra clave "super", 
             //para acceder a miembros de la clase base o "super" clase.
       //    //Ocultacion de la implementacion de la clase base, para esta sobrecarga.
             //Solo se indica la implementacion para la variable "peso".
       //    peso = p;
       //}

     //Acceso al constructor de la clase base con parametros encapsulados
     //Esta forma de declarar el constructor no tiene conflicto con First Constructor,
     //ni con Second Constructor.
     //Dado que utiliza como parametro el objeto completo de CajaPeso, sin precuparle
     //los detalles del mismo

        //Third Constructor
       public CajaPeso(CajaPeso ob): base(ob)
       {
           //Ocultacion de la implementacion de la clase base, para esta sobrecarga
           // del constructor
           //Definir esta implementacion de la variable "peso", es mandatorio, para
           //que pueda compilar el proyecto, con esta sobrecarga de constructor.
           peso = ob.peso;
       }
  }


}
