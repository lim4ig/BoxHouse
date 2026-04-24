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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtComissão = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.btCdFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Entregas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entregas
            // 
            this.Entregas.Controls.Add(this.comboBox1);
            this.Entregas.Controls.Add(this.btLimpar);
            this.Entregas.Controls.Add(this.cbCargo);
            this.Entregas.Controls.Add(this.txtComissão);
            this.Entregas.Controls.Add(this.label4);
            this.Entregas.Controls.Add(this.btFechar);
            this.Entregas.Controls.Add(this.btCdFuncionario);
            this.Entregas.Controls.Add(this.label3);
            this.Entregas.Controls.Add(this.label1);
            this.Entregas.Location = new System.Drawing.Point(12, 12);
            this.Entregas.Name = "Entregas";
            this.Entregas.Size = new System.Drawing.Size(408, 130);
            this.Entregas.TabIndex = 9;
            this.Entregas.TabStop = false;
            this.Entregas.Text = "Cadastro";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Igor",
            "Paulo",
            "Guto",
            "Henderson",
            "Erica"});
            this.comboBox1.Location = new System.Drawing.Point(70, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 12;
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
            // cbCargo
            // 
            this.cbCargo.AllowDrop = true;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Pendente ",
            "Atrasado",
            "Entregue"});
            this.cbCargo.Location = new System.Drawing.Point(70, 73);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(275, 21);
            this.cbCargo.TabIndex = 10;
            // 
            // txtComissão
            // 
            this.txtComissão.Location = new System.Drawing.Point(70, 46);
            this.txtComissão.Name = "txtComissão";
            this.txtComissão.Size = new System.Drawing.Size(275, 20);
            this.txtComissão.TabIndex = 9;
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
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(9, 101);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(69, 23);
            this.btFechar.TabIndex = 7;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            // 
            // btCdFuncionario
            // 
            this.btCdFuncionario.Location = new System.Drawing.Point(331, 101);
            this.btCdFuncionario.Name = "btCdFuncionario";
            this.btCdFuncionario.Size = new System.Drawing.Size(69, 23);
            this.btCdFuncionario.TabIndex = 6;
            this.btCdFuncionario.Text = "Cadastrar";
            this.btCdFuncionario.UseVisualStyleBackColor = true;
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
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.Entregas);
            this.Name = "FormEntregas";
            this.Text = "FormEntregas";
            this.Entregas.ResumeLayout(false);
            this.Entregas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Entregas;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.TextBox txtComissão;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCdFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}