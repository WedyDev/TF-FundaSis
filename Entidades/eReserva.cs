using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eReserva
    {
       
        public int id_bus              { get; set; }
        public string bus              { get; set; }
        public string paradero_final   { get; set; }
        public string paradero_inicial { get; set; }
        public string horario          { get; set; }
        public int asiento             { get; set; }
        public decimal pasaje          { get; set; }
    }
}
