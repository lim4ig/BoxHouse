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
                new Produto("Camiseta", 29.99m),
                new Produto("Calça Jeans", 79.99m),
                new Produto("Tênis", 149.99m)
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
    }
}
