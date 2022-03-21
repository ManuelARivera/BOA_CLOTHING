using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BOA_CLOTHING.BaseDatos;
using System.Windows.Forms;
using BOA_CLOTHING.Formularios;

namespace BOA_CLOTHING.Entidades
{
    class FLogin
    {
        static SQLConnection cn = new SQLConnection();

        public static void ConsultarLogin(string Usuario, string Passwords)
        {
            SQLConnection.AbrirConexion();
            SqlCommand cmd = new SqlCommand("sp_ConsultaLogin", cn.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Passwords", Passwords);

            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                
                SQLConnection.CerrarConexion();
                FrmHome home = new FrmHome(Usuario);
                home.Show();
            }
            else 
            { 
                MessageBox.Show("Usuario o contraseña son incorrectos");
                SQLConnection.CerrarConexion();
            }
        }
    }
}
