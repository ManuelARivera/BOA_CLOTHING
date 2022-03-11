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
    class spInsertar
    {
        static SQLConnection cn = new SQLConnection();
        public static int Insertar (string Nombreprocedure, Empleado empleado)
        {
            SQLConnection.AbrirConexion();

            SqlCommand cmd = new SqlCommand(Nombreprocedure, cn.Conexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idColaborador", empleado.iDEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
            cmd.Parameters.AddWithValue("@Usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@Passwords", empleado.Passwords);

            return cmd.ExecuteNonQuery();
        }
    }
}
