using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Cls_DetalleFactura_DAL
    {
        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        DetalleFactura detalle; 

        public void AgregarDetalleFactura(DetalleFactura pDetalleFactura)
        {
            try
            {

                miContexto.DetalleFactura.Add(pDetalleFactura);
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DetalleFactura ConsultarDetalleFactura(int numeroFactura)
        {
            try
            {
                return miContexto.DetalleFactura.Single(DetalleFactura => DetalleFactura.NumeroFactura == numeroFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarDetalelFactura(DetalleFactura pDetalleFactura)
        {
            try
            {
                detalle = miContexto.DetalleFactura.Single(DetalleFactura => DetalleFactura.NumeroFactura == pDetalleFactura.NumeroFactura);
                detalle.NumeroCasa = pDetalleFactura.NumeroCasa;
                detalle.Descripcion = pDetalleFactura.Descripcion;
                detalle.Total = pDetalleFactura.Total;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarDetalleFactura(int pNumeroDetalleFactura)
        {
            try
            {
                detalle = miContexto.DetalleFactura.First(DetalleFactura => DetalleFactura.NumeroDetalle == pNumeroDetalleFactura);
                miContexto.DetalleFactura.Remove(detalle);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
