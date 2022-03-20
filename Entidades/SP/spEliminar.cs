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
    class spEliminar
    {
        static SQLConnection cn = new SQLConnection();
        public static int Eliminar(string Nombreprocedure, Mercancia mercancia)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMercancia", mercancia.Codigo);

            return cmd.ExecuteNonQuery();
        }
        public static int Eliminar(string Nombreprocedure, Empleado empleado)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idColaborador", empleado.iD);

            return cmd.ExecuteNonQuery();
        }
        public static int Eliminar(string Nombreprocedure, Cliente cliente)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.iD);

            return cmd.ExecuteNonQuery();
        }
    }
}
