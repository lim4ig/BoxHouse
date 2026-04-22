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
        private DataTable dtClientes;

        public FormCadastro()
        {
            InitializeComponent();
            // Dados para o DataView
            dtClientes = new DataTable();
            dtClientes.Columns.Add("Nome", typeof(string));
            dtClientes.Columns.Add("Telefone", typeof(string));
            dtClientes.Columns.Add("Nome_do_pet", typeof(string));

            dgvInfo.DataSource = dtClientes;
        }

        private void btCadatrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string telefone = mtbTelefone.Text.Trim();
            string nomePet = txtNomePet.Text.Trim();

            // Verifica se ja tem o cliente cadastrado com os dados iguais :)
            bool existe = dtClientes.Rows.Cast<DataRow>()
                .Any(r => string.Equals((r["Nome"] as string)?.Trim(), nome, StringComparison.OrdinalIgnoreCase)
                       && string.Equals((r["Telefone"] as string)?.Trim(), telefone, StringComparison.OrdinalIgnoreCase)
                       && string.Equals((r["Nome_do_pet"] as string)?.Trim(), nomePet, StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                MessageBox.Show("Cliente já está cadastrado o amigão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtClientes.Rows.Add(nome, telefone, nomePet);

        }

        private void fnLimparFormularios()
        {
            txtNome.Clear();
            mtbTelefone.Clear();
            txtNomePet.Clear();
 
        }

        private void fnLimparTabelaCadatro()
        {
            dtClientes.Clear();

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
            var filtro = txtFiltro.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(filtro))
            {
                dtClientes.DefaultView.RowFilter = string.Empty;
                return;
            }

            // Filtra pela coluna do nome
            dtClientes.DefaultView.RowFilter = string.Format("[Nome] LIKE '%{0}%'",filtro);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            fnFiltrarTabela();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }
    }
}
