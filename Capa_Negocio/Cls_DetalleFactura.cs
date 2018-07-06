using Capa_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class Cls_DetalleFactura
    {
        Cls_DetalleFactura_DAL factura_DAL = new Cls_DetalleFactura_DAL();

        public void ListaDetalles(int numFactura, DataGridView dtg)
        {
            try
            {
                Array lista = factura_DAL.ListaDetalles(numFactura);
                DetalleFactura detalle = null;

                foreach (DetalleFactura det in lista)
                {
                    detalle = new Cls_DetalleFactura.Consultar(Convert.ToInt32(det.NumeroDetalle));
                    dtg.Rows.Add(det.NumeroDetalle, det.NumeroCasa, det.Descripcion, det.Total);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
