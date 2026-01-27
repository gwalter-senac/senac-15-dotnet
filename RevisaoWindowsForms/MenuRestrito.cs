using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoWindowsForms
{
    public partial class MenuRestrito : Form
    {
        private string nomeUsuarioLogado;

        public MenuRestrito(string nomeUsuarioLogado)
        {
            InitializeComponent();

            this.nomeUsuarioLogado = nomeUsuarioLogado;
            lblUsuarioLogado.Text = $"Bem vindo {this.nomeUsuarioLogado}";
        }
    }
}
