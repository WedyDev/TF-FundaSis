using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


using Datos;
using Entidades;
namespace Negocio
{
    public class nConductor
    {
        dConductor dconductor = new dConductor();

        public List<eConductor> ListarConductor()
        {
            return dconductor.ListarConductor();
        }

        public List<eConductor> ListarConductorBusXHorario(string bus, string horario)
        {
            return dconductor.ListarConductor().FindAll(x => x.bus == bus).FindAll(y => y.horario == horario);
        }


        public string InsertarConductor(string conductor, string bus, string ruta, string telefono, string horario)
        {
            eConductor obj = new eConductor
            {
                conductor = conductor,
                bus = bus,
                ruta = ruta,
                telefono = telefono,
                horario = horario
            };
            return dconductor.Insertar(obj);
        }

        public DataTable CargarBus()
        {
            return dconductor.CargarBuses();
        }
        public string EliminarConductor(int id_Conductor)
        {
            return dconductor.Eliminar(id_Conductor);
        }
        public string ActualizarConductor(int id_Conductor, string conductor, string bus, string ruta, string telefono, string horario)
        {
            eConductor obj = new eConductor
            {
                id_Conductor = id_Conductor,
                conductor = conductor,
                bus = bus,
                ruta = ruta,
                telefono = telefono,
                horario = horario
            };
            return dconductor.Actualizar(obj);
        }
        public string Limpiar()
        {
            return dconductor.Limpiar();
        }
    }
}
