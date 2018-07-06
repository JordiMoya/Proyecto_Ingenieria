using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace DAL
{
    public class Cls_Usuario_DAL
    {

        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        usuarios usuario;

        public void AgregarUsuario(usuarios usuario)
        {
            try
            {
                using (DB_ConstruccionesEntities contexto = new DB_ConstruccionesEntities())
                {
                    contexto.usuarios.Add(usuario);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public usuarios ConsultarUsuario(string nombreUsuario)
        {
            try
            {
                usuarios user = miContexto.usuarios.Single(usuarios => usuarios.nombreUsuario == nombreUsuario);
                if(user==null)
                {
                    throw new Exception("Datos de usuario invalidos");
                }
                else
                {
                    return user;
                }
                
            }
            catch
            {
                throw new Exception("Datos de usuario invalidos");
            }
        }

        public void ModificarUsuario(usuarios pUsuario)
        {
            try
            {
                usuario = ConsultarUsuario(pUsuario.nombreUsuario);
                usuario.contrasenna = pUsuario.contrasenna;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCliente(string nombreUsuario)
        {
            try
            {
                usuario = miContexto.usuarios.First(usuarios => usuarios.nombreUsuario == nombreUsuario);
                miContexto.usuarios.Remove(usuario);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean ValidarIngreso(usuarios user)
        {
            try
            {
                usuario = miContexto.usuarios.First(usuarios => usuarios.nombreUsuario==user.nombreUsuario);
                if (usuario.contrasenna == user.contrasenna)
                {
                    return true;

                }
                else
                { 
                    return false;
                           
                }
            }
            catch (Exception ex)
            {
                throw new Exception("El usuario o contraseña son invalidos");
            }
        }
    }
}
