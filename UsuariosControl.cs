using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class UsuariosControl : UserControl
    {
        //public QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();

        public UsuariosControl()
        {
            InitializeComponent();
            btnAcoes.Text = "Cadastrar";
            btnAjustes.Text = "Atualizar Lista";
            AtualizarLista();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //queriesTableAdapter.InserirUsuario(
            //    txtBoxDigiteONome.Text,
            //    txtBoxDigiteOEmail.Text,
            //    txtBoxDigiteOTelefone.Text
            //    );

            MessageBox.Show("Usuário Cadastrado com Sucesso");
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            AtualizarLista();

        }

        private void limparElementos()
        {
            txtBoxDigiteONome.Clear();
            txtBoxDigiteOEmail.Clear();
            txtBoxDigiteOTelefone.Clear();
        }

        private void AtualizarLista()
        {
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter UsuariosDados = new UsuariosTableAdapter();
            var dados = from linha in UsuariosDados.GetData()
                        select linha;
            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;

            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;

            if (usuario == null) return;

            btnAcoes.Text = "Excluir";
            btnAjustes.Text = "Atualizar";

            txtBoxDigiteONome.Text = usuario.Nome;
            txtBoxDigiteOEmail.Text = usuario.Email;
            txtBoxDigiteOTelefone.Text = usuario.Telefone;
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboUsuarios.SelectedItems == null) return;
                LivrosRow livro = lboUsuarios.SelectedItem as LivrosRow;
                if (livro == null) return;
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);
                AtualizarLista();
                limparElementos();
            }
        }
    }
    }

