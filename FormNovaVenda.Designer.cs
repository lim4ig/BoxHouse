namespace BoxHouse
{
    partial class FormNovaVenda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.ndQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dgvItemAdd = new System.Windows.Forms.DataGridView();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(101, 29);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(299, 21);
            this.cbProdutos.TabIndex = 0;
            // 
            // ndQuantidade
            // 
            this.ndQuantidade.Location = new System.Drawing.Point(101, 56);
            this.ndQuantidade.Name = "ndQuantidade";
            this.ndQuantidade.Size = new System.Drawing.Size(179, 20);
            this.ndQuantidade.TabIndex = 1;
            this.ndQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuantidade.ValueChanged += new System.EventHandler(this.ndQuantidade_ValueChanged);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(331, 105);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(69, 23);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dgvItemAdd
            // 
            this.dgvItemAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemAdd.Location = new System.Drawing.Point(6, 19);
            this.dgvItemAdd.Name = "dgvItemAdd";
            this.dgvItemAdd.ReadOnly = true;
            this.dgvItemAdd.Size = new System.Drawing.Size(394, 177);
            this.dgvItemAdd.TabIndex = 3;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(18, 399);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(150, 29);
            this.lbValorTotal.TabIndex = 4;
            this.lbValorTotal.Text = "Valor total: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFechar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.ndQuantidade);
            this.groupBox1.Controls.Add(this.cbProdutos);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItemAdd);
            this.groupBox2.Location = new System.Drawing.Point(14, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 202);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens do Pedido";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(345, 405);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(69, 23);
            this.btFinalizar.TabIndex = 5;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(9, 105);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(69, 23);
            this.btFechar.TabIndex = 5;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 437);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbValorTotal);
            this.Name = "FormNovaVenda";
            this.Text = "FormNovaVenda";
            this.Load += new System.EventHandler(this.FormNovaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.NumericUpDown ndQuantidade;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView dgvItemAdd;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Button btFechar;
    }
}

