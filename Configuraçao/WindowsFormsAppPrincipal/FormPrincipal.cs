using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (Form1BuscarUsuariocs frm = new Form1BuscarUsuariocs())
            {
                frm.ShowDialog();
            }

        }
    }
}
