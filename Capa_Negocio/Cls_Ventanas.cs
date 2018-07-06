using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Capa_Logica_Negocio
{
    public class Cls_Ventanas
    {
        Cls_Ventanas_DAL ventanaDAL = new Cls_Ventanas_DAL();

        public Array ListaVentanas()
        {
            try
            {
                return ventanaDAL.ListaVentanas();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ventanas ConsultarVentanas(int pIDVentana)
        {
            try
            {
                return ventanaDAL.ConsultarVentana(pIDVentana);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    

        public void Agregar(ventanas ventana )
        {
            try
            {
                ventanaDAL.Agregar(ventana);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ventanas Consultar(int idVentana)
        {
            try
            {
                return ventanaDAL.Consultar(idVentana);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(ventanas ventana)
        {
            try
            {
                ventanaDAL.Modificar(ventana);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int idVentana)
        {
            try
            {
                ventanaDAL.Eliminar(idVentana);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
