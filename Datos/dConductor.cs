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
    public class dConductor
    {
        Database db = new Database();

        public DataTable CargarBuses()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = db.ConectaDB();
            string cargarbuses = "sp_cargarbuses";
            SqlDataAdapter da = new SqlDataAdapter(cargarbuses, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;

        }

        public string Limpiar()
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string limpiar = "sp_limpiarConductores";
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
        public string Insertar(eConductor obj)
        {
            try
            {

                SqlConnection conn = db.ConectaDB();
                string insert = "sp_insertar_conductor";
                SqlCommand cmd = new SqlCommand(insert, conn);
                //Datos
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@conductor", obj.conductor);
                cmd.Parameters.AddWithValue("@bus", obj.bus);
                cmd.Parameters.AddWithValue("@ruta", obj.ruta);
                cmd.Parameters.AddWithValue("@telf", obj.telefono);
                cmd.Parameters.AddWithValue("@horario", obj.horario);


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


        public List<eConductor> ListarConductor()
        {
            try
            {
                List<eConductor> listConductor = new List<eConductor>();
                eConductor conductor = null;

                SqlConnection conn = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("sp_listaConductores", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    conductor = new eConductor();
                    conductor.id_Conductor = (int)reader["idConductor"];
                    conductor.conductor = (string)reader["conductor"];
                    conductor.bus = (string)reader["bus"];
                    conductor.ruta = (string)reader["ruta"];
                    conductor.telefono = (string)reader["telf"];
                    conductor.horario = (string)reader["horario"];

                    listConductor.Add(conductor);
                }
                reader.Close();
                return listConductor;

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
        public string Eliminar(int id_Conductor)
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string remove = "sp_eliminar_conductor";
                SqlCommand cmd = new SqlCommand(remove, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idConductor", id_Conductor);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Eliminado";

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




        public string Actualizar(eConductor obj)
        {
            try
            {

                SqlConnection conn = db.ConectaDB();
                string insert = "sp_actualizar_conductor";
                SqlCommand cmd = new SqlCommand(insert, conn);
                //Datos
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idConductor", obj.id_Conductor);
                cmd.Parameters.AddWithValue("@conductor", obj.conductor);
                cmd.Parameters.AddWithValue("@bus", obj.bus);
                cmd.Parameters.AddWithValue("@ruta", obj.ruta);
                cmd.Parameters.AddWithValue("@telf", obj.telefono);
                cmd.Parameters.AddWithValue("@horario", obj.@horario);


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
    }
}
