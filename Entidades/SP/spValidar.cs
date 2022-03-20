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
        public static bool Existe(string nombredeprocedure, string cogido)
        {
            bool existe = false;

            SqlCommand cmd = new SqlCommand(nombredeprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMercancia", cogido);

            SQLConnection.AbrirConexion();
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                existe = true;
            }
            SQLConnection.CerrarConexion();
            return existe;
        }
        public static bool ExistePerson(string nombredeprocedure, string cedula)
        {
            bool existe = false;

            SqlCommand cmd = new SqlCommand(nombredeprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", cedula);

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
