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
    public class dReserva
    {
          Database db=new Database();

        public string Insertar(eReserva o )
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string insert = "sp_InsertarReserva";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Bus", o.bus);
                cmd.Parameters.AddWithValue("@Paradero_inicial", o.paradero_inicial);
                cmd.Parameters.AddWithValue("@Paradero_final", o.paradero_final);
                cmd.Parameters.AddWithValue("@Horario", o.horario);
                cmd.Parameters.AddWithValue("@asiento", o.asiento);
                cmd.Parameters.AddWithValue("@pasaje", o.pasaje);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Inserto";
            }
            catch (Exception)
            {

                return null;
            }
            finally {
                db.DesconectaDB();
            }
        }
        public string Limpiar()
        {
            try
            {
                SqlConnection conn = db.ConectaDB();
                string limpiar = "sp_limpiarReserva";
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
        public List<eReserva> reporte2()
        {
            try
            {
                List<eReserva> lsProducto = new List<eReserva>();
                eReserva Producto = null;

                SqlConnection conn = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("sp_reporte2", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto = new eReserva();
                    Producto.id_bus = (int)reader["idBus"];
                    Producto.bus = (string)reader["bus"];
                    Producto.paradero_inicial = (string)reader["paraderoInicial"];
                    Producto.paradero_final = (string)reader["paraderoFinal"];
                    Producto.horario = (string)reader["horario"];
                    Producto.asiento = (int)reader["asiento"];
                    Producto.pasaje = (decimal)reader["pasaje"];
                    lsProducto.Add(Producto);
                }
                reader.Close();
                return lsProducto;
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
