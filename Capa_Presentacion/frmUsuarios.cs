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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void ValidarTexto()
        {
            if (string.IsNullOrEmpty(txtNomUsuario.Text) || string.IsNullOrEmpty(txtContra.Text) || string.IsNullOrEmpty(txtConfirContra.Text))
            {
                throw new Exception("No se permiten campos vacios");
            }
            if (txtContra.Text.Trim() != txtConfirContra.Text.Trim())
            {
                throw new Exception("Contaseñas no coinciden");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarTexto();

                usuarios usuario = new usuarios
                {
                    nombreUsuario = txtNomUsuario.Text,
                    contrasenna = txtContra.Text

                };

                new Cls_Usuario().Agregar(usuario);
                MessageBox.Show("Usuario guardado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ValidarTexto();
                usuarios usuario = new usuarios
                {
                    nombreUsuario = txtNomUsuario.Text,
                    contrasenna = txtContra.Text
                };

                new Cls_Usuario().Modificar(usuario);
                MessageBox.Show("Usuario Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("¿Realmente desea eliminar el usuario?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_Usuario().Eliminar(txtNomUsuario.Text);

                    MessageBox.Show("Usuario eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                usuarios usuario = new Cls_Usuario().Consultar(txtNomUsuario.Text);
                usuario.contrasenna = txtContra.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
