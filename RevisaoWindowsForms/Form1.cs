namespace RevisaoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MenuRestrito menuRestrito = new MenuRestrito(txtUsuario.Text);

            menuRestrito.Show();
        }
    }
}
