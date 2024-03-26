using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values (" + usuariorol.IdUsuario + ","
                                                          + usuariorol.IdRol + ",' "
                                                          + usuariorol.FechaAsigna + "','"
                                                          + usuariorol.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        UsuarioRol p = new UsuarioRol();
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                
                p.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                p.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                p.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                p.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarUsuarioRolDal(UsuarioRol p)
        {
            string consulta = "update usuariorol set idusuario=" + p.IdUsuario + "," +
                                                        "idrol=" + p.IdRol + "," +
                                                        "fechaasigna='" + p.FechaAsigna + "', " +
                                                        "estado='" + p.Estado + "' " +
                                                "where idusuariorol=" + p.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
