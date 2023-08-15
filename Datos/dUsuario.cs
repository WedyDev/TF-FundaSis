using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dUsuario
    {
        Database db=new Database();

        public string Registrar(eUsuario o)
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string regis = "sp_agregar_usuario";
                SqlCommand cmd = new SqlCommand(regis, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", o.nombre);
                cmd.Parameters.AddWithValue("@Contraseña", o.contraseña);
                cmd.Parameters.AddWithValue("@Telefono", o.telefono);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Registrar";
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public string IniciarSesion(eUsuario o)
        {
            SqlConnection conn = db.ConectaDB();
            string iniciar_sesion = "sp_iniciar_sesion";
            SqlCommand cmd = new SqlCommand(iniciar_sesion, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", o.nombre);
            cmd.Parameters.AddWithValue("@Contraseña", o.contraseña);
            cmd.ExecuteNonQuery();
            SqlDataReader tipousuario = cmd.ExecuteReader();
            while(tipousuario.Read())
            {
                o.tipo_usuario = tipousuario.GetString(2);
            }
            tipousuario.Close();
            db.ConectaDB(); //conn.Close();
            cmd.Parameters.Clear();
            return o.tipo_usuario;
        }
        public string Limpiar()
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string limpiar = "sp_limpiarUsuario";
                SqlCommand cmd = new SqlCommand(limpiar, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Limpia";
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                db.DesconectaDB();
            }


        }

    }
}
