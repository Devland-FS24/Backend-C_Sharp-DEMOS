using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ReferenciaInterfaceEnlaceDinamico
{
    // Page 42
    //Declaración de la interfaz
    public interface Callback 
    {
       void callback(int param);

      //Metodo para probar AFIRMACION 4 de Page 41(en documento 'sad')
      //Una clase que incluya una interfaz y no implemente todos los 
      //métodos definidos por la interfaz ha de ser declarada como 
      //abstracta.
      //Descomentar para probar  AFIRMACION 4
       //void getAverage(int total, int partials);
    }
    
    //Implementación de la interfaz
    //Descomentar para probar AFIRMACION 4
    //public abstract class Cliente:Callback 
    public class Cliente:Callback 
    {
      public void callback(int p) 
      {
        Console.WriteLine("callback llamado con " + p);
      }

      //Descomentar para probar AFIRMACION 4
      //public abstract void getAverage(int total, int partials);
    }

    //Comentar para probar Metodo para probar AFIRMACION 4
    public class OtroCliente : Callback
    {
        public void callback(int p)
        {
            Console.WriteLine("Otra versión de " + "callback");
            Console.WriteLine("El cuadrado de p es " + p.ToString() + "*" + p.ToString()+" = " + (p * p));
        }
    }
}
