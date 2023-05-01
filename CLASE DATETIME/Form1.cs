using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_DATETIME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void bttnPicker_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpDias.Value;
            MessageBox.Show("La fecha seleccionada es " + fecha1.ToString("dd/MM/yyyy"));
        }

        private void bttnCalendario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha capturada es: " + mesCalendario.SelectionStart);
        }
    }
}
