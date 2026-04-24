using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxHouse
{
    public partial class FormEntregas : Form
    {
        private BindingList<Entrega> entregasList;

        public FormEntregas()
        {
            InitializeComponent();

            entregasList = new BindingList<Entrega>();
            dgvStatus.Columns.Add("Cliente", "Cliente");
            dgvStatus.Columns.Add("Endereco", "Endereço");
            dgvStatus.Columns.Add("Status", "Status");
        }

        private void btCdEntrega_Click(object sender, EventArgs e)
        {
            string endereco = txtEndereco.Text;
            string cliente = cbClientes.SelectedItem?.ToString() ?? string.Empty;
            string status = cbStatus.SelectedItem?.ToString() ?? string.Empty;

            dgvStatus.Rows.Add(cliente, endereco, status);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            string status = cbStatus.Text;
            string statusSelecionado = dgvStatus.CurrentRow.Cells["Status"].Value.ToString();
            dgvStatus.CurrentRow.Cells["Status"].Value = status;
            dgvStatus.Refresh();

        }
    }
}
