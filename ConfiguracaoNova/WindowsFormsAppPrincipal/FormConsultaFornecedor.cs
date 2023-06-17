using BLL;
using DAL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaFornecedor : Form
    {
        public FormConsultaFornecedor()
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
                            if (String.IsNullOrEmpty(textBoxBuscar.Text))
                                throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 39 } } };

                            fornecedorBindingSource.DataSource = new ClienteBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                            break;
                        case 1:
                        fornecedorBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscar.Text);
                            break;
                        case 2:
                        fornecedorBindingSource.DataSource = new ClienteBLL().BuscarPorCPF(textBoxBuscar.Text);
                            break;
                        case 3:
                        fornecedorBindingSource.DataSource = new ClienteBLL().BuscarTodos();
                            break;
                        default:
                            break;

                    }
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
                if (fornecedorBindingSource.Count == 0)
                {
                    MessageBox.Show("Nao existe cliente para ser alterado.");
                    return;

                }
                int id = ((Fornecedor)fornecedorBindingSource.Current).Id;
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);

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
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor())
                {
                    frm.ShowDialog();
                }
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

                if (fornecedorBindingSource.Count <= 0)
                {
                    MessageBox.Show("Nao existe registro para ser excluido");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este arquivo?", "Atençao", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                new FornecedorDAL().Excluir(((Fornecedor)fornecedorBindingSource.Current).Id);
                fornecedorBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
