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
    public partial class formMenuFinal : Form
    {
        public formMenuFinal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMenu formMenu = new formMenu();
            formMenu.ShowDialog();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formProducto formProducto = new formProducto();
            formProducto.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.ShowDialog();  
        }
    }
}
