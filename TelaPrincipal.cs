using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxHouse
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btTelaCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }

        private void btNovaVenda_Click(object sender, EventArgs e)
        {
            FormNovaVenda formNovaVenda = new FormNovaVenda();
            formNovaVenda.Show();
            this.Hide();
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionarios formCadastroFuncionarios = new FormCadastroFuncionarios();
            formCadastroFuncionarios.Show();
            this.Hide();
        }
    }
}
