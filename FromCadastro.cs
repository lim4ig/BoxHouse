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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

            dgvInfo .Columns.Add("Nome", "Nome do Cliente");
            dgvInfo.Columns.Add("Telefone", "Telefone");
            dgvInfo.Columns.Add("Nome_do_pet", "Nome do Pet");
        }

        private void btCadatrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = mtbTelefone.Text;
            string nomePet = txtNomePet.Text;

            dgvInfo.Rows.Add(nome, telefone, nomePet);

        }

        private void fnLimparFormularios()
        {
            txtNome.Clear();
            mtbTelefone.Clear();
            txtNomePet.Clear();
 
        }

        private void fnLimparTabelaCadatro()
        {
            dgvInfo.Rows.Clear();

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            fnLimparFormularios();
        }

        private void btLimparTabela_Click(object sender, EventArgs e)
        {
            fnLimparTabelaCadatro();
        }
    }
}
