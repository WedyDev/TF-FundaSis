using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Database
    {
        private SqlConnection conn;
        public SqlConnection ConectaDB()
        {
            try
            {
                String cadenadeconexion = "Data Source=localhost;Initial Catalog=DBVelovity;Integrated Security=True";
                conn = new SqlConnection(cadenadeconexion);

                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public void DesconectaDB()
        {
            conn.Close();
        }

    }
}