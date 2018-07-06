using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Windows.Forms;
using System.Transactions;


namespace Capa_Logica_Negocio
{
    public class Cls_Usuario
    {
        Cls_Usuario_DAL usuarioDAL = new Cls_Usuario_DAL();

        public void Agregar(usuarios usuario)
        {
            try
            {
                usuarioDAL.AgregarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public usuarios Consultar(string nomUse)
        {
            try
            {
                return usuarioDAL.ConsultarUsuario(nomUse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(usuarios usuario)
        {
            try
            {
                usuarioDAL.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(string nomUse)
        {
            try
            {
                usuarioDAL.EliminarCliente(nomUse);
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
                return usuarioDAL.ValidarIngreso(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean ValidarVentanas(usuarios user)
        {
            try
            {
                return usuarioDAL.ValidarIngreso(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarPermisos(usuarios usuario, DataGridView dtgRoles, DataGridView dtgPermisos, bool vRoles, bool vPermisos, ComboBox cbxRoles)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    rolAsignadoAUsuario rolAsignado;
                    if (vRoles)
                    {
                        Console.WriteLine(usuario.idUsuario);
                        //Agregar roles
                        int numFila = dtgRoles.RowCount - 1;
                        for (int i = 0; i < numFila; i++)
                        {
                            rolAsignado = new rolAsignadoAUsuario
                            {
                                idUsuario = usuario.idUsuario,
                                idRol = Convert.ToInt32(dtgRoles.Rows[i].Cells[0].Value)
                            };
                            
                            Console.WriteLine(rolAsignado.idRol);
                            new Cls_RolAsignado().Agregar(rolAsignado); 
                        }
                    }

                    scope.Complete();
                    
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw new Exception("No se puede asignar");
                }
            }
        }

    }
}
