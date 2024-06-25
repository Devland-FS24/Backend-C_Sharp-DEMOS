using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_InterfaceConstantes
{
    // Page 47
    public interface ConstsCompartidas
    {
        //Descomentar y tratar de compilar para ver el error
        //public int NO = 0;
        //public int SI = 1;
        //public int PUEDESER = 2;
        //public int TARDE = 3;
        //public int PRONTO = 4;
        //public int NUNCA = 5;

        //ESTO ES UNA PROPIEDAD SIN IMPLEMENTAR
         int LUEGO
        {
              get;
            //Descomentar la siguiente linea. Compilar y ver
            //el error:
            //set;
        }

        //MORALEJA: AUNQUE JAVA ACEPTA CAMPOS CONSTANTE EN LA ACTUALIDAD,
        //EL LENGUAJE C# NO LOS ACEPTA Y LENGUAJE JAVA ESTA EMPEZANDO
        //A ABANDONAR ESA PRACTICA.
        //ESTO ES POR EL MISMO CONCEPTO DE INTERFACE.
        //ESTAN PENSADAS PARA QUE SEAN UN CONTRATO
        //QUE CUALQUIER CLASE QUE DESEE USARLA, DEBA IMPLEMENTAR
        //OBLIGATORIAMENTE SUS METODOS "NO IMPLEMENTADOS"
    }

    public class ConstClass : ConstsCompartidas
    {
        public const int MASTARDE = 0;

        public int LUEGO
        {
            get 
            {
                return MASTARDE; 
            }
        }

        public void CuandoHacerAlgo()
        {
            Console.WriteLine("Lo que es urgente debe hacerse en {0} minutos", LUEGO);
        }
    }
}
