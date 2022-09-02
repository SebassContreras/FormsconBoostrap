using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormBosstrap : Form
    {
        public FormBosstrap()
        {
            InitializeComponent();
        }

        

        private void butmostrar_Click(object sender, EventArgs e)
        {
            if (checkAceptar.Checked)
            {
                MessageBox.Show("Aceptaste wuachin");
            }
            if (radHombre.Checked)
            {
                MessageBox.Show("AHombre");
            }
            if (radOtro.Checked)
            {
                MessageBox.Show("otro");
            }
            if (radMujer.Checked)
            {
                MessageBox.Show("mujer");
            }
           
            if (listPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algo");
            }
            else
            {
                MessageBox.Show("Elegiste: " + listPaises.SelectedItem);
            }

        }

    
    }
}
