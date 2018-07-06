using Capa_Datos;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Cls_FacturaIngreso
    {
        Cls_FacturaIngreso_DAL facturaIngreso_DAL = new Cls_FacturaIngreso_DAL();

        public void Agregar(FacturaIngreso facturaIngreso)
        {
            try
            {
                facturaIngreso_DAL.Agregar(facturaIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FacturaIngreso Consultar(int numFacIngreso)
        {
            try
            {
                return facturaIngreso_DAL.Consultar(numFacIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(FacturaIngreso facturaIngreso)
        {
            try
            {
                facturaIngreso_DAL.Modificar(facturaIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int numFacIngreso)
        {
            try
            {
                facturaIngreso_DAL.Eliminar(numFacIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
