using Capa_Datos;
using Entidades;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class Rol
    {
        Rol_DAL rolDAL = new Rol_DAL();
        /*
        public void Agregar(roles rol, DataGridView dtgPermisos)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    rolDAL.AgregarRol(rol);

                    int numFila = dtgPermisos.RowCount - 1;
                    for (int i = 0; i < numFila; i++)
                    {

                        permisosDeRol permisosRol = new permisosDeRol
                        {
                            idrol = rol.idrol,
                            modulo = Convert.ToInt32(dtgPermisos.Rows[i].Cells[0].Value),
                            consultar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[2].Value),
                            insertar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[3].Value),
                            modificar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[4].Value),
                            eliminar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[5].Value)
                        };

                        new Cls_PermisosRol().Agregar(permisosRol);
                    }

                    scope.Complete();

                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }

        }

        public roles Consultar(int IDRol)
        {

            try
            {
                return rolDAL.ConsultarRol(IDRol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(roles rol, DataGridView dtgPermisos)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {

                    int numFila = dtgPermisos.RowCount - 1;
                    for (int i = 0; i < numFila; i++)
                    {

                        permisosDeRol permisosRol = new permisosDeRol
                        {
                            idrol = rol.idrol,
                            idmodulo = Convert.ToInt32(dtgPermisos.Rows[i].Cells[0].Value),
                            consultar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[2].Value),
                            insertar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[3].Value),
                            modificar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[4].Value),
                            eliminar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[5].Value)
                        };

                        new Cls_PermisosRol().Modificar(permisosRol);
                    }

                    rolDAL.ModificarRol(rol);

                    scope.Complete();

                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
        }

        public void Eliminar(int IDRol)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    new Cls_PermisosRol().Eliminar(IDRol);

                    rolDAL.EliminarRol(IDRol);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }

        }

        public Array ListaRoles()
        {
            try
            {
                return rolDAL.ListaRoles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
    }
}
