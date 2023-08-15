using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;
namespace Negocio
{
    public class nComentario
    {
        dComentario ddComentario = new dComentario();

        public string Insertar(string comentario)
        {

            eComentario obj = new eComentario
            {
                comentario = comentario
            };

            return ddComentario.Insertar_Comentario(obj);
        }

        public List<eComentario> Listar_Comentario()
        {
            return ddComentario.listarComentarios();
        }
        public string Limpiar()
        {
            return ddComentario.Limpiar();
        }
    }
}
