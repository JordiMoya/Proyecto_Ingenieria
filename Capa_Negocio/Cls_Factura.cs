using Capa_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class Cls_Factura
    {
        Cls_Factura_DAL factura_DAL = new Cls_Factura_DAL();


        public void AgregarFactura(Factura pfactura, DataGridView dtgDetalle)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    factura_DAL.AgregarFactura(pfactura);

                    int numFila = dtgDetalle.RowCount - 1;
                    for (int i = 0; i < numFila; i++)
                    {
                        DetalleFactura detalle = new DetalleFactura
                        {
                            NumeroFactura = pfactura.NumeroFactura,
                            NumeroDetalle = Convert.ToInt32(dtgDetalle.Rows[i].Cells[0].Value),
                            NumeroCasa = Convert.ToInt32(dtgDetalle.Rows[i].Cells[1].Value),
                            Descripcion = Convert.ToString(dtgDetalle.Rows[i].Cells[2].Value),
                            Total = Convert.ToInt32(dtgDetalle.Rows[i].Cells[3].Value)


                        };

                        new Cls_DetalleFactura_DAL().AgregarDetalleFactura(detalle);

                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
                
        }



    }
}
