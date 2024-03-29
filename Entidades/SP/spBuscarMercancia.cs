﻿using BOA_CLOTHING.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades.SP
{
    class spBuscarMercancia
    {
        static SQLConnection cn = new SQLConnection();
        public static DataTable OptenerDatos( string id)
        {

            SqlCommand cmd = new SqlCommand("sp_BuscarMercancia", cn.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMercancia", id);

            SqlDataAdapter sad = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            sad.Fill(tabla);
            return tabla;
        }
        public static DataTable OptenerDatosCompra(string id)
        {

            SqlCommand cmd = new SqlCommand("sp_BuscarCompraMercancia", cn.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", id);

            SqlDataAdapter sad = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            sad.Fill(tabla);
            return tabla;
        }
    }
}
