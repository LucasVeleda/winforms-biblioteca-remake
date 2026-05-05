using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class Livros : UserControl
    {
        public Livros()
        {
            InitializeComponent();
            AtualizarLista();
            
        }

        private void AtualizarLista()
        {
            lboLivros.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;
            foreach (LivrosRow dado in dados) lboLivros.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtTitulo.Text = " ";
            txtAutor.Text = " ";
            txtEditora.Text = " ";
            txtGenero.Text = " ";
            txtIsbn.Text = " ";
            txtQuantidade.Text = " ";
        }

        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null) return;
            LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
            if (livro == null) return;
            btnAjustes.Text = "Atualizar";
            btnAcoes.Text = "Excluir";
            txtTitulo.Text = livro.Titulo;
            txtGenero.Text = livro.Genero;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
            txtEditora.Text = livro.Editora;
            txtIsbn.Text = livro.ISBN;
            txtAutor.Text = livro.Autor;
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboLivros.SelectedItems == null) return;
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);
                AtualizarLista();
                limparElementos();
            }
        }

        private void btnLimparSelecao_Click(object sender, EventArgs e)
        {
            lboLivros.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAcoes.Text = "Cadastrar";
            btnAjustes.Text = "Atualizar lista";
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            if (btnAjustes.Text == "Cadastrar")
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editora = txtGenero.Text;
                string genero = txtGenero.Text;
                string isbn = txtGenero.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Insert(titulo, genero, autor, editora, isbn, quantidade);
                    limparElementos();
                    AtualizarLista();
                }
             catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
                                                           
            }
            else
            {
                if (lboLivros.SelectedItem == null)
                {
                    AtualizarLista();
                    limparElementos();
                    lboLivros.ClearSelected();
                    return;
                }

                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.ISBN = txtIsbn.Text;
                livro.Genero = txtGenero.Text;
                livro.Editora = txtEditora.Text;

                try
                {
                    livro.QuantidadeDisponivel = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Update(livro.LivroID, livro.Titulo, livro.Autor, livro.Editora, livro.Editora, livro.ISBN, livro.QuantidadeDisponivel);
                    btnAcoes.Text = "Cadastro";
                    btnAjustes.Text = "Atualizar Lista";
                    AtualizarLista();
                    limparElementos();
                }
                catch
                {
                    MessageBox.Show("Numero invalido", "Erro de Digitação");
                }
            }
        }
    }
}
