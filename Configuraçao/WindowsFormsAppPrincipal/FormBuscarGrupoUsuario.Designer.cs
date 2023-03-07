namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarGrupoUsuario));
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.grupoUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.BuscarUsuario = new System.Windows.Forms.Button();
            this.AdicionarUsuario = new System.Windows.Forms.Button();
            this.AlterarUsuario = new System.Windows.Forms.Button();
            this.ExcluirUsuario = new System.Windows.Forms.Button();
            this.AlterarGrupo = new System.Windows.Forms.Button();
            this.ExcluirGrupo = new System.Windows.Forms.Button();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingNavigator)).BeginInit();
            this.grupoUsuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioBindingNavigator
            // 
            this.grupoUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.grupoUsuarioBindingNavigator.BindingSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.grupoUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.grupoUsuarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.grupoUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.grupoUsuarioBindingNavigatorSaveItem});
            this.grupoUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.grupoUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.grupoUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.grupoUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.grupoUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.grupoUsuarioBindingNavigator.Name = "grupoUsuarioBindingNavigator";
            this.grupoUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.grupoUsuarioBindingNavigator.Size = new System.Drawing.Size(1405, 27);
            this.grupoUsuarioBindingNavigator.TabIndex = 0;
            this.grupoUsuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // grupoUsuarioBindingNavigatorSaveItem
            // 
            this.grupoUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grupoUsuarioBindingNavigatorSaveItem.Enabled = false;
            this.grupoUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("grupoUsuarioBindingNavigatorSaveItem.Image")));
            this.grupoUsuarioBindingNavigatorSaveItem.Name = "grupoUsuarioBindingNavigatorSaveItem";
            this.grupoUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.grupoUsuarioBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(46, 99);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(846, 339);
            this.grupoUsuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(46, 51);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(512, 22);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // BuscarUsuario
            // 
            this.BuscarUsuario.Location = new System.Drawing.Point(574, 51);
            this.BuscarUsuario.Name = "BuscarUsuario";
            this.BuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BuscarUsuario.TabIndex = 4;
            this.BuscarUsuario.Text = "Buscar";
            this.BuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // AdicionarUsuario
            // 
            this.AdicionarUsuario.Location = new System.Drawing.Point(655, 51);
            this.AdicionarUsuario.Name = "AdicionarUsuario";
            this.AdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.AdicionarUsuario.TabIndex = 4;
            this.AdicionarUsuario.Text = "Adicionar";
            this.AdicionarUsuario.UseVisualStyleBackColor = true;
            // 
            // AlterarUsuario
            // 
            this.AlterarUsuario.Location = new System.Drawing.Point(736, 51);
            this.AlterarUsuario.Name = "AlterarUsuario";
            this.AlterarUsuario.Size = new System.Drawing.Size(75, 23);
            this.AlterarUsuario.TabIndex = 4;
            this.AlterarUsuario.Text = "Alterar";
            this.AlterarUsuario.UseVisualStyleBackColor = true;
            // 
            // ExcluirUsuario
            // 
            this.ExcluirUsuario.Location = new System.Drawing.Point(817, 50);
            this.ExcluirUsuario.Name = "ExcluirUsuario";
            this.ExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.ExcluirUsuario.TabIndex = 4;
            this.ExcluirUsuario.Text = "Excluir";
            this.ExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // AlterarGrupo
            // 
            this.AlterarGrupo.Location = new System.Drawing.Point(925, 50);
            this.AlterarGrupo.Name = "AlterarGrupo";
            this.AlterarGrupo.Size = new System.Drawing.Size(75, 23);
            this.AlterarGrupo.TabIndex = 4;
            this.AlterarGrupo.Text = "Alterar";
            this.AlterarGrupo.UseVisualStyleBackColor = true;
            // 
            // ExcluirGrupo
            // 
            this.ExcluirGrupo.Location = new System.Drawing.Point(1028, 51);
            this.ExcluirGrupo.Name = "ExcluirGrupo";
            this.ExcluirGrupo.Size = new System.Drawing.Size(75, 23);
            this.ExcluirGrupo.TabIndex = 4;
            this.ExcluirGrupo.Text = "Excluir";
            this.ExcluirGrupo.UseVisualStyleBackColor = true;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataMember = "Permissao";
            this.permissaoBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(925, 99);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(380, 339);
            this.permissaoDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FormBuscarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 450);
            this.Controls.Add(this.permissaoDataGridView);
            this.Controls.Add(this.ExcluirGrupo);
            this.Controls.Add(this.AlterarGrupo);
            this.Controls.Add(this.ExcluirUsuario);
            this.Controls.Add(this.AlterarUsuario);
            this.Controls.Add(this.AdicionarUsuario);
            this.Controls.Add(this.BuscarUsuario);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Controls.Add(this.grupoUsuarioBindingNavigator);
            this.Name = "FormBuscarGrupoUsuario";
            this.Text = "FormBuscarGrupoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingNavigator)).EndInit();
            this.grupoUsuarioBindingNavigator.ResumeLayout(false);
            this.grupoUsuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.BindingNavigator grupoUsuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton grupoUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button BuscarUsuario;
        private System.Windows.Forms.Button AdicionarUsuario;
        private System.Windows.Forms.Button AlterarUsuario;
        private System.Windows.Forms.Button ExcluirUsuario;
        private System.Windows.Forms.Button AlterarGrupo;
        private System.Windows.Forms.Button ExcluirGrupo;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}