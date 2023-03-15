using BLL;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : From
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, System.EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
        }
        private void buttonAdicionarUsuario_click(object sender, System.EventArgs e)
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
          {
          frm.ShowDialog();
          }
            buttonBuscar_Click(sender, e);
    }

}