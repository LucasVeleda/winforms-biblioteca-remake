using System.Linq.Expressions;

namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        partial class FuncionariosDataTable
        {
        }

        partial class FuncionariosRow
        {
            public string nomeUsuario { 
                get
                {
                    try
                    {
                        
                        return NomeUsuario;
                    }

                    catch
                    {
                        return "";
                    }
                }
            }
            public override string ToString()
            {
                return this.ID_funcionario + " - " + this.nomeUsuario;
            }
        }

        partial class UsuariosDataTable
        {
        }

        partial class LivrosDataTable
        {
        }

        partial class UsuariosRow
        {
            public override string ToString()
            {
                return Id.ToString() + "-" + Nome;
            }
        }
        partial class LivrosRow
        {
            public override string ToString()
            {
                return LivroID.ToString() + "-" + Titulo;
            }
        }
    }
}
