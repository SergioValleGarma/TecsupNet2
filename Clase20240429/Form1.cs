namespace Clase20240429
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "svalle")
            {

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            formMenu formMenu = new formMenu();
            formMenu.Show();
        }
    }
}
