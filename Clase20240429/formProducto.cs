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
    public partial class formProducto : Form
    {
        public formProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMenu formMenu = new formMenu();
            formMenu.Show(this);
        }
    }
}
