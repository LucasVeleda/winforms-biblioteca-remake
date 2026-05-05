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

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
