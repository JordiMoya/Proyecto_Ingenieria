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
    public partial class frmControlHoras : Form
    {
        public frmControlHoras()
        {
            InitializeComponent();
        }

       

        private void frmControlHoras_Load(object sender, EventArgs e)
        {
            cbxDia.Items.Add("Lunes");
            cbxDia.Items.Add("Martes");
            cbxDia.Items.Add("Miércoles");
            cbxDia.Items.Add("Jueves");
            cbxDia.Items.Add("Viernes");
            cbxDia.Items.Add("Sábado");
        }
    }
}
