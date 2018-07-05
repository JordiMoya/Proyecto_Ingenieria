using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Windows.Forms;

namespace Capa_Logica_Negocio
{
    public class Cls_PermisosRol
    {
        Cls_PermisosRol_DAL permisosRolDAL = new Cls_PermisosRol_DAL();

        public void Agregar(permisosDeRol pPermisos)
        {
            try
            {
                permisosRolDAL.AgregarPermisosRol(pPermisos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       /// <summary>
       /// Retorna la lista de permisos de rol y llena el dtg
       /// </summary>
       /// <param name="idRol"></param>
       /// <returns></returns>
        public void ListaPermisos(int idRol, DataGridView dtg)
        {
            try
            {
                Array lista = permisosRolDAL.ListaPermisos(idRol); 
                ventanas ventana = null;

                foreach (permisosDeRol per in lista)
                {
                    ventana = new Cls_Ventanas().ConsultarVentanas(Convert.ToInt32(per.idventana));
                    dtg.Rows.Add(per.idventana, ventana.nombre, per.consultar, per.insertar, per.modificar, per.eliminar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int pIDRol)
        {
            try
            {
                permisosRolDAL.EliminarPermisosRol(pIDRol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public permisosDeRol ConsultarPermisos(int tag, int idRol)
        {
            try
            {
                return permisosRolDAL.ConsultarPermisosRol(tag, idRol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(permisosDeRol permiso)
        {
            try
            {
                permisosRolDAL.ModificarPermisosRol(permiso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
