namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
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
