namespace BibliotecaRemake
{
    partial class Livros
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
            this.lblLivros = new System.Windows.Forms.Label();
            this.btnLimparSelecao = new System.Windows.Forms.Button();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnVoltarLivros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Location = new System.Drawing.Point(410, 30);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(35, 13);
            this.lblLivros.TabIndex = 34;
            this.lblLivros.Text = "Livros";
            // 
            // btnLimparSelecao
            // 
            this.btnLimparSelecao.Location = new System.Drawing.Point(413, 416);
            this.btnLimparSelecao.Name = "btnLimparSelecao";
            this.btnLimparSelecao.Size = new System.Drawing.Size(324, 23);
            this.btnLimparSelecao.TabIndex = 33;
            this.btnLimparSelecao.Text = "Limpar Seleção";
            this.btnLimparSelecao.UseVisualStyleBackColor = true;
            this.btnLimparSelecao.Click += new System.EventHandler(this.btnLimparSelecao_Click);
            // 
            // lboLivros
            // 
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(413, 55);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(324, 355);
            this.lboLivros.TabIndex = 32;
            this.lboLivros.SelectedIndexChanged += new System.EventHandler(this.lboLivros_SelectedIndexChanged);
            // 
            // btnAcoes
            // 
            this.btnAcoes.Location = new System.Drawing.Point(206, 416);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(166, 23);
            this.btnAcoes.TabIndex = 31;
            this.btnAcoes.Text = "Atualizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = true;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Location = new System.Drawing.Point(21, 416);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(179, 23);
            this.btnAjustes.TabIndex = 30;
            this.btnAjustes.Text = "Cadastrar";
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(21, 351);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 13);
            this.lblIsbn.TabIndex = 29;
            this.lblIsbn.Text = "ISBN";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(21, 288);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 28;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(21, 223);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 27;
            this.lblEditora.Text = "Editora";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 159);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 26;
            this.lblGenero.Text = "Genero";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(21, 93);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 25;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(21, 367);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(351, 20);
            this.txtIsbn.TabIndex = 23;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(21, 304);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(351, 20);
            this.txtQuantidade.TabIndex = 22;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(21, 239);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(351, 20);
            this.txtEditora.TabIndex = 21;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(21, 175);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(351, 20);
            this.txtGenero.TabIndex = 20;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(21, 109);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(351, 20);
            this.txtAutor.TabIndex = 19;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(21, 49);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(351, 20);
            this.txtTitulo.TabIndex = 18;
            // 
            // btnVoltarLivros
            // 
            this.btnVoltarLivros.Location = new System.Drawing.Point(21, 463);
            this.btnVoltarLivros.Name = "btnVoltarLivros";
            this.btnVoltarLivros.Size = new System.Drawing.Size(165, 23);
            this.btnVoltarLivros.TabIndex = 40;
            this.btnVoltarLivros.Text = "Voltar ";
            this.btnVoltarLivros.UseVisualStyleBackColor = true;
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnVoltarLivros);
            this.Controls.Add(this.lblLivros);
            this.Controls.Add(this.btnLimparSelecao);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Name = "Livros";
            this.Size = new System.Drawing.Size(758, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Button btnLimparSelecao;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnVoltarLivros;
    }
}
