using Capa_Negocio;
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
    public partial class frmFacturaIngreso : Form
    {
        public frmFacturaIngreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FacturaIngreso facturaIngreso = new FacturaIngreso
                {
                    NumeroFacturaIngreso = Convert.ToInt32(txtFacturaIngreso.Text),
                    NumeroFactura = Convert.ToInt32(txtFactura.Text),
                    Fecha = Convert.ToDateTime(dtpFecha.Text),
                    Semana = Convert.ToInt32(txtSemana.Text),
                    Descripcion = rtxtDescripcion.Text,
                    Total = Convert.ToInt32(txtTotal.Text)
                };

                new Cls_FacturaIngreso().Agregar(facturaIngreso);
                MessageBox.Show("Factura guardada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                FacturaIngreso facturaIngreso = new Cls_FacturaIngreso().Consultar(Convert.ToInt32(txtFacturaIngreso.Text));
                txtFactura.Text = "" + facturaIngreso.NumeroFactura;
                dtpFecha.Text = "" + facturaIngreso.Fecha;
                txtSemana.Text = "" + facturaIngreso.Semana;
                rtxtDescripcion.Text = "" + facturaIngreso.Descripcion;
                txtTotal.Text = "" + facturaIngreso.Total;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                FacturaIngreso facturaIngreso = new FacturaIngreso
                {
                    NumeroFacturaIngreso = Convert.ToInt32(txtFacturaIngreso.Text),
                    NumeroFactura = Convert.ToInt32(txtFactura.Text),
                    Fecha = Convert.ToDateTime(dtpFecha.Text),
                    Semana = Convert.ToInt32(txtSemana.Text),
                    Descripcion = rtxtDescripcion.Text,
                    Total = Convert.ToInt32(txtTotal.Text)
                };

                new Cls_FacturaIngreso().Modificar(facturaIngreso);
                MessageBox.Show("Factura Modificada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
