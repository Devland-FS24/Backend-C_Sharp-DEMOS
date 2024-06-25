using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_SeleccionDinamicaConInterfaces
{
    //EJEMPLO DE STACK OVERFLOW:
    
    public interface A
    {
        void Add(int entity);
    }

    public interface B : A 
    {
    }

    public class C : B
    {
        public void Add(int entity)
        {
            Console.WriteLine(entity);
        }
    }

 }
