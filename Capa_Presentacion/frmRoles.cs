using Capa_Logica_Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmRoles : Form
    {

        #region Variables
            int vConsul;
            int vInser;
            int vMod;
            int vDel;
            int numFila;
        #endregion

        public frmRoles()
        {
            InitializeComponent();
        }

        public void LlenarComboBox()
        {
            cbxVentana.DataSource = new Cls_Ventanas().ListaVentanas();
            this.cbxVentana.ValueMember = "ID_Ventana";
            this.cbxVentana.DisplayMember = "Nombre";
        }

        public void EstadoInicial()
        {
            txtCod.Text = "";
            txtNomRol.Text = "";

            int numFila = dtgPermisos.RowCount - 1;
            for (int i = 0; i < numFila; i++)
            {
                dtgPermisos.Rows.RemoveAt(0);
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            LlenarComboBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            numFila = dtgPermisos.RowCount - 1;
            bool existe = false;
            for (int i = 0; i < numFila; i++)
            {
                if (Convert.ToInt32(dtgPermisos.Rows[i].Cells[0].Value) == Convert.ToInt32(cbxVentana.SelectedValue))
                {
                    existe = true;
                }

            }

            if (existe)
            {
                MessageBox.Show("No puede ingresar la misma ventana", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtgPermisos.Rows.Add(cbxVentana.SelectedValue, cbxVentana.Text, vConsul, vInser, vMod, vDel);//cambiar a idventana

            }
        }

        private void checkConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConsultar.Checked)
            {
                vConsul = 1;
            }
            else
            {

                vConsul = 0;
            }
        }

        private void checkInsertar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInsertar.Checked)
            {
                vInser = 1;
            }
            else
            {

                vInser = 0;
            }
        }

        private void checkModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModificar.Checked)
            {
                vMod = 1;
            }
            else
            {

                vMod = 0;
            }
        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                vDel = 1;
            }
            else
            {

                vDel = 0;
            }
        }

        private void dtgPermisos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbxVentana.SelectedValue = dtgPermisos.Rows[e.RowIndex].Cells[0].Value;

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[2].Value) == 1)
            {
                checkConsultar.Checked = true;
            }
            else
            {
                checkConsultar.Checked = false;
            }

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[3].Value) == 1)
            {
                checkInsertar.Checked = true;
            }
            else
            {
                checkConsultar.Checked = false;
            }

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[4].Value) == 1)
            {
                checkModificar.Checked = true;
            }
            else
            {
                checkModificar.Checked = false;
            }

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[5].Value) == 1)
            {
                checkEliminar.Checked = true;
            }
            else
            {
                checkEliminar.Checked = false;
            }


            dtgPermisos.Rows.RemoveAt(e.RowIndex);
        }

        public void VerificarPermisoRol(permisosDeRol permisos)
        {
            if (permisos.consultar == 0)
            {
                btnConsultar.Enabled = false;
            }
            if (permisos.insertar == 0)
            {
                btnAgregar.Enabled = false;
            }
            if (permisos.modificar == 0)
            {
                btnModificar.Enabled = false;
            }
            if (permisos.eliminar == 0)
            {
                btnEliminar.Enabled = false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                roles rol = new roles
                {
                    nombre = txtNomRol.Text
                };

                new Cls_Rol().Agregar(rol, dtgPermisos);

                MessageBox.Show("Permisos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                roles rol = new Cls_Rol().Consultar(Convert.ToInt32(txtCod.Text));
                if (MessageBox.Show("¿Realmente desea modificar el Rol?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_Rol().Modificar(rol, dtgPermisos);
                    MessageBox.Show("Rol modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el Rol?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_Rol().Eliminar(Convert.ToInt32(txtCod.Text));
                    MessageBox.Show("Rol eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                roles rol = new Cls_Rol().Consultar(Convert.ToInt32(txtCod.Text));
                txtCod.Text = "" + rol.idrol;
                txtNomRol.Text = rol.nombre;

                new Cls_PermisosRol().ListaPermisos(Convert.ToInt32(txtCod.Text), dtgPermisos);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
