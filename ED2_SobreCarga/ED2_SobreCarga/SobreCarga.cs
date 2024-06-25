using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SobreCarga
{
    public class Caja
    {
          // Page 7
        public double ancho;
        public double alto;
        public double prof;


        public Caja(Caja ob)
        {
            ancho = ob.ancho; 
            alto = ob.alto; 
            prof = ob.prof;
        }

        //Constructor por defecto
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

        //Unico metodo de la clase
        public double volumen()
        {
            return ancho * alto * prof;
        }
    }

    public class CajaPeso:Caja 
    {
      public double peso;
      public CajaPeso(double w,double h,double d,double p) 
      {
        ancho = w;
        alto = h;
        prof = d;
        peso = p;
      }
    }
}
