using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemasVentas.DAL
{
    public class conexion
    {

        public static string CONECTAR
        {
            get { return @"Data Source=DESKTOP-EROEUF5; Initial Catalog=TIENDITABD; Integrated Security=True; TrustServerCertificate=true;"; }
            //get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
        }
        public static DataSet EjecutarDataSet(string consulta)
        {
            string p = conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLA");
            return ds;
        }

        public static void Ejecutar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
        }

        public static int EjecutarEscalar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();

            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            int dev = Convert.ToInt32(cmd.ExecuteScalar());
            return dev;
        }
        public static DataTable EjecutarDataTabla(string consulta, string tabla)
        {
            string p = conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(tabla);
            da.Fill(dt);
            return dt;
        }
		public static bool ValidarCredenciales(string NOMBREUSER, string CONTRASEÑA)
		{
			// Consulta SQL para verificar si las credenciales son válidas
			string consulta = "SELECT COUNT(*) FROM USUARIO WHERE NOMBREUSER = @NOMBREUSER AND CONTRASEÑA = @CONTRASEÑA";

			using (SqlConnection conectar = new SqlConnection(CONECTAR))
			{
				using (SqlCommand cmd = new SqlCommand(consulta, conectar))
				{
					// Agregar parámetros para evitar inyección SQL
					cmd.Parameters.AddWithValue("@NOMBREUSER", NOMBREUSER);
					cmd.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA);

					conectar.Open();
					int count = (int)cmd.ExecuteScalar();

					// Si count es mayor que cero, significa que las credenciales son válidas
					return count > 0;
				}
			}
		}

	}
}