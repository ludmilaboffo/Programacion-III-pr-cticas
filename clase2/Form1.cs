using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase2
{
    public partial class FormUno : Form
    {
        public FormUno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            listViewElementos.Items.Add(elemento);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUno_Load_1(object sender, EventArgs e)
        {
            cboColorFav.Items.Add("Rojo");
            cboColorFav.Items.Add("Rosa");
            cboColorFav.Items.Add("Verde");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtPNacimiento.Value;
            // OPERADOR TERNARIO: Es como un if en una sola linea
            string chocolate =  cbxChoco.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate"; //  OPERADOR TERNARIO
            string tipo;
            if (rbBlanco.Checked)
            {
                tipo = "blanco";
            }
            else if (rbNegro.Checked)
            {
                tipo = "Negro";
            }
            else
            {
                tipo = "semi amargo";
            }
            string colorFav = cboColorFav.SelectedItem.ToString();
            string numFav = nupNumFav.Value.ToString();

            string mensaje = chocolate + ", " + " es " + tipo + ". Su color fav es: " + colorFav + ", su num fav es: " + numFav;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + " " + mensaje);
        }

        private void gbTipo_Enter(object sender, EventArgs e)
        {

        }
    }
}
