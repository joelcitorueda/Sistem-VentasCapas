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
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();
        public DataTable ListarDetalleVentaBss()
        {
            return dal.ListarDetalleVentaDal();
        }
        public void InsertarDetalleVentaBss(DetalleVent detalleventa)
        {
            dal.InsertarDetalleVentaDal(detalleventa);
        }
        public DetalleVent ObtenerDetalleVentaIdBss(int id)
        {
            return dal.ObtenerDetalleVentaIdDal(id);
        }
        public void EditarDetalleVentaBss(DetalleVent p)
        {
            dal.EditarDetalleVentaDal(p);
        }
        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);
        }
    }
}
