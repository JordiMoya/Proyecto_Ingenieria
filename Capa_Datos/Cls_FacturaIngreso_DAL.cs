using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Cls_FacturaIngreso_DAL
    {
        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        

        public void Agregar(FacturaIngreso facturaIngreso)
        {
            try
            {
                using (DB_ConstruccionesEntities contexto = new DB_ConstruccionesEntities())
                {
                    contexto.FacturaIngreso.Add(facturaIngreso);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FacturaIngreso Consultar(int idFacturaIngreso)
        {
            try
            {
                return miContexto.FacturaIngreso.Single(FacturaIngreso => FacturaIngreso.NumeroFacturaIngreso == idFacturaIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(FacturaIngreso pFacturaIngreso)
        {
            try
            {
                FacturaIngreso facturaIngreso = Consultar(pFacturaIngreso.NumeroFacturaIngreso);
                facturaIngreso.Semana = pFacturaIngreso.Semana;
                facturaIngreso.Descripcion = pFacturaIngreso.Descripcion;
                facturaIngreso.Total = pFacturaIngreso.Total;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int numeroFacturaIngreso)
        {
            try
            {
                FacturaIngreso facturaIngreso = miContexto.FacturaIngreso.First(FacturaIngreso => FacturaIngreso.NumeroFacturaIngreso == numeroFacturaIngreso);
                miContexto.FacturaIngreso.Remove(facturaIngreso);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
