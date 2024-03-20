using SistemaVenta.DAL;
using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.BSS
{
	public class TipoProdBss
	{
		TipoProdDal dal = new TipoProdDal();
		public DataTable ListarTiposProductosBss()
		{
			return dal.ListarTiposProductosDal();
		}
		public void InsertarTipoProdBss(TipoProd tipoProd)
		{
			dal.InsertarTipoProdDal(tipoProd);
		}
		/*public TipoProd ObtenerTipoProdIdBss(int id)
		{
			return dal.ObtenerTipoProdIdDal(id);
		}*/
		public void EditarTipoProdBss(TipoProd p)
		{
			dal.EditarTipoProdDal(p);
		}
		public void EliminarTipoProdBss(int id)
		{
			dal.EliminarTipoProdDal(id);
		}
	}
}
