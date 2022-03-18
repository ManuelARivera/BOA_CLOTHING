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
    class spMostrarGrilla
    {
        static SQLConnection cn = new SQLConnection();
        static public void LeerGrilla(string nombredeprocedure, DataGridView grilla)
        {

            SqlCommand cmd = new SqlCommand(nombredeprocedure, cn.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sad = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            sad.Fill(tabla);
            grilla.DataSource = tabla;
        }
    }
}
