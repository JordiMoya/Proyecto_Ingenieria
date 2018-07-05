using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Capa_Logica_Negocio
{
    public class Cls_RolAsignado
    {

        Cls_RolAsignado_DAL asignadoDAL = new Cls_RolAsignado_DAL();

        public void Agregar(rolAsignadoAUsuario rolAsignado)
        {
            try
            {
                asignadoDAL.Agregar(rolAsignado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public permisosDeRol PermisosRol(int pidusuario, int tag)
        {
            try
            {
                
                rolAsignadoAUsuario rolAsig = asignadoDAL.RolAsignado(pidusuario, tag);
                if (rolAsig != null)
                {
                    return new Cls_PermisosRol().ConsultarPermisos(tag, Convert.ToInt32(rolAsig.idRol));
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo que retorna la lista de los roles asignados a un usuario
        /// </summary>
        /// <param name="pIDUser"></param>
        /// <returns></returns>
        public Array ListaRoles(int pIDUser)
        {
            try
            {
                return asignadoDAL.ListaRoles(pIDUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRolAsignado(int pIdUser)
        {
            try
            {
                asignadoDAL.EliminarRolAsignado(pIdUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarRolAsignado(rolAsignadoAUsuario rol)
        {
            try
            {
                asignadoDAL.ModificarRolAsignado(rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
