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
    public partial class FormNovaVenda : Form
    {
        public FormNovaVenda()
        {
            InitializeComponent();

            List<Produto> listaProdutos = new List<Produto>
            {
                new Produto("Mordedor", 29.99m),
                new Produto("Ração", 79.99m),
                new Produto("Coleira", 149.99m)
            };

            cbProdutos.DataSource = listaProdutos;
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "Preco";
            //cbProdutos.ValueMember = "Quantidade";
            dgvItemAdd.Columns.Add("Produto", "Produto");
            dgvItemAdd.Columns.Add("Preco", "Preço Unitario");
            dgvItemAdd.Columns.Add("Quantidade", "Quantidade");
            dgvItemAdd.Columns.Add("Total", "Total");

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string nome = cbProdutos.Text;
            decimal preco = (decimal)cbProdutos.SelectedValue;
            int quantidade = (int)ndQuantidade.Value;



            dgvItemAdd.Rows.Add(nome, preco, quantidade, (preco * quantidade));

            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            decimal valor_total = 0;
            valor_total = dgvItemAdd.Rows.Cast<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells["Total"].Value));

            MessageBox.Show($"Valor total da venda: R$ {valor_total:F2}", "Venda Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
