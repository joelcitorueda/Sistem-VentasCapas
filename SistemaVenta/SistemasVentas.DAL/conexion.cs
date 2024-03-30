﻿using System;
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
		public string AutenticarUsuario(string usuario, string contraseña)
		{
			string cargo = null;

			using (SqlConnection connection = new SqlConnection(CONECTAR))
			{
				string query = "SELECT r.NOMBRE " +
							   "FROM USUARIO u " +
							   "INNER JOIN USUARIOROL ur ON u.IDUSUARIO = ur.IDUSUARIO " +
							   "INNER JOIN ROL r ON ur.IDROL = r.IDROL " +
							   "WHERE NOMBREUSER = @Usuario AND CONTRASEÑA = @Contraseña";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@Usuario", usuario);
				command.Parameters.AddWithValue("@Contraseña", contraseña);

				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();

					if (reader.Read())
					{
						cargo = reader["NOMBRE"].ToString();
					}

					reader.Close();
				}
				catch (Exception ex)
				{
					// Manejar excepciones si es necesario
					Console.WriteLine("Error al autenticar usuario: " + ex.Message);
				}
			}

			return cargo;
		}
		public string ObtenerDetalleVentaComoTexto()
		{
			StringBuilder detalleVenta = new StringBuilder();

			try
			{
				using (SqlConnection connection = new SqlConnection(CONECTAR))
				{
					string query = "SELECT * FROM DETALLEVENTA";

					SqlCommand command = new SqlCommand(query, connection);

					connection.Open();

					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						detalleVenta.AppendLine("ID: " + reader["IDDETALLEVENTA"].ToString());
						detalleVenta.AppendLine("ID Venta: " + reader["IDVENTA"].ToString());
						detalleVenta.AppendLine("ID Producto: " + reader["IDPRODUCTO"].ToString());
						detalleVenta.AppendLine("Cantidad: " + reader["CANTIDAD"].ToString());
						detalleVenta.AppendLine("Precio Venta: " + reader["PRECIOVENTA"].ToString());
						detalleVenta.AppendLine("Subtotal: " + reader["SUBTOTAL"].ToString());
						detalleVenta.AppendLine("------------------------------------------");
					}

					reader.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al obtener detalle de venta: " + ex.Message);
			}

			return detalleVenta.ToString();
		}
	}


}
