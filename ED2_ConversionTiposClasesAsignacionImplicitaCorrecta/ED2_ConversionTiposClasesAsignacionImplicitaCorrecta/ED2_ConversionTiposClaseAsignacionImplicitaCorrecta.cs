using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ConversionTiposClasesAsignacionImplicitaCorrecta
{
         // Page 28
      public class A 
      { 
        public int a;

        public virtual void Sumar()
        { 
           //Aqui tu codigo
        }
      }

      public class B:A 
      {
        public int b;

        public override void Sumar()
        {
            //base.Sumar();
        }

      }
}
