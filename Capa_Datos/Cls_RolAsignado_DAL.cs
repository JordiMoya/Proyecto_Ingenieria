using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Cls_RolAsignado_DAL
    {
        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        rolAsignadoAUsuario rolAsignado;

        public void Agregar(rolAsignadoAUsuario pRolAsignado)
        {
            try
            {

                miContexto.rolAsignadoAUsuario.Add(pRolAsignado);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede asignar Rol");
            }
        }

        public rolAsignadoAUsuario Consultar()
        {
            try
            {
                return miContexto.rolAsignadoAUsuario.Single(rolAsignadoAUsuario => rolAsignadoAUsuario.idRol == 12);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public rolAsignadoAUsuario ListaRolesUsuario(int pidUsuario)
        {
            try
            {
                rolAsignadoAUsuario rolAsig = null;

                var ListaRolesUsuario =
                     from lista in miContexto.rolAsignadoAUsuario
                     where lista.idUsuario == pidUsuario
                     select lista;

                foreach(rolAsignadoAUsuario asig in ListaRolesUsuario)
                {
                    rolAsig = asig;
                }

                return rolAsig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Array ListaRoles(int pidUsuario)
        {
            try
            {

                var ListaRolesUsuario =
                     from lista in miContexto.rolAsignadoAUsuario
                     where lista.idUsuario == pidUsuario
                     select lista;
                return ListaRolesUsuario.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRolAsignado(int pidUsuario)
        {
            try
            {
                Array Lista = ListaRoles(pidUsuario);
                foreach(rolAsignadoAUsuario rol in Lista)
                {
                    miContexto.rolAsignadoAUsuario.Remove(rol);   
                }
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Modificar roles asignados, no se puede
        /// </summary>
        /// <param name="rolAsig"></param>
        public void ModificarRolAsignado(rolAsignadoAUsuario rolAsig)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PRUEBA
        /// </summary>
        /// <param name="pidUsuario"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public rolAsignadoAUsuario RolAsignado(int pidUsuario, int tag)
        {
            try
            {
                rolAsignadoAUsuario rolAsig = null;

                var ListaRolesUsuario =
                     from lista in miContexto.rolAsignadoAUsuario
                     join permiso in miContexto.permisosDeRol 
                     on lista.idRol equals permiso.idrol
                     where lista.idUsuario == pidUsuario && permiso.idventana==tag
                     select lista;

                foreach (rolAsignadoAUsuario asig in ListaRolesUsuario)
                {
                    rolAsig = asig;
                }

                return rolAsig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
