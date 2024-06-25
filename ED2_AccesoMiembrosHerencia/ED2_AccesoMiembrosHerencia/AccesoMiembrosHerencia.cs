using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_AccesoMiembrosHerencia
{
  public class A 
  {
      //Page 6
    public int i; // por defecto es pública
    private int j; // privada para A
    public void establecerij(int x, int y) 
    {
        //ojo, j es privada.
      i = x;
      j = y;
    }
  }

  public class B:A 
  {
      //B es una subclase de A.
    public int total;
    public void sum() 
    {
        //ups..No se puede acceder a j !!. Esto no compila viejo.

        //Descomentar esta linea para que NO funcione !
        //total = i + j;

        //Traduccion del error: la variable "j" es inaccesible debido a su nivel de
        //proteccion. 
        //Se sugiere repasar el documento ANALISIS INTERFACE, para recordar
        //cuales eran los niveles de acceso, de acuerdo a la definicion de
        //cada modificador.

        //Que pasa si comento esa linea, eh ?
        //No tiene sentido el metodo de "sum"
        //Solo para darte cuenta que no podes usar private
        //de esta forma...jijiji
    }
  }
}
