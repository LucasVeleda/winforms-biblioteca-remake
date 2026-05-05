namespace BibliotecaRemake
{
    partial class UsuariosControl
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
            this.txtProcurePorUmUsuario = new System.Windows.Forms.TextBox();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblProcurePorUmUsuario = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDigiteOTelefone = new System.Windows.Forms.Label();
            this.lblDigiteOEmail = new System.Windows.Forms.Label();
            this.lblDigiteONomeDeUsuario = new System.Windows.Forms.Label();
            this.txtBoxDigiteOTelefone = new System.Windows.Forms.TextBox();
            this.txtBoxDigiteOEmail = new System.Windows.Forms.TextBox();
            this.txtBoxDigiteONome = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProcurePorUmUsuario
            // 
            this.txtProcurePorUmUsuario.Location = new System.Drawing.Point(406, 41);
            this.txtProcurePorUmUsuario.Name = "txtProcurePorUmUsuario";
            this.txtProcurePorUmUsuario.Size = new System.Drawing.Size(336, 20);
            this.txtProcurePorUmUsuario.TabIndex = 38;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Location = new System.Drawing.Point(406, 192);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(336, 23);
            this.btnAtualizarLista.TabIndex = 37;
            this.btnAtualizarLista.Text = "Atualizar lista";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(252, 192);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(126, 23);
            this.btnRemover.TabIndex = 36;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(124, 192);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 23);
            this.btnAtualizar.TabIndex = 35;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(14, 192);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 23);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblProcurePorUmUsuario
            // 
            this.lblProcurePorUmUsuario.AutoSize = true;
            this.lblProcurePorUmUsuario.Location = new System.Drawing.Point(403, 25);
            this.lblProcurePorUmUsuario.Name = "lblProcurePorUmUsuario";
            this.lblProcurePorUmUsuario.Size = new System.Drawing.Size(119, 13);
            this.lblProcurePorUmUsuario.TabIndex = 33;
            this.lblProcurePorUmUsuario.Text = "Procure por um usuário:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(406, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 95);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDigiteOTelefone
            // 
            this.lblDigiteOTelefone.AutoSize = true;
            this.lblDigiteOTelefone.Location = new System.Drawing.Point(11, 133);
            this.lblDigiteOTelefone.Name = "lblDigiteOTelefone";
            this.lblDigiteOTelefone.Size = new System.Drawing.Size(87, 13);
            this.lblDigiteOTelefone.TabIndex = 31;
            this.lblDigiteOTelefone.Text = "Digite o telefone:";
            // 
            // lblDigiteOEmail
            // 
            this.lblDigiteOEmail.AutoSize = true;
            this.lblDigiteOEmail.Location = new System.Drawing.Point(12, 78);
            this.lblDigiteOEmail.Name = "lblDigiteOEmail";
            this.lblDigiteOEmail.Size = new System.Drawing.Size(76, 13);
            this.lblDigiteOEmail.TabIndex = 30;
            this.lblDigiteOEmail.Text = "Digite o e-mail:";
            // 
            // lblDigiteONomeDeUsuario
            // 
            this.lblDigiteONomeDeUsuario.AutoSize = true;
            this.lblDigiteONomeDeUsuario.Location = new System.Drawing.Point(12, 25);
            this.lblDigiteONomeDeUsuario.Name = "lblDigiteONomeDeUsuario";
            this.lblDigiteONomeDeUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblDigiteONomeDeUsuario.TabIndex = 29;
            this.lblDigiteONomeDeUsuario.Text = "Digite o nome:";
            // 
            // txtBoxDigiteOTelefone
            // 
            this.txtBoxDigiteOTelefone.Location = new System.Drawing.Point(14, 153);
            this.txtBoxDigiteOTelefone.Name = "txtBoxDigiteOTelefone";
            this.txtBoxDigiteOTelefone.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteOTelefone.TabIndex = 28;
            // 
            // txtBoxDigiteOEmail
            // 
            this.txtBoxDigiteOEmail.Location = new System.Drawing.Point(14, 94);
            this.txtBoxDigiteOEmail.Name = "txtBoxDigiteOEmail";
            this.txtBoxDigiteOEmail.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteOEmail.TabIndex = 27;
            // 
            // txtBoxDigiteONome
            // 
            this.txtBoxDigiteONome.Location = new System.Drawing.Point(14, 41);
            this.txtBoxDigiteONome.Name = "txtBoxDigiteONome";
            this.txtBoxDigiteONome.Size = new System.Drawing.Size(364, 20);
            this.txtBoxDigiteONome.TabIndex = 26;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(14, 241);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(165, 23);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar ";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // UsuariosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtProcurePorUmUsuario);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblProcurePorUmUsuario);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDigiteOTelefone);
            this.Controls.Add(this.lblDigiteOEmail);
            this.Controls.Add(this.lblDigiteONomeDeUsuario);
            this.Controls.Add(this.txtBoxDigiteOTelefone);
            this.Controls.Add(this.txtBoxDigiteOEmail);
            this.Controls.Add(this.txtBoxDigiteONome);
            this.Name = "UsuariosControl";
            this.Size = new System.Drawing.Size(769, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcurePorUmUsuario;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblProcurePorUmUsuario;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDigiteOTelefone;
        private System.Windows.Forms.Label lblDigiteOEmail;
        private System.Windows.Forms.Label lblDigiteONomeDeUsuario;
        private System.Windows.Forms.TextBox txtBoxDigiteOTelefone;
        private System.Windows.Forms.TextBox txtBoxDigiteOEmail;
        private System.Windows.Forms.TextBox txtBoxDigiteONome;
        private System.Windows.Forms.Button btnVoltar;
    }
}
