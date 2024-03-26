using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class UsuarioBss
    {
        UsuarioDal dal = new UsuarioDal();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuarioDal();
        }
        public void InsertarUsuarioBss(Usuario usuario)
        {
           dal.InsertarUsuarioDal(usuario);
        }
        public Usuario ObtenerUsuarioIdBss(int id)
        {
            return dal.ObtenerUsuarioIdDal(id);
        }
        public void EditarUsuarioBss(Usuario p)
        {
            dal.EditarUsuarioDal(p);
        }
        public void EliminarUsuarioBss(int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}
