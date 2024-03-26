using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values (" + ingreso.IdProveedor + ", "+
                                                          "'" + ingreso.FechaIngreso + "',"
                                                          + ingreso.Total + ","
                                                           + "'"+ ingreso.Estado +"')";
            conexion.Ejecutar(consulta);
        }
        Ingreso p = new Ingreso();
        public Ingreso ObtenerIngresoIdDal(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                p.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarIngresoDal(Ingreso p)
        {
            string consulta = "update ingreso set idproveedor=" + p.IdProveedor + "," +
                                                        "fechaingreso='" + p.FechaIngreso + "'," +
                                                        "total=" + p.Total + "," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idingreso=" + p.IdIngreso;
            conexion.Ejecutar(consulta);
        }
        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
