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
    public partial class formRegistroProducto : Form
    {
        List<Producto> productos = new List<Producto>();
        public formRegistroProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto{
                nombre=txtProducto.Text,
                precio=Convert.ToDouble(txtPrecio.Text),
                categoria=Convert.ToString(cmbCategoria.SelectedItem)
            };
            productos.Add(producto);

            dgvProducto.DataSource = productos;

        }
    }
}
