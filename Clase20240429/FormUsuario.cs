using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase20240429
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chBCasado.Checked )
            {
                lblCasado.BackColor = Color.Green;
            }else
            {
                lblCasado.BackColor= Color.Red;
            }
            if (dtpNacimiento.Value.Year < 2020 )
            {
                lblEdad.BackColor = Color.Green;
            }else
            {
                lblEdad.BackColor= Color.Red;
            }
        }
    }
}
