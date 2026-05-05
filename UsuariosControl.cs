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

        private void AtualizarLista()
        {
            listBox1.Items.Clear();
            UsuariosTableAdapter UsuariosDados = new UsuariosTableAdapter();
            var dados = from linha in UsuariosDados.GetData()
                        select linha;
            foreach (UsuariosRow dado in dados) listBox1.Items.Add(dado);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

