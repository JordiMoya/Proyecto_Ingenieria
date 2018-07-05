using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Cls_PermisosRol_DAL
    {

        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        permisosDeRol permisosRol;

        public void AgregarPermisosRol(permisosDeRol pPermisosRol)
        {
            try
            {

                miContexto.permisosDeRol.Add(pPermisosRol);
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public roles ConsultarPermisosRol(int codigoRol)
        {
            try
            {
                return miContexto.roles.Single(roles => roles.idrol == codigoRol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPermisosRol(permisosDeRol pPermisosRol)
        {
            try
            {
               
                var listaper =
                    from permisos in miContexto.permisosDeRol
                    where permisos.idrol == pPermisosRol.idrol && permisos.idventana == pPermisosRol.idventana
                    select permisos;

                foreach(permisosDeRol perm in listaper)
                {
                    perm.insertar = pPermisosRol.insertar;
                    perm.consultar = pPermisosRol.consultar;
                    perm.modificar = pPermisosRol.modificar;
                    perm.eliminar = pPermisosRol.eliminar;
                }
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPermisosRol(int pIDRol)
        {
            try
            {
                var eliminarPermisos =
                    from permisosDeRol in miContexto.permisosDeRol
                    where permisosDeRol.idrol == pIDRol
                    select permisosDeRol;

                foreach (var permisosDeRol in eliminarPermisos)
                {
                    miContexto.permisosDeRol.Remove(permisosDeRol);
                }

                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo que lista los permisos del rol consultado
        /// </summary>
        /// <param name="idRol"></param>
        /// <returns></returns>
        public Array ListaPermisos(int idRol)
        {
            try
            {
                var ListaPermisos =
                    from permisosDeRol in miContexto.permisosDeRol
                    join ventanas in miContexto.ventanas on permisosDeRol.idventana equals ventanas.idventana
                    where permisosDeRol.idrol == idRol
                    select permisosDeRol;
                    /*select new
                    {
                        IdVentana = permisosDeRol.idventana,
                        Nombre = ventanas.nombre,
                        Consultar = permisosDeRol.consultar,
                        Insertar = permisosDeRol.insertar,
                        Modificar = permisosDeRol.modificar,
                        Eliminar = permisosDeRol.eliminar
                    };*/

                return ListaPermisos.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public permisosDeRol ConsultarPermisosRol(int tag, int idRol)
        {
            try
            {
                permisosDeRol permiso = null;

                var resultado =
                    from permisos in miContexto.permisosDeRol
                    where permisos.idventana == tag && permisos.idrol == idRol
                    select permisos;

                foreach (permisosDeRol per in resultado)
                {
                    permiso = per;
                }

                return permiso;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
