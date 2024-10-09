namespace WindowsFormsApp6
{
    partial class Reporte_de_Ventas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numArticulosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioVTicketsPruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaDataSet1 = new WindowsFormsApp6.PruebaDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVendidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioVPruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnToday = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnMonth = new System.Windows.Forms.RadioButton();
            this.rdbtnTodos = new System.Windows.Forms.RadioButton();
            this.rdbtn3Months = new System.Windows.Forms.RadioButton();
            this.inventarioVTicketsPruebaTableAdapter = new WindowsFormsApp6.PruebaDataSet1TableAdapters.InventarioVTicketsPruebaTableAdapter();
            this.inventarioVPruebaTableAdapter = new WindowsFormsApp6.PruebaDataSet1TableAdapters.InventarioVPruebaTableAdapter();
            this.rdbtnAñoAct = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVTicketsPruebaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVPruebaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTicket,
            this.fechaDataGridViewTextBoxColumn,
            this.numArticulosDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.cambioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventarioVTicketsPruebaBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(454, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // NumeroTicket
            // 
            this.NumeroTicket.DataPropertyName = "Numero_Ticket";
            this.NumeroTicket.FillWeight = 132.0293F;
            this.NumeroTicket.HeaderText = "Numero de Ticket";
            this.NumeroTicket.MinimumWidth = 6;
            this.NumeroTicket.Name = "NumeroTicket";
            this.NumeroTicket.Width = 90;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 112.7424F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 80;
            // 
            // numArticulosDataGridViewTextBoxColumn
            // 
            this.numArticulosDataGridViewTextBoxColumn.DataPropertyName = "Num_Articulos";
            this.numArticulosDataGridViewTextBoxColumn.FillWeight = 83.92346F;
            this.numArticulosDataGridViewTextBoxColumn.HeaderText = "Articulos";
            this.numArticulosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numArticulosDataGridViewTextBoxColumn.Name = "numArticulosDataGridViewTextBoxColumn";
            this.numArticulosDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 87.51782F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 60;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewTextBoxColumn.FillWeight = 90.5849F;
            this.pagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.Width = 60;
            // 
            // cambioDataGridViewTextBoxColumn
            // 
            this.cambioDataGridViewTextBoxColumn.DataPropertyName = "Cambio";
            this.cambioDataGridViewTextBoxColumn.FillWeight = 93.20203F;
            this.cambioDataGridViewTextBoxColumn.HeaderText = "Cambio";
            this.cambioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cambioDataGridViewTextBoxColumn.Name = "cambioDataGridViewTextBoxColumn";
            this.cambioDataGridViewTextBoxColumn.Width = 60;
            // 
            // inventarioVTicketsPruebaBindingSource
            // 
            this.inventarioVTicketsPruebaBindingSource.DataMember = "InventarioVTicketsPrueba";
            this.inventarioVTicketsPruebaBindingSource.DataSource = this.pruebaDataSet1;
            // 
            // pruebaDataSet1
            // 
            this.pruebaDataSet1.DataSetName = "PruebaDataSet1";
            this.pruebaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.precioUnitDataGridViewTextBoxColumn,
            this.cantidadVendidaDataGridViewTextBoxColumn,
            this.ticketDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.inventarioVPruebaBindingSource;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(501, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(561, 304);
            this.dataGridView2.TabIndex = 1;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // precioUnitDataGridViewTextBoxColumn
            // 
            this.precioUnitDataGridViewTextBoxColumn.DataPropertyName = "Precio_Unit";
            this.precioUnitDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.precioUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioUnitDataGridViewTextBoxColumn.Name = "precioUnitDataGridViewTextBoxColumn";
            this.precioUnitDataGridViewTextBoxColumn.Width = 60;
            // 
            // cantidadVendidaDataGridViewTextBoxColumn
            // 
            this.cantidadVendidaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Vendida";
            this.cantidadVendidaDataGridViewTextBoxColumn.HeaderText = "Cantidad Vendida";
            this.cantidadVendidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadVendidaDataGridViewTextBoxColumn.Name = "cantidadVendidaDataGridViewTextBoxColumn";
            this.cantidadVendidaDataGridViewTextBoxColumn.Width = 60;
            // 
            // ticketDataGridViewTextBoxColumn
            // 
            this.ticketDataGridViewTextBoxColumn.DataPropertyName = "Ticket";
            this.ticketDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.ticketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketDataGridViewTextBoxColumn.Name = "ticketDataGridViewTextBoxColumn";
            this.ticketDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            this.totalDataGridViewTextBoxColumn1.Width = 60;
            // 
            // inventarioVPruebaBindingSource
            // 
            this.inventarioVPruebaBindingSource.DataMember = "InventarioVPrueba";
            this.inventarioVPruebaBindingSource.DataSource = this.pruebaDataSet1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(958, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Ticket:";
            // 
            // rdbtnToday
            // 
            this.rdbtnToday.AutoSize = true;
            this.rdbtnToday.Location = new System.Drawing.Point(243, 41);
            this.rdbtnToday.Name = "rdbtnToday";
            this.rdbtnToday.Size = new System.Drawing.Size(44, 17);
            this.rdbtnToday.TabIndex = 6;
            this.rdbtnToday.TabStop = true;
            this.rdbtnToday.Text = "Hoy";
            this.rdbtnToday.UseVisualStyleBackColor = true;
            this.rdbtnToday.CheckedChanged += new System.EventHandler(this.rdbtnToday_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de Regitros:";
            // 
            // rdbtnMonth
            // 
            this.rdbtnMonth.AutoSize = true;
            this.rdbtnMonth.Location = new System.Drawing.Point(310, 41);
            this.rdbtnMonth.Name = "rdbtnMonth";
            this.rdbtnMonth.Size = new System.Drawing.Size(77, 17);
            this.rdbtnMonth.TabIndex = 8;
            this.rdbtnMonth.TabStop = true;
            this.rdbtnMonth.Text = "Ultimo Mes";
            this.rdbtnMonth.UseVisualStyleBackColor = true;
            this.rdbtnMonth.CheckedChanged += new System.EventHandler(this.rdbtnMonth_CheckedChanged);
            // 
            // rdbtnTodos
            // 
            this.rdbtnTodos.AutoSize = true;
            this.rdbtnTodos.Location = new System.Drawing.Point(132, 41);
            this.rdbtnTodos.Name = "rdbtnTodos";
            this.rdbtnTodos.Size = new System.Drawing.Size(95, 17);
            this.rdbtnTodos.TabIndex = 9;
            this.rdbtnTodos.TabStop = true;
            this.rdbtnTodos.Text = "Todo el tiempo";
            this.rdbtnTodos.UseVisualStyleBackColor = true;
            this.rdbtnTodos.CheckedChanged += new System.EventHandler(this.rdbtnTodos_CheckedChanged);
            // 
            // rdbtn3Months
            // 
            this.rdbtn3Months.AutoSize = true;
            this.rdbtn3Months.Location = new System.Drawing.Point(406, 41);
            this.rdbtn3Months.Name = "rdbtn3Months";
            this.rdbtn3Months.Size = new System.Drawing.Size(102, 17);
            this.rdbtn3Months.TabIndex = 10;
            this.rdbtn3Months.TabStop = true;
            this.rdbtn3Months.Text = "Ultimos 3 Meses";
            this.rdbtn3Months.UseVisualStyleBackColor = true;
            this.rdbtn3Months.CheckedChanged += new System.EventHandler(this.rdbtn3Months_CheckedChanged);
            // 
            // inventarioVTicketsPruebaTableAdapter
            // 
            this.inventarioVTicketsPruebaTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioVPruebaTableAdapter
            // 
            this.inventarioVPruebaTableAdapter.ClearBeforeFill = true;
            // 
            // rdbtnAñoAct
            // 
            this.rdbtnAñoAct.AutoSize = true;
            this.rdbtnAñoAct.Location = new System.Drawing.Point(525, 41);
            this.rdbtnAñoAct.Name = "rdbtnAñoAct";
            this.rdbtnAñoAct.Size = new System.Drawing.Size(77, 17);
            this.rdbtnAñoAct.TabIndex = 11;
            this.rdbtnAñoAct.TabStop = true;
            this.rdbtnAñoAct.Text = "Año Actual";
            this.rdbtnAñoAct.UseVisualStyleBackColor = true;
            this.rdbtnAñoAct.CheckedChanged += new System.EventHandler(this.rdbtnAñoAct_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buscar Productos de Ticket:";
            // 
            // Reporte_de_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbtnAñoAct);
            this.Controls.Add(this.rdbtn3Months);
            this.Controls.Add(this.rdbtnTodos);
            this.Controls.Add(this.rdbtnMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtnToday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_de_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.Reporte_de_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVTicketsPruebaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVPruebaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private PruebaDataSet1 pruebaDataSet1;
        private System.Windows.Forms.BindingSource inventarioVTicketsPruebaBindingSource;
        private PruebaDataSet1TableAdapters.InventarioVTicketsPruebaTableAdapter inventarioVTicketsPruebaTableAdapter;
        private System.Windows.Forms.BindingSource inventarioVPruebaBindingSource;
        private PruebaDataSet1TableAdapters.InventarioVPruebaTableAdapter inventarioVPruebaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVendidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numArticulosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbtnMonth;
        private System.Windows.Forms.RadioButton rdbtnTodos;
        private System.Windows.Forms.RadioButton rdbtn3Months;
        private System.Windows.Forms.RadioButton rdbtnAñoAct;
        private System.Windows.Forms.Label label3;
    }
}