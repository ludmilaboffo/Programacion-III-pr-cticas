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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {   // creo una nueva instancia del objeto formUno
            FormUno ventana = new FormUno();
            ventana.ShowDialog();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // vamos a validar para asegurarnos que no abra multiples ventanas a la vez
            
            foreach(var item in Application.OpenForms){
                if(item.GetType() == typeof(FormUno))           
                    return;
                
            }
            
            // creo una nueva instancia del objeto formUno
            FormUno ventana = new FormUno();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
