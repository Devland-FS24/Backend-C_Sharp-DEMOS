using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEFY_AgesBetweenLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using(TEST1Entities1 context = new TEST1Entities1())
            {

                List<Turno> lsturnosage2 = new List<Turno>(); 
                var  lsturnosage = (from tur in context.Turnoes
                                   join ord in context.Ordens on
                                   tur.idOrden equals ord.idOrden
                                   join pac in context.Pacientes on
                                  ord.idPaciente equals pac.idPaciente
                                   where pac.Edad >= 20 && pac.Edad <= 30
                                   select new { tur }).ToList();
                lsturnosage2 = lsturnosage.Select(t => new Turno() { idOrden = t.tur.idOrden,FechaDesde=t.tur.FechaDesde,FechaHasta=t.tur.FechaHasta }).ToList();

            }

        }
    }
}
