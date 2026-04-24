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
    public partial class FormCadastroFuncionarios : Form
    {
        private List<Funcionarios> funcionariosList;

        public FormCadastroFuncionarios()
        {
            InitializeComponent();
            funcionariosList = new List<Funcionarios>();

            dgvDados.Columns.Add("Nome", "Nome");
            dgvDados.Columns.Add("Idade", "Idade");
            dgvDados.Columns.Add("Cargo", "Cargo");
            dgvDados.Columns.Add("Comissao", "Comissão");
        }

        private void FormCadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ndIdade.Minimum = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCdFuncionario_Click(object sender, EventArgs e)
        {
            //Nome funcionario
            string nome = txtNome.Text.Trim();
            if (nome.Length == 0)
            {
                MessageBox.Show("Nome do funcionario é necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Idade funcionario
            int idade = (int)ndIdade.Value;
            if (idade == 0)
            {
                MessageBox.Show("Idade do funcionario é necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (idade <= 16)
            {
                MessageBox.Show("Idade do funcionario deve ser maior que 16 anos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Cargo funcionario
            string cargo = cbCargo.Text.Trim();
            if (cargo.Length == 0)
            {
                MessageBox.Show("Cargo do funcionario é necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Valor vendas funcionario
            string vendas = txtComissão.Text.Trim();
            if (vendas.Length == 0)
            {
                MessageBox.Show("Informe o valor de vendas do funcionário no campo Comissão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double vendasValue;
            if (!double.TryParse(vendas, out vendasValue))
            {
                MessageBox.Show("Valor de vendas inválido. Use apenas números (por exemplo: 350.50).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double comissaoCalculada = 0.0;
            if (vendasValue > 500.0)
            {
                comissaoCalculada = vendasValue * 0.05;
            }

            Funcionarios funcionarios = new Funcionarios
            {
                nome = nome,
                idade = idade,
                cargo = cargo
            };

            funcionariosList.Add(funcionarios);

            dgvDados.Rows.Add(funcionarios.nome, funcionarios.idade, funcionarios.cargo, comissaoCalculada.ToString("C2"));
        }


        private void fnLimparCampos()
        {
            txtNome.Clear();
            ndIdade.Value = 1;
            cbCargo.SelectedIndex = -1;
            txtComissão.Clear();
        }

        private void fnLimparTabela()
        {
            dgvDados.Rows.Clear();
            funcionariosList.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            fnLimparCampos();
        }

        private void btLimparDGV_Click(object sender, EventArgs e)
        {
            fnLimparTabela();
        }
    }
}
