namespace BoxHouse
{
    partial class FormEntregas
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
            this.Entregas = new System.Windows.Forms.GroupBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCdEntrega = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.Entregas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Entregas
            // 
            this.Entregas.Controls.Add(this.cbClientes);
            this.Entregas.Controls.Add(this.btLimpar);
            this.Entregas.Controls.Add(this.cbStatus);
            this.Entregas.Controls.Add(this.txtEndereco);
            this.Entregas.Controls.Add(this.label4);
            this.Entregas.Controls.Add(this.btCdEntrega);
            this.Entregas.Controls.Add(this.label3);
            this.Entregas.Controls.Add(this.label1);
            this.Entregas.Location = new System.Drawing.Point(12, 12);
            this.Entregas.Name = "Entregas";
            this.Entregas.Size = new System.Drawing.Size(408, 130);
            this.Entregas.TabIndex = 9;
            this.Entregas.TabStop = false;
            this.Entregas.Text = "Cadastro";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Items.AddRange(new object[] {
            "Igor",
            "Paulo",
            "Guto",
            "Henderson",
            "Erica"});
            this.cbClientes.Location = new System.Drawing.Point(70, 17);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(275, 21);
            this.cbClientes.TabIndex = 12;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(256, 101);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(69, 23);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AllowDrop = true;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pendente ",
            "Atrasado",
            "Entregue"});
            this.cbStatus.Location = new System.Drawing.Point(70, 73);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(275, 21);
            this.cbStatus.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(70, 46);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(275, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endereço:";
            // 
            // btCdEntrega
            // 
            this.btCdEntrega.Location = new System.Drawing.Point(331, 101);
            this.btCdEntrega.Name = "btCdEntrega";
            this.btCdEntrega.Size = new System.Drawing.Size(69, 23);
            this.btCdEntrega.TabIndex = 6;
            this.btCdEntrega.Text = "Cadastrar";
            this.btCdEntrega.UseVisualStyleBackColor = true;
            this.btCdEntrega.Click += new System.EventHandler(this.btCdEntrega_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da entrega";
            // 
            // dgvStatus
            // 
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(6, 19);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Size = new System.Drawing.Size(394, 177);
            this.dgvStatus.TabIndex = 3;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(343, 363);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(69, 23);
            this.btAtualizar.TabIndex = 13;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Entregas);
            this.Name = "FormEntregas";
            this.Text = "FormEntregas";
            this.Entregas.ResumeLayout(false);
            this.Entregas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Entregas;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCdEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Button btAtualizar;
    }
}