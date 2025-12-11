namespace PrimeiroProjetoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text;

            Menu menu = new Menu(nome);
            menu.Show();

            this.Visible = false;
        }
    }
}
