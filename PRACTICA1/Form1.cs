using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // METODO DE LA CLASE FORM UNO AUTOGENERADO
        private void bttnDOS_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¡¡Hola Mundo!!");
            string texto = txtNOMBRE.Text;
            labelSALUDO.Text = "Hola" + texto;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Gracias por usar la app");
        }

        private void NO(object sender, EventArgs e)
        {

        }
    }
}
