using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ClaseAbstracta
{
    // Page 31
  public abstract class A 
  {
      //Metodo abstracto
      public abstract void llamame();

      //Metodo implementado
      public void llamametambien() 
      {
        Console.WriteLine("Llamame Tambien: Este es un método concreto dentro de la clase A.");
      }

      public virtual void gritame()
      {

          Console.WriteLine("Gritame: Este es un metodo virtual en la clase A.");
      
      }
  }

  public class B : A
  {
      public override void llamame()
      {
          Console.WriteLine("Llamame: Implementación de llamame en clase B");
          //base.llamametambien();
          
      }

      public override void gritame()
      {
          base.gritame();
          Console.Write("Gritame implementado: Implementacion de metodo virtual en clase B.");
      }
  }

  public abstract class C : A
  {
      public abstract void nollames();

      public override void llamame()
      {
          nollames();
          Console.WriteLine("Clase abstracta puede heredar de otra abstracta jijiji");
      }
  }

  public class D : C
  {
      public override void nollames()
      {
          
      }
  }

    // NOTESE: QUE LAS CLASES A Y C, NO PUEDEN INSTANCIAR UN OBJETO POR SER
    //DE NATURALEZA ABSTRACTA.
    //Sin EMBARGO, ES POSIBLE QUE UN OBJETO INSTANCIADO POR UNA CLASE CONCRETA
    //QUE HEREDE DE UNA CLASE ABSTRACTA, PUEDA INVOCAR UN 
    //"METODO NO ABSTRACTO O CONCRETO", DE LA MENCIONADA CLASE ABSTRACTA.
    //SIEMPRE Y CUANDO EL METODO TENGA UN MODIFICADOR QUE LE DE VISIBILIDAD
    //O ACCESIBILIDAD AL CODIGO QUE LO INVOQUE. EN ESTE CASO, EL
    //METODO LLAMAMETAMBIEN, ES "PUBLIC".

}
