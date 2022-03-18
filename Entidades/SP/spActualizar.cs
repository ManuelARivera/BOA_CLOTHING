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
    class spActualizar
    {
        static SQLConnection cn = new SQLConnection();
        public static int Actualizar(string Nombreprocedure, Mercancia mercancia)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMercancia", mercancia.Codigo);
            cmd.Parameters.AddWithValue("@Tipo", mercancia.Tipo);
            cmd.Parameters.AddWithValue("@Marca", mercancia.Marca);
            cmd.Parameters.AddWithValue("@Precio", mercancia.Precio);
            cmd.Parameters.AddWithValue("@Descripcion", mercancia.Descripcion);

            return cmd.ExecuteNonQuery();
        }
    }
}
