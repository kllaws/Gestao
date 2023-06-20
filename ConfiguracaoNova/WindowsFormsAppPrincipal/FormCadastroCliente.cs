﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroCliente : Form
    {
        int id;
        public FormCadastroCliente(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Cliente cliente = (Cliente)clienteBindingSource.Current;
                clienteBindingSource.EndEdit();
                if (id ==0)
                    new ClienteBLL().Inserir(cliente);
                else
                    new ClienteBLL().Alterar(cliente);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)    
                clienteBindingSource.AddNew();
                else 
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cPFTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
