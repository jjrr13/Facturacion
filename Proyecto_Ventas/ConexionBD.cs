/*
 * Created by SharpDevelop.
 * User: Seisa
 * Date: 07/02/2018
 * Time: 1:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyecto_Ventas
{
    /// <summary>
    /// Description of Conexion.
    /// </summary>
    public class ConexionBD
    {
        static MySqlConnection Conectar()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connect;
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "empresa_facturacion";
            builder.Port = 3306;
            connect = new MySqlConnection(builder.ToString());
            connect.Open();
            return connect;
        }
        public static int SQL(String Sql)
        {
            MySqlCommand command = new MySqlCommand(Sql, Conectar());
            return command.ExecuteNonQuery();
        }
        public static DataTable Data(String Sql)
        {
            MySqlDataAdapter oAdap = new MySqlDataAdapter(Sql, Conectar());
            DataTable result = new DataTable();
            oAdap.Fill(result);
            return result;
        }
        public static int Id(int numero)
        {
            String sql = "CALL getIdTablas(" + numero + ")";
            MySqlDataAdapter oAdap = new MySqlDataAdapter(sql, Conectar());
            DataTable result = new DataTable();
            oAdap.Fill(result);
            int valor = int.Parse(result.Rows[0][0].ToString());
            return valor;
        }
    }
}