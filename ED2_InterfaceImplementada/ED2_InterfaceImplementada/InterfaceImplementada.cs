using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_InterfaceImplementada
{
    // Page 41
    // Page 40
  public interface Callback 
  {
     void callback(int param);
  }

    //Para probar AFIRMACION 2 Page 39
  public interface Callback2
  {
      void callback(int param);
  }

  //Implementación de la interfaz
  public class Cliente:Callback, Callback2
  {
    public void callback(int p) 
    {
      Console.WriteLine("callback llamado con " + p);
    }
  }
}
