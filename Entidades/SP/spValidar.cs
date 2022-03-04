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
    class spValidar
    {
        static SQLConnection cn = new SQLConnection();
        public static bool Existe(string nombredeprocedure, int id)
        {
            bool existe = false;

            SqlCommand cmd = new SqlCommand(nombredeprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            SQLConnection.AbrirConexion();
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                existe = true;
            }
            SQLConnection.CerrarConexion();
            return existe;
        }
        public static bool Existe(string nombredeprocedure, string id)
        {
            bool existe = false;

            SqlCommand cmd = new SqlCommand(nombredeprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            SQLConnection.AbrirConexion();
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                existe = true;
            }
            SQLConnection.CerrarConexion();
            return existe;
        }
    }
}
