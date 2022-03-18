using BOA_CLOTHING.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOA_CLOTHING.Entidades.SP
{
    class spFiltrar
    {
        static SQLConnection cn = new SQLConnection();
        public static void FiltradoDatos(string nombreprocedure, string nombreparametro, string valorparametro, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(nombreprocedure, cn.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(nombreparametro, valorparametro);
            
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }
    }
}
