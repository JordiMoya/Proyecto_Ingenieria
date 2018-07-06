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
    public partial class frmFacturaCobro : Form
    {
        int numFila;

        public frmFacturaCobro()
        {
            InitializeComponent();
        }

        public void EstadoInicial()
        {
            txtTotalFactura.Text = ""+0;
            txtNumCasa.Text = "";
            txtMonto.Text = "";
            rtxtDescripcion.Text = "";
            txtSemana.Text = "";
            txtFactura.Text = "";

            int numFila = dtgDetalle.RowCount - 1;
            for (int i = 0; i < numFila; i++)
            {
                dtgDetalle.Rows.RemoveAt(0);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            numFila = dtgDetalle.RowCount - 1;
            bool existe = false;
            for (int i = 0; i < numFila; i++)
            {
                if (Convert.ToInt32(dtgDetalle.Rows[i].Cells[0].Value) == Convert.ToInt32(txtNumCasa.Text))
                {
                    existe = true;
                }

            }

            if (existe)
            {
                MessageBox.Show("No puede ingresar el mismo número de casa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtgDetalle.Rows.Add(numFila+1, txtNumCasa.Text, rtxtDescripcion.Text, txtMonto.Text);
                int totalActual = Convert.ToInt32(txtTotalFactura.Text);
                txtTotalFactura.Text = ""+(Convert.ToInt32(txtMonto.Text) + totalActual);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Factura factura = new Factura
                {
                    NumeroFactura= Convert.ToInt32(txtFactura.Text),
                    IdCliente = 1,
                    Semana= Convert.ToInt32(txtSemana.Text),
                    Fecha= Convert.ToDateTime(dtpFecha.Text),
                    Total = Convert.ToInt32(txtTotalFactura.Text)
                };

                new Cls_Factura().AgregarFactura(factura, dtgDetalle);
                MessageBox.Show("Permisos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFacturaCobro_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Factura factura = new Cls_Factura().Consultar(Convert.ToInt32(txtFactura.Text));
                txtSemana.Text = ""+factura.Semana;
                txtTotalFactura.Text = "" + factura.Total;
                cbxIdCliente.Text = "" + factura.IdCliente;


                new Cls_DetalleFactura_DAL().ListarDetalle(Convert.ToInt32(txtFactura.Text), dtgDetalle);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
