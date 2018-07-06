using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Cls_Rol_DAL
    {

        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        roles rol;

        public void AgregarRol(roles pRol)
        {
            try
            {

                miContexto.roles.Add(pRol);
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public roles ConsultarRol(int codigoRol)
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

        public void ModificarRol(roles pRol)
        {
            try
            {
                rol = miContexto.roles.Single(roles => roles.idrol == pRol.idrol);
                rol.nombre = pRol.nombre;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRol(int pIDRol)
        {
            try
            {
                rol = miContexto.roles.First(roles => roles.idrol == pIDRol);
                miContexto.roles.Remove(rol);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Array ListaRoles()
        {
            try
            {
                var listaRol =
                    from rol in miContexto.roles
                    select new
                    {
                        ID_Rol = rol.idrol,
                        Nombre = rol.nombre
                    };
                return listaRol.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

