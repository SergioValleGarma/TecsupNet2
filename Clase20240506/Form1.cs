using Clase20240506.Identidad;

namespace Clase20240506
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvMantenimientoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /////dgvMantenimientoUsuario.Rows.Clear();
            dgvMantenimientoUsuario.AutoGenerateColumns = false;
            List<Persona> lista = new List<Persona>();
            Persona persona = new Persona();
            persona.nombres = txtNombres.Text;
            persona.apellidos = txtApellidos.Text;
            lista.Add(persona);

            dgvMantenimientoUsuario.DataSource = lista;
        }
    }
}
