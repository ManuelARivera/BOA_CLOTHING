using BOA_CLOTHING.BaseDatos;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades.SP
{
    class spInsertar
    {
        static SQLConnection cn = new SQLConnection();
        public static int Insertar (string Nombreprocedure, Empleado empleado)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idColaborador", empleado.iD);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
            cmd.Parameters.AddWithValue("@Usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@Passwords", empleado.Passwords);

            return cmd.ExecuteNonQuery();
        }

        public static int Insertar(string Nombreprocedure, Mercancia mercancia)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMercancia", mercancia.Codigo);
            cmd.Parameters.AddWithValue("@Tipo", mercancia.Tipo);
            cmd.Parameters.AddWithValue("@Marca", mercancia.Marca);
            cmd.Parameters.AddWithValue("@precio", mercancia.Precio);
            cmd.Parameters.AddWithValue("@Descripcion", mercancia.Descripcion);
            cmd.Parameters.AddWithValue("@Stock", mercancia.Stock);
            cmd.Parameters.AddWithValue("@Ventas", mercancia.Ventas);

            return cmd.ExecuteNonQuery();
        }

        public static int Insertar(string Nombreprocedure, Cliente cliente)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.iD);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@RNC", cliente.RNC);

            return cmd.ExecuteNonQuery();
        }
    }
}
