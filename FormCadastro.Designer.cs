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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.btCadatrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimparTabela = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Cadastro";
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(6, 19);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.Size = new System.Drawing.Size(394, 177);
            this.dgvInfo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFechar);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.txtNomePet);
            this.groupBox1.Controls.Add(this.btCadatrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtbTelefone);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preencher informações";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(6, 105);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(69, 23);
            this.btFechar.TabIndex = 14;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(256, 105);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(69, 23);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(93, 76);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(232, 20);
            this.txtNomePet.TabIndex = 9;
            // 
            // btCadatrar
            // 
            this.btCadatrar.Location = new System.Drawing.Point(331, 105);
            this.btCadatrar.Name = "btCadatrar";
            this.btCadatrar.Size = new System.Drawing.Size(69, 23);
            this.btCadatrar.TabIndex = 5;
            this.btCadatrar.Text = "Cadastrar";
            this.btCadatrar.UseVisualStyleBackColor = true;
            this.btCadatrar.Click += new System.EventHandler(this.btCadatrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do pet:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(93, 47);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(89, 20);
            this.mtbTelefone.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // btLimparTabela
            // 
            this.btLimparTabela.Location = new System.Drawing.Point(344, 418);
            this.btLimparTabela.Name = "btLimparTabela";
            this.btLimparTabela.Size = new System.Drawing.Size(69, 23);
            this.btLimparTabela.TabIndex = 12;
            this.btLimparTabela.Text = "Limpar";
            this.btLimparTabela.UseVisualStyleBackColor = true;
            this.btLimparTabela.Click += new System.EventHandler(this.btLimparTabela_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pesquisar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(90, 180);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(264, 20);
            this.txtFiltro.TabIndex = 12;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(372, 181);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(23, 19);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "🔍";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLimparTabela);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCadatrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btLimparTabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btFechar;
    }
}