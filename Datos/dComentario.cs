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
    public class dComentario
    {
        Database db = new Database();

        public string Insertar_Comentario(eComentario o)
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string insert = "sp_insertar_comentario";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Comentario", o.comentario);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Inserto";
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
        public string Limpiar()
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string limpiar = "sp_limpiarcome";
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

        public List<eComentario> listarComentarios()
        {
            try
            {
                List<eComentario> lsComentario = new List<eComentario>();
                eComentario comentario = null;

                SqlConnection conn = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(" sp_mostrar_come", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    comentario = new eComentario();
                    comentario.comentario = (string)reader["Comentario"];
                    lsComentario.Add(comentario);
                }
                reader.Close();
                return lsComentario;
            }
            catch (Exception)
            {

                throw;
            }
            finally { db.ConectaDB(); }
        }
    }
}
