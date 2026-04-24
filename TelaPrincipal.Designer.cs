namespace BoxHouse
{
    partial class TelaPrincipal
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
            this.btTelaCadastro = new System.Windows.Forms.Button();
            this.btFuncionarios = new System.Windows.Forms.Button();
            this.btEntregas = new System.Windows.Forms.Button();
            this.btNovaVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTelaCadastro
            // 
            this.btTelaCadastro.Location = new System.Drawing.Point(12, 12);
            this.btTelaCadastro.Name = "btTelaCadastro";
            this.btTelaCadastro.Size = new System.Drawing.Size(289, 116);
            this.btTelaCadastro.TabIndex = 0;
            this.btTelaCadastro.Text = "Cadastro";
            this.btTelaCadastro.UseVisualStyleBackColor = true;
            this.btTelaCadastro.Click += new System.EventHandler(this.btTelaCadastro_Click);
            // 
            // btFuncionarios
            // 
            this.btFuncionarios.Location = new System.Drawing.Point(12, 134);
            this.btFuncionarios.Name = "btFuncionarios";
            this.btFuncionarios.Size = new System.Drawing.Size(289, 116);
            this.btFuncionarios.TabIndex = 1;
            this.btFuncionarios.Text = "Funcionarios";
            this.btFuncionarios.UseVisualStyleBackColor = true;
            this.btFuncionarios.Click += new System.EventHandler(this.btFuncionarios_Click);
            // 
            // btEntregas
            // 
            this.btEntregas.Location = new System.Drawing.Point(307, 134);
            this.btEntregas.Name = "btEntregas";
            this.btEntregas.Size = new System.Drawing.Size(289, 116);
            this.btEntregas.TabIndex = 2;
            this.btEntregas.Text = "Entregas";
            this.btEntregas.UseVisualStyleBackColor = true;
            this.btEntregas.Click += new System.EventHandler(this.btEntregas_Click);
            // 
            // btNovaVenda
            // 
            this.btNovaVenda.Location = new System.Drawing.Point(307, 12);
            this.btNovaVenda.Name = "btNovaVenda";
            this.btNovaVenda.Size = new System.Drawing.Size(289, 116);
            this.btNovaVenda.TabIndex = 3;
            this.btNovaVenda.Text = "Vendas";
            this.btNovaVenda.UseVisualStyleBackColor = true;
            this.btNovaVenda.Click += new System.EventHandler(this.btNovaVenda_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 261);
            this.Controls.Add(this.btNovaVenda);
            this.Controls.Add(this.btEntregas);
            this.Controls.Add(this.btFuncionarios);
            this.Controls.Add(this.btTelaCadastro);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTelaCadastro;
        private System.Windows.Forms.Button btFuncionarios;
        private System.Windows.Forms.Button btEntregas;
        private System.Windows.Forms.Button btNovaVenda;
    }
}