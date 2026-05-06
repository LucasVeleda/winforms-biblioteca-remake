using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class FuncionarioControl : UserControl
    {
        public FuncionarioControl()
        {
            InitializeComponent();
            AtualizarLista();
        }

        public void AtualizarLista()
        {
            lboFuncionarios.Items.Clear();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();

            var dados = from linha in funcionarios.GetData()
                        select linha;
            foreach (FuncionariosRow dado in dados) lboFuncionarios.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtBoxDigiteONome.Text = " ";
            txtBoxDigiteOEmail.Text = " ";
            txtBoxDigiteOCargo.Text = " ";            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return;

            FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;

            if (funcionario == null) return;

            btnAjustes.Text = "Atualizar";
            btnAcoes.Text = "Excluir";

            txtBoxDigiteONome.Text = funcionario.NomeCompleto;
            txtBoxDigiteOEmail.Text = funcionario.Email;
            txtBoxDigiteOCargo.Text = funcionario.Cargo;
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboFuncionarios.SelectedItems == null) return;
                FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;

                if (funcionario == null) return;

                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();

                funcionarios.Delete(funcionario.ID_funcionario);

                AtualizarLista();
                limparElementos();
            }
        }

        private void btnLimparSelecao_Click(object sender, EventArgs e)
        {
            lboFuncionarios.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAcoes.Text = "Cadastrar";
            btnAjustes.Text = "Atualizar lista";
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            if (btnAjustes.Text == "Cadastrar")
            {
                string NomeCompleto = txtBoxDigiteONome.Text;
                string Email = txtBoxDigiteOEmail.Text;
                string Cargo = txtBoxDigiteOCargo.Text;
                try
                {
                    FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                    funcionarios.Insert(NomeCompleto, Email, Cargo);
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
                if(lboFuncionarios.SelectedItem == null)
                {
                    AtualizarLista();
                    limparElementos();
                    lboFuncionarios.ClearSelected();
                    return;
                }

                FuncionariosRow funcionarios = lboFuncionarios.SelectedItem as FuncionariosRow;
                if (funcionarios == null) return;
                funcionarios.NomeCompleto = txtBoxDigiteONome.Text;
                funcionarios.Email = txtBoxDigiteOEmail.Text;
                funcionarios.Cargo = txtBoxDigiteOCargo.Text;

                try
                {
                    FuncionariosTableAdapter funcionario = new FuncionariosTableAdapter();
                    funcionario.Update(funcionarios.ID_funcionario, funcionarios.NomeCompleto, funcionarios.Email, funcionarios.Cargo);
                    btnAcoes.Text = "Cadastro";
                    btnAjustes.Text = "Atualizar Lista";
                    AtualizarLista();
                    limparElementos();
                }
                
                 catch
                {
                    MessageBox.Show("Numero invalido", "Erro de digitação");
                }
                
            }
        }
    }
}
