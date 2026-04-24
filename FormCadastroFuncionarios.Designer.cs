namespace BoxHouse
{
    partial class FormCadastroFuncionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ndIdade = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtComissão = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCdFuncionario = new System.Windows.Forms.Button();
            this.btLimparDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndIdade)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo:";
            // 
            // ndIdade
            // 
            this.ndIdade.Location = new System.Drawing.Point(70, 46);
            this.ndIdade.Name = "ndIdade";
            this.ndIdade.Size = new System.Drawing.Size(70, 20);
            this.ndIdade.TabIndex = 5;
            this.ndIdade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndIdade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDados);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 202);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados dos funcionarios";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 19);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(394, 177);
            this.dgvDados.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.cbCargo);
            this.groupBox1.Controls.Add(this.txtComissão);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btCdFuncionario);
            this.groupBox1.Controls.Add(this.ndIdade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 12;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(256, 151);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(69, 23);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Atendente",
            "Tosador",
            "Marketing"});
            this.cbCargo.Location = new System.Drawing.Point(70, 73);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(275, 21);
            this.cbCargo.TabIndex = 10;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtComissão
            // 
            this.txtComissão.Location = new System.Drawing.Point(70, 103);
            this.txtComissão.Name = "txtComissão";
            this.txtComissão.Size = new System.Drawing.Size(275, 20);
            this.txtComissão.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comissão:";
            // 
            // btCdFuncionario
            // 
            this.btCdFuncionario.Location = new System.Drawing.Point(331, 151);
            this.btCdFuncionario.Name = "btCdFuncionario";
            this.btCdFuncionario.Size = new System.Drawing.Size(69, 23);
            this.btCdFuncionario.TabIndex = 6;
            this.btCdFuncionario.Text = "Cadastrar";
            this.btCdFuncionario.UseVisualStyleBackColor = true;
            this.btCdFuncionario.Click += new System.EventHandler(this.btCdFuncionario_Click);
            // 
            // btLimparDGV
            // 
            this.btLimparDGV.Location = new System.Drawing.Point(343, 428);
            this.btLimparDGV.Name = "btLimparDGV";
            this.btLimparDGV.Size = new System.Drawing.Size(69, 23);
            this.btLimparDGV.TabIndex = 12;
            this.btLimparDGV.Text = "Limpar";
            this.btLimparDGV.UseVisualStyleBackColor = true;
            this.btLimparDGV.Click += new System.EventHandler(this.btLimparDGV_Click);
            // 
            // FormCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 458);
            this.Controls.Add(this.btLimparDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormCadastroFuncionarios";
            this.Text = "FormCadastroFuncionarios";
            this.Load += new System.EventHandler(this.FormCadastroFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndIdade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ndIdade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCdFuncionario;
        private System.Windows.Forms.TextBox txtComissão;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btLimparDGV;
        private System.Windows.Forms.TextBox txtNome;
    }
}