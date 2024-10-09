
namespace WindowsFormsApp6
{
    partial class Menu
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
            this.btnMercancia = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnDistribuidores = new System.Windows.Forms.Button();
            this.btnSalirSesion = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnRegistroVent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMercancia
            // 
            this.btnMercancia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMercancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercancia.Location = new System.Drawing.Point(0, 124);
            this.btnMercancia.Margin = new System.Windows.Forms.Padding(2);
            this.btnMercancia.Name = "btnMercancia";
            this.btnMercancia.Size = new System.Drawing.Size(200, 124);
            this.btnMercancia.TabIndex = 20;
            this.btnMercancia.Text = "Mercancia";
            this.btnMercancia.UseVisualStyleBackColor = true;
            this.btnMercancia.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCaja.Location = new System.Drawing.Point(0, 0);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(200, 124);
            this.btnCaja.TabIndex = 10;
            this.btnCaja.Text = "Caja Registradora";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnDistribuidores
            // 
            this.btnDistribuidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDistribuidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDistribuidores.Location = new System.Drawing.Point(0, 372);
            this.btnDistribuidores.Margin = new System.Windows.Forms.Padding(2);
            this.btnDistribuidores.Name = "btnDistribuidores";
            this.btnDistribuidores.Size = new System.Drawing.Size(200, 124);
            this.btnDistribuidores.TabIndex = 14;
            this.btnDistribuidores.Text = "Distribuidoras";
            this.btnDistribuidores.UseVisualStyleBackColor = true;
            this.btnDistribuidores.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnSalirSesion
            // 
            this.btnSalirSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalirSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSalirSesion.Location = new System.Drawing.Point(0, 496);
            this.btnSalirSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.btnSalirSesion.Name = "btnSalirSesion";
            this.btnSalirSesion.Size = new System.Drawing.Size(200, 124);
            this.btnSalirSesion.TabIndex = 11;
            this.btnSalirSesion.Text = "Salir";
            this.btnSalirSesion.UseVisualStyleBackColor = true;
            this.btnSalirSesion.Click += new System.EventHandler(this.btnMerchan_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMenu.Location = new System.Drawing.Point(341, 64);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(141, 25);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menú Principal";
            // 
            // btnRegistroVent
            // 
            this.btnRegistroVent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroVent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegistroVent.Location = new System.Drawing.Point(0, 248);
            this.btnRegistroVent.Name = "btnRegistroVent";
            this.btnRegistroVent.Size = new System.Drawing.Size(200, 124);
            this.btnRegistroVent.TabIndex = 12;
            this.btnRegistroVent.Text = "Registro de Ventas";
            this.btnRegistroVent.UseVisualStyleBackColor = true;
            this.btnRegistroVent.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalirSesion);
            this.panel1.Controls.Add(this.btnDistribuidores);
            this.panel1.Controls.Add(this.btnRegistroVent);
            this.panel1.Controls.Add(this.btnMercancia);
            this.panel1.Controls.Add(this.btnCaja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 620);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 20;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnDistribuidores;
        private System.Windows.Forms.Button btnSalirSesion;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnRegistroVent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMercancia;
        private System.Windows.Forms.Panel panel2;
    }
}