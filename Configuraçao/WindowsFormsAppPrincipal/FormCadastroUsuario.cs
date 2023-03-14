using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.EndEdit();
            usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
        }
    }
}
