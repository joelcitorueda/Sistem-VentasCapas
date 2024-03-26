using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoprod)
        {
            string consulta = "insert into tipoprod values('" + tipoprod.Nombre + "','"
                                                        + tipoprod.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        TipoProd p = new TipoProd();
        public TipoProd ObtenerTipoProdIdDal(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarTipoProdDal(TipoProd p)
        {
            string consulta = "update tipoprod set nombre='" + p.Nombre + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idtipoprod=" + p.IdTipoProd;
            conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
