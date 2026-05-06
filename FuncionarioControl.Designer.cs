namespace BibliotecaRemake
{
    partial class FuncionarioControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProcureFuncionario = new System.Windows.Forms.TextBox();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblProcurePorUmFuncionario = new System.Windows.Forms.Label();
            this.lboFuncionarios = new System.Windows.Forms.ListBox();
            this.lblDigiteOTCargo = new System.Windows.Forms.Label();
            this.lblDigiteOEmail = new System.Windows.Forms.Label();
            this.lblDigiteONomeDeUsuario = new System.Windows.Forms.Label();
            this.txtBoxDigiteOCargo = new System.Windows.Forms.TextBox();
            this.txtBoxDigiteOEmail = new System.Windows.Forms.TextBox();
            this.txtBoxDigiteONome = new System.Windows.Forms.TextBox();
            this.btnVoltarFuncionarios = new System.Windows.Forms.Button();
            this.btnLimparSelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProcureFuncionario
            // 
            this.txtProcureFuncionario.Location = new System.Drawing.Point(413, 39);
            this.txtProcureFuncionario.Name = "txtProcureFuncionario";
            this.txtProcureFuncionario.Size = new System.Drawing.Size(336, 20);
            this.txtProcureFuncionario.TabIndex = 51;
            // 
            // btnAcoes
            // 
            this.btnAcoes.Location = new System.Drawing.Point(214, 198);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(171, 23);
            this.btnAcoes.TabIndex = 48;
            this.btnAcoes.Text = "Atualizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Location = new System.Drawing.Point(21, 198);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(171, 23);
            this.btnAjustes.TabIndex = 47;
            this.btnAjustes.Text = "Cadastrar";
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // lblProcurePorUmFuncionario
            // 
            this.lblProcurePorUmFuncionario.AutoSize = true;
            this.lblProcurePorUmFuncionario.Location = new System.Drawing.Point(410, 23);
            this.lblProcurePorUmFuncionario.Name = "lblProcurePorUmFuncionario";
            this.lblProcurePorUmFuncionario.Size = new System.Drawing.Size(137, 13);
            this.lblProcurePorUmFuncionario.TabIndex = 46;
            this.lblProcurePorUmFuncionario.Text = "Procure por um funcionário:";
            // 
            // lboFuncionarios
            // 
            this.lboFuncionarios.FormattingEnabled = true;
            this.lboFuncionarios.Location = new System.Drawing.Point(413, 76);
            this.lboFuncionarios.Name = "lboFuncionarios";
            this.lboFuncionarios.Size = new System.Drawing.Size(336, 134);
            this.lboFuncionarios.TabIndex = 45;
            this.lboFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDigiteOTCargo
            // 
            this.lblDigiteOTCargo.AutoSize = true;
            this.lblDigiteOTCargo.Location = new System.Drawing.Point(18, 131);
            this.lblDigiteOTCargo.Name = "lblDigiteOTCargo";
            this.lblDigiteOTCargo.Size = new System.Drawing.Size(76, 13);
            this.lblDigiteOTCargo.TabIndex = 44;
            this.lblDigiteOTCargo.Text = "Digite o cargo:";
            // 
            // lblDigiteOEmail
            // 
            this.lblDigiteOEmail.AutoSize = true;
            this.lblDigiteOEmail.Location = new System.Drawing.Point(19, 76);
            this.lblDigiteOEmail.Name = "lblDigiteOEmail";
            this.lblDigiteOEmail.Size = new System.Drawing.Size(76, 13);
            this.lblDigiteOEmail.TabIndex = 43;
            this.lblDigiteOEmail.Text = "Digite o e-mail:";
            // 
            // lblDigiteONomeDeUsuario
            // 
            this.lblDigiteONomeDeUsuario.AutoSize = true;
            this.lblDigiteONomeDeUsuario.Location = new System.Drawing.Point(19, 23);
            this.lblDigiteONomeDeUsuario.Name = "lblDigiteONomeDeUsuario";
            this.lblDigiteONomeDeUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblDigiteONomeDeUsuario.TabIndex = 42;
            this.lblDigiteONomeDeUsuario.Text = "Digite o nome:";
            // 
            // txtBoxDigiteOCargo
            // 
            this.txtBoxDigiteOCargo.Location = new System.Drawing.Point(21, 151);
            this.txtBoxDigiteOCargo.Name = "txtBoxDigiteOCargo";
            this.txtBoxDigiteOCargo.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteOCargo.TabIndex = 41;
            // 
            // txtBoxDigiteOEmail
            // 
            this.txtBoxDigiteOEmail.Location = new System.Drawing.Point(21, 92);
            this.txtBoxDigiteOEmail.Name = "txtBoxDigiteOEmail";
            this.txtBoxDigiteOEmail.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteOEmail.TabIndex = 40;
            // 
            // txtBoxDigiteONome
            // 
            this.txtBoxDigiteONome.Location = new System.Drawing.Point(21, 39);
            this.txtBoxDigiteONome.Name = "txtBoxDigiteONome";
            this.txtBoxDigiteONome.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteONome.TabIndex = 39;
            // 
            // btnVoltarFuncionarios
            // 
            this.btnVoltarFuncionarios.Location = new System.Drawing.Point(21, 245);
            this.btnVoltarFuncionarios.Name = "btnVoltarFuncionarios";
            this.btnVoltarFuncionarios.Size = new System.Drawing.Size(103, 23);
            this.btnVoltarFuncionarios.TabIndex = 52;
            this.btnVoltarFuncionarios.Text = "Voltar ";
            this.btnVoltarFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnLimparSelecao
            // 
            this.btnLimparSelecao.Location = new System.Drawing.Point(413, 216);
            this.btnLimparSelecao.Name = "btnLimparSelecao";
            this.btnLimparSelecao.Size = new System.Drawing.Size(336, 23);
            this.btnLimparSelecao.TabIndex = 53;
            this.btnLimparSelecao.Text = "Limpar Seleção";
            this.btnLimparSelecao.UseVisualStyleBackColor = true;
            this.btnLimparSelecao.Click += new System.EventHandler(this.btnLimparSelecao_Click);
            // 
            // FuncionarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnLimparSelecao);
            this.Controls.Add(this.btnVoltarFuncionarios);
            this.Controls.Add(this.txtProcureFuncionario);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.lblProcurePorUmFuncionario);
            this.Controls.Add(this.lboFuncionarios);
            this.Controls.Add(this.lblDigiteOTCargo);
            this.Controls.Add(this.lblDigiteOEmail);
            this.Controls.Add(this.lblDigiteONomeDeUsuario);
            this.Controls.Add(this.txtBoxDigiteOCargo);
            this.Controls.Add(this.txtBoxDigiteOEmail);
            this.Controls.Add(this.txtBoxDigiteONome);
            this.Name = "FuncionarioControl";
            this.Size = new System.Drawing.Size(773, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcureFuncionario;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Label lblProcurePorUmFuncionario;
        private System.Windows.Forms.ListBox lboFuncionarios;
        private System.Windows.Forms.Label lblDigiteOTCargo;
        private System.Windows.Forms.Label lblDigiteOEmail;
        private System.Windows.Forms.Label lblDigiteONomeDeUsuario;
        private System.Windows.Forms.TextBox txtBoxDigiteOCargo;
        private System.Windows.Forms.TextBox txtBoxDigiteOEmail;
        private System.Windows.Forms.TextBox txtBoxDigiteONome;
        private System.Windows.Forms.Button btnVoltarFuncionarios;
        private System.Windows.Forms.Button btnLimparSelecao;
    }
}
