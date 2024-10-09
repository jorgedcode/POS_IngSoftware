
namespace WindowsFormsApp6
{
    partial class frmMercancia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label cant_StockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMercancia));
            this.button1 = new System.Windows.Forms.Button();
            this.pruebaDataSet = new WindowsFormsApp6.PruebaDataSet();
            this.pruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaTableAdapter = new WindowsFormsApp6.PruebaDataSetTableAdapters.PruebaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp6.PruebaDataSetTableAdapters.TableAdapterManager();
            this.pruebaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pruebaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pruebaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.cant_StockTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            cant_StockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingNavigator)).BeginInit();
            this.pruebaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(29, 80);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(29, 102);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 14;
            nombreLabel.Text = "Nombre:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(29, 125);
            marcaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 16;
            marcaLabel.Text = "Marca:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(29, 148);
            precioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 18;
            precioLabel.Text = "Precio:";
            // 
            // cant_StockLabel
            // 
            cant_StockLabel.AutoSize = true;
            cant_StockLabel.Location = new System.Drawing.Point(29, 171);
            cant_StockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cant_StockLabel.Name = "cant_StockLabel";
            cant_StockLabel.Size = new System.Drawing.Size(63, 13);
            cant_StockLabel.TabIndex = 20;
            cant_StockLabel.Text = "Cant Stock:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pruebaDataSet
            // 
            this.pruebaDataSet.DataSetName = "PruebaDataSet";
            this.pruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruebaBindingSource
            // 
            this.pruebaBindingSource.DataMember = "Prueba";
            this.pruebaBindingSource.DataSource = this.pruebaDataSet;
            // 
            // pruebaTableAdapter
            // 
            this.pruebaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PruebaTableAdapter = this.pruebaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp6.PruebaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pruebaBindingNavigator
            // 
            this.pruebaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pruebaBindingNavigator.BindingSource = this.pruebaBindingSource;
            this.pruebaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pruebaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pruebaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pruebaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pruebaBindingNavigatorSaveItem});
            this.pruebaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pruebaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pruebaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pruebaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pruebaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pruebaBindingNavigator.Name = "pruebaBindingNavigator";
            this.pruebaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pruebaBindingNavigator.Size = new System.Drawing.Size(739, 27);
            this.pruebaBindingNavigator.TabIndex = 12;
            this.pruebaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pruebaBindingNavigatorSaveItem
            // 
            this.pruebaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pruebaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pruebaBindingNavigatorSaveItem.Image")));
            this.pruebaBindingNavigatorSaveItem.Name = "pruebaBindingNavigatorSaveItem";
            this.pruebaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pruebaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pruebaBindingNavigatorSaveItem.Click += new System.EventHandler(this.pruebaBindingNavigatorSaveItem_Click_1);
            // 
            // pruebaDataGridView
            // 
            this.pruebaDataGridView.AutoGenerateColumns = false;
            this.pruebaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pruebaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pruebaDataGridView.DataSource = this.pruebaBindingSource;
            this.pruebaDataGridView.Enabled = false;
            this.pruebaDataGridView.Location = new System.Drawing.Point(32, 212);
            this.pruebaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.pruebaDataGridView.Name = "pruebaDataGridView";
            this.pruebaDataGridView.RowHeadersWidth = 51;
            this.pruebaDataGridView.RowTemplate.Height = 24;
            this.pruebaDataGridView.Size = new System.Drawing.Size(680, 212);
            this.pruebaDataGridView.TabIndex = 12;
            this.pruebaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pruebaDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cant_Stock";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cant_Stock";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pruebaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(94, 77);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(76, 20);
            this.idTextBox.TabIndex = 13;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pruebaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(94, 100);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.MaxLength = 24;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(76, 20);
            this.nombreTextBox.TabIndex = 15;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pruebaBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(94, 123);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(76, 20);
            this.marcaTextBox.TabIndex = 17;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pruebaBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(94, 145);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(76, 20);
            this.precioTextBox.TabIndex = 19;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // cant_StockTextBox
            // 
            this.cant_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pruebaBindingSource, "Cant_Stock", true));
            this.cant_StockTextBox.Location = new System.Drawing.Point(94, 168);
            this.cant_StockTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cant_StockTextBox.Name = "cant_StockTextBox";
            this.cant_StockTextBox.Size = new System.Drawing.Size(76, 20);
            this.cant_StockTextBox.TabIndex = 21;
            this.cant_StockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cant_StockTextBox_KeyPress);
            // 
            // frmMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 440);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(cant_StockLabel);
            this.Controls.Add(this.cant_StockTextBox);
            this.Controls.Add(this.pruebaDataGridView);
            this.Controls.Add(this.pruebaBindingNavigator);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMercancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingNavigator)).EndInit();
            this.pruebaBindingNavigator.ResumeLayout(false);
            this.pruebaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private PruebaDataSet pruebaDataSet;
        private System.Windows.Forms.BindingSource pruebaBindingSource;
        private PruebaDataSetTableAdapters.PruebaTableAdapter pruebaTableAdapter;
        private PruebaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pruebaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pruebaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pruebaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox cant_StockTextBox;
    }
}

