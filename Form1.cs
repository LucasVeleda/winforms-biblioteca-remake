using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Form1 : Form
    {
 
        private Livros livros;

        private UsuariosControl usuarios;

        private FuncionarioControl funcionarios;

        private EmprestimosControl emprestimos;


        public Form1() // esse código todo ele só 
        {
            InitializeComponent();
            livros = new Livros();
            livros.Dock = DockStyle.Fill;
            tpLivros.Controls.Add(livros);
            livros.Controls.Find("btnVoltarLivros", true).First().Click += VoltarTelaPrincipal;

            usuarios = new UsuariosControl();
            usuarios.Dock = DockStyle.Fill;
            tpUsuarios.Controls.Add(usuarios);
            usuarios.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal;  //Localiza o botão btnErro, verifica se existe, retorna o primeiro e adiciona a função de click.

            funcionarios = new FuncionarioControl();
            funcionarios.Dock = DockStyle.Fill;
            tpFuncionarios.Controls.Add(funcionarios);
            funcionarios.Controls.Find("btnVoltarFuncionarios", true).First().Click += VoltarTelaPrincipal;

            emprestimos = new EmprestimosControl();
            usuarios.Dock = DockStyle.Fill;
            tpEmprestimos.Controls.Add(emprestimos);
            emprestimos.Controls.Find("btnVoltarEmprestimos", true).First().Click += VoltarTelaPrincipal;
        }

        private void VoltarTelaPrincipal(object quemChama, EventArgs evento)
        {
            tcControle.SelectTab(tpTelaPrincipal);
        }


        private void btnLivros_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpLivros);
            Size = new System.Drawing.Size(800, 600);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosControl usuarios = new UsuariosControl();
            usuarios.Dock = DockStyle.Fill;
            tpUsuarios.Controls.Add(usuarios);

            tcControle.SelectTab(tpUsuarios);
        }


        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionarioControl funcionarioControl = new FuncionarioControl();
            funcionarioControl.Dock = DockStyle.Fill;
            tpFuncionarios.Controls.Add(funcionarioControl);

            tcControle.SelectTab(tpFuncionarios);
        }

        private void btnEmprestismos_Click(object sender, EventArgs e)
        {
            EmprestimosControl emprestimos = new EmprestimosControl();
            emprestimos.Dock = DockStyle.Fill;
            tpEmprestimos.Controls.Add(emprestimos);

            tcControle.SelectTab(tpEmprestimos);

        }
    }
}
