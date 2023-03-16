namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarGrupoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grupoUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCancelarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource1
            // 
            this.grupoUsuarioBindingSource1.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView1
            // 
            this.grupoUsuarioDataGridView1.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView1.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView1.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView1.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView1.DataSource = this.grupoUsuarioBindingSource1;
            this.grupoUsuarioDataGridView1.Location = new System.Drawing.Point(25, 117);
            this.grupoUsuarioDataGridView1.Name = "grupoUsuarioDataGridView1";
            this.grupoUsuarioDataGridView1.ReadOnly = true;
            this.grupoUsuarioDataGridView1.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView1.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView1.Size = new System.Drawing.Size(874, 321);
            this.grupoUsuarioDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "ConsultarGrupoUsuario";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(664, 22);
            this.textBox2.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(835, 89);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarConsulta
            // 
            this.buttonCancelarConsulta.Location = new System.Drawing.Point(835, 474);
            this.buttonCancelarConsulta.Name = "buttonCancelarConsulta";
            this.buttonCancelarConsulta.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarConsulta.TabIndex = 4;
            this.buttonCancelarConsulta.Text = "Cancelar";
            this.buttonCancelarConsulta.UseVisualStyleBackColor = true;
            // 
            // FormConsultarGrupoUsuario
            // 
            this.ClientSize = new System.Drawing.Size(997, 563);
            this.Controls.Add(this.buttonCancelarConsulta);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grupoUsuarioDataGridView1);
            this.Name = "FormConsultarGrupoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource1;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSelecionarConsulta;
        private System.Windows.Forms.Button buttonCancelarConsulta;
    }
}