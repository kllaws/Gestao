using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaCliente : Form
    {
       
        public FormConsultaCliente()
        {
            InitializeComponent();
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorCPF(textBoxBuscar.Text);
                        break;
                    case 3:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarTodos();
                        break;
                        default:
                        break;

                }
                clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count ==0)
                {
                    MessageBox.Show("Nao existe cliente para ser alterado.");
                    return;

                }
                int id = ((Cliente)clienteBindingSource.Current).Id;
                using (FormCadastroCliente frm = new FormCadastroCliente(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null,null);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Nao existe registro para ser excluido");
                    return;
                }
                
                new ClienteBLL().Excluir(((Cliente)clienteBindingSource.Current).Id);
                clienteBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroCliente frm = new FormCadastroCliente())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 3;
        }
    }
}
