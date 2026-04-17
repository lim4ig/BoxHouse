namespace BoxHouse
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btFinalizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItemAdd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCadatro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.ndQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(344, 403);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(69, 23);
            this.btFinalizar.TabIndex = 8;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItemAdd);
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens do Pedido";
            // 
            // dgvItemAdd
            // 
            this.dgvItemAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemAdd.Location = new System.Drawing.Point(6, 19);
            this.dgvItemAdd.Name = "dgvItemAdd";
            this.dgvItemAdd.Size = new System.Drawing.Size(394, 177);
            this.dgvItemAdd.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCadatro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.ndQuantidade);
            this.groupBox1.Controls.Add(this.cbProdutos);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção de Produto";
            // 
            // btCadatro
            // 
            this.btCadatro.Location = new System.Drawing.Point(256, 105);
            this.btCadatro.Name = "btCadatro";
            this.btCadatro.Size = new System.Drawing.Size(69, 23);
            this.btCadatro.TabIndex = 5;
            this.btCadatro.Text = "Cadastro";
            this.btCadatro.UseVisualStyleBackColor = true;
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
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(331, 105);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(69, 23);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
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
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(101, 29);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(299, 21);
            this.cbProdutos.TabIndex = 0;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(17, 397);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(150, 29);
            this.lbValorTotal.TabIndex = 7;
            this.lbValorTotal.Text = "Valor total: ";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 437);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbValorTotal);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FromCadastro_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItemAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCadatro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.NumericUpDown ndQuantidade;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.Label lbValorTotal;
    }
}