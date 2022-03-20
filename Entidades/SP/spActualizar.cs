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
        public static int Actualizar(string Nombreprocedure, Empleado empleado)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idColaborador", empleado.iD);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);

            return cmd.ExecuteNonQuery();
        }
        public static int Actualizar(string Nombreprocedure, Cliente cliente)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.iD);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@RNC", cliente.RNC);

            return cmd.ExecuteNonQuery();
        }
    }
}
