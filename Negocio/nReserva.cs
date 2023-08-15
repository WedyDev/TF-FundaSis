using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;
namespace Negocio
{
    public class nReserva
    {
        dReserva dReserva = new dReserva();
      
        public string Insertar(string Bus,string Paradero_ini,string Paradero_fi,string Horario,int Asiento,decimal Pasaje )
        {
            eReserva obj = new eReserva
            {
                bus=Bus,
                paradero_inicial=Paradero_ini,
                paradero_final=Paradero_fi,
                horario=Horario,
                asiento=Asiento,
                pasaje=Pasaje
            };
            return dReserva.Insertar(obj);
        }

        public List<eReserva> reporte22()
        {
            return dReserva.reporte2();
        }
        public List<eReserva> Buscar_bus(string aux)
        {
            return dReserva.reporte2().FindAll(x=>x.bus==aux);
        }
        public string Limpiar()
        {
            return dReserva.Limpiar();
        }
    }
}
