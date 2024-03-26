using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from rol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "','"
                                                      + rol.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        Rol p = new Rol();
        public Rol ObtenerRolIdDal(int id)
        {
            string consulta = "select * from rol where idrol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarRolDal(Rol p)
        {
            string consulta = "update rol set nombre='" + p.Nombre + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idrol=" + p.IdRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarRolDal(int id)
        {
            string consulta = "delete from rol where idrol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
