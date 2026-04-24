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
        // Lista simples de clientes (maneira iniciante)
        private List<Cliente> clientes;

        public FormCadastro()
        {
            InitializeComponent();
            // Inicializa a lista e configura o DataGridView (maneira iniciante)
            clientes = new List<Cliente>();
            dgvInfo.DataSource = null;
            dgvInfo.DataSource = clientes;
        }

        private void btCadatrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string telefone = mtbTelefone.Text.Trim();
            string nomePet = txtNomePet.Text.Trim();

            // Verifica se já tem o cliente cadastrado com os mesmos dados (maneira simples)
            bool existe = false;
            foreach (var c in clientes)
            {
                if (string.Equals(c.Nome?.Trim(), nome, StringComparison.OrdinalIgnoreCase)
                    && string.Equals(c.Telefone?.Trim(), telefone, StringComparison.OrdinalIgnoreCase)
                    && string.Equals(c.Nome_do_pet?.Trim(), nomePet, StringComparison.OrdinalIgnoreCase))
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                MessageBox.Show("Cliente já está cadastrado o amigão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Adiciona um novo Cliente e atualiza o DataGridView
            clientes.Add(new Cliente { Nome = nome, Telefone = telefone, Nome_do_pet = nomePet });
            dgvInfo.DataSource = null;
            dgvInfo.DataSource = clientes;
        }

        private void fnLimparFormularios()
        {
            txtNome.Clear();
            mtbTelefone.Clear();
            txtNomePet.Clear();
 
        }

        private void fnLimparTabelaCadatro()
        {
            // Limpa a lista de clientes e atualiza o DataGridView
            clientes.Clear();
            dgvInfo.DataSource = null;
            dgvInfo.DataSource = clientes;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            fnLimparFormularios();
        }

        private void btLimparTabela_Click(object sender, EventArgs e)
        {
            fnLimparTabelaCadatro();
        }


        private void fnFiltrarTabela()
        {
            var filtro = txtFiltro.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                // Restaura a lista completa
                dgvInfo.DataSource = null;
                dgvInfo.DataSource = clientes;
                return;
            }

            // Filtra pelo nome
            var filtrados = clientes.Where(c => !string.IsNullOrEmpty(c.Nome) &&
                                               c.Nome.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                                   .ToList();

            dgvInfo.DataSource = null;
            dgvInfo.DataSource = filtrados;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            fnFiltrarTabela();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
