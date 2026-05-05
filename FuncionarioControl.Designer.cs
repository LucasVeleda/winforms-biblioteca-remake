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
            this.txtProcurePorUmo = new System.Windows.Forms.TextBox();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblProcurePorUmFuncionario = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDigiteOTelefone = new System.Windows.Forms.Label();
            this.lblDigiteOEmail = new System.Windows.Forms.Label();
            this.lblDigiteONomeDeUsuario = new System.Windows.Forms.Label();
            this.txtBoxDigiteOTelefone = new System.Windows.Forms.TextBox();
            this.txtBoxDigiteOEmail = new System.Windows.Forms.TextBox();
            this.txtBoxDigiteONome = new System.Windows.Forms.TextBox();
            this.btnVoltarFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProcurePorUmo
            // 
            this.txtProcurePorUmo.Location = new System.Drawing.Point(413, 39);
            this.txtProcurePorUmo.Name = "txtProcurePorUmo";
            this.txtProcurePorUmo.Size = new System.Drawing.Size(336, 20);
            this.txtProcurePorUmo.TabIndex = 51;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Location = new System.Drawing.Point(413, 190);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(336, 23);
            this.btnAtualizarLista.TabIndex = 50;
            this.btnAtualizarLista.Text = "Atualizar lista";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(259, 190);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(126, 23);
            this.btnRemover.TabIndex = 49;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(131, 190);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 23);
            this.btnAtualizar.TabIndex = 48;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(21, 190);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 23);
            this.btnCadastrar.TabIndex = 47;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(413, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 95);
            this.listBox1.TabIndex = 45;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDigiteOTelefone
            // 
            this.lblDigiteOTelefone.AutoSize = true;
            this.lblDigiteOTelefone.Location = new System.Drawing.Point(18, 131);
            this.lblDigiteOTelefone.Name = "lblDigiteOTelefone";
            this.lblDigiteOTelefone.Size = new System.Drawing.Size(87, 13);
            this.lblDigiteOTelefone.TabIndex = 44;
            this.lblDigiteOTelefone.Text = "Digite o telefone:";
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
            // txtBoxDigiteOTelefone
            // 
            this.txtBoxDigiteOTelefone.Location = new System.Drawing.Point(21, 151);
            this.txtBoxDigiteOTelefone.Name = "txtBoxDigiteOTelefone";
            this.txtBoxDigiteOTelefone.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteOTelefone.TabIndex = 41;
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
            this.btnVoltarFuncionarios.Location = new System.Drawing.Point(22, 250);
            this.btnVoltarFuncionarios.Name = "btnVoltarFuncionarios";
            this.btnVoltarFuncionarios.Size = new System.Drawing.Size(141, 23);
            this.btnVoltarFuncionarios.TabIndex = 52;
            this.btnVoltarFuncionarios.Text = "Voltar ";
            this.btnVoltarFuncionarios.UseVisualStyleBackColor = true;
            this.btnVoltarFuncionarios.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FuncionarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnVoltarFuncionarios);
            this.Controls.Add(this.txtProcurePorUmo);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblProcurePorUmFuncionario);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDigiteOTelefone);
            this.Controls.Add(this.lblDigiteOEmail);
            this.Controls.Add(this.lblDigiteONomeDeUsuario);
            this.Controls.Add(this.txtBoxDigiteOTelefone);
            this.Controls.Add(this.txtBoxDigiteOEmail);
            this.Controls.Add(this.txtBoxDigiteONome);
            this.Name = "FuncionarioControl";
            this.Size = new System.Drawing.Size(773, 295);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcurePorUmo;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblProcurePorUmFuncionario;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDigiteOTelefone;
        private System.Windows.Forms.Label lblDigiteOEmail;
        private System.Windows.Forms.Label lblDigiteONomeDeUsuario;
        private System.Windows.Forms.TextBox txtBoxDigiteOTelefone;
        private System.Windows.Forms.TextBox txtBoxDigiteOEmail;
        private System.Windows.Forms.TextBox txtBoxDigiteONome;
        private System.Windows.Forms.Button btnVoltarFuncionarios;
    }
}
