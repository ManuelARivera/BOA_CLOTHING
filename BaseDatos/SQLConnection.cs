using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BOA_CLOTHING.BaseDatos
{
    class SQLConnection
    {
        static private SqlConnection _cn;

        public SQLConnection()
        {
            _cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
        }

        static public void AbrirConexion()
        {
            _cn.Open();
        }

        static public void CerrarConexion()
        {
            _cn.Close();
        }

        public SqlConnection Conexion()
        {
            return _cn;
        }
    }
}
