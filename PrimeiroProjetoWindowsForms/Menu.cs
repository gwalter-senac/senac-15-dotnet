using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoWindowsForms
{
    public partial class Menu : Form
    {
        public Menu(string nome)
        {
            InitializeComponent();

            labelBoasVindas.Text = $"Bem-vindo {nome}";
        }
    }
}
