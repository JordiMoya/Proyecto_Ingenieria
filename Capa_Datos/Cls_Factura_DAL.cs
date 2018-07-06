using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Cls_Factura_DAL
    {
        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        Factura factura;

        public void AgregarFactura(Factura pfactura)
        {
            try
            {

                miContexto.Factura.Add(pfactura);
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Factura ConsultarFactura(int codigoFactura)
        {
            try
            {
                return miContexto.Factura.Single(Factura => Factura.NumeroFactura == codigoFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarFactura(Factura pFactura)
        {
            try
            {
                factura = miContexto.Factura.Single(Factura => Factura.NumeroFactura == pFactura.NumeroFactura);
                factura.Fecha = pFactura.Fecha;
                factura.Semana = pFactura.Semana;
                factura.Total = pFactura.Total;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarFactura(int pNumeroFactura)
        {
            try
            {
                factura = miContexto.Factura.First(Factura => Factura.NumeroFactura == pNumeroFactura);
                miContexto.Factura.Remove(factura);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
