using BOA_CLOTHING.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades.SP
{
    class spBuscarEmpleado
    {
        static SQLConnection cn = new SQLConnection();
        public static DataTable OptenerDatos(string usuario)
        {

            SqlCommand cmd = new SqlCommand("sp_BuscarEmpleado", cn.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", usuario);

            SqlDataAdapter sad = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            sad.Fill(tabla);
            return tabla;
        }
    }
}
