using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values (" + usuario.IdPersona + ",' "
                                                          + usuario.NombreUser + "',' "
                                                          + usuario.Contraseña + "','"
                                                          + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }
        Usuario p = new Usuario();
        public Usuario ObtenerUsuarioIdDal(int id)
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                p.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                p.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);
            }
            return p;
        }
        public void EditarUsuarioDal(Usuario p)
        {
            string consulta = "update usuario set idpersona=" + p.IdPersona + "," +
                                                        "nombreuser='" + p.NombreUser + "'," +
                                                        "contraseña='" + p.Contraseña+ "'," +
                                                        "fechareg='" + p.FechaReg + "' " +
                                                "where idusuario=" + p.IdUsuario;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
