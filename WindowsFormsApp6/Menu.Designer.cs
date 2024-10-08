
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
            this.btnSalirSesion = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnDistribuidores = new System.Windows.Forms.Button();
            this.btnMercancia = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnRegistroVent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirSesion
            // 
            this.btnSalirSesion.Location = new System.Drawing.Point(225, 380);
            this.btnSalirSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirSesion.Name = "btnSalirSesion";
            this.btnSalirSesion.Size = new System.Drawing.Size(164, 43);
            this.btnSalirSesion.TabIndex = 17;
            this.btnSalirSesion.Text = "Salir";
            this.btnSalirSesion.UseVisualStyleBackColor = true;
            this.btnSalirSesion.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCaja.Location = new System.Drawing.Point(375, 96);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(150, 81);
            this.btnCaja.TabIndex = 16;
            this.btnCaja.Text = "Caja Registradora";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnDistribuidores
            // 
            this.btnDistribuidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDistribuidores.Location = new System.Drawing.Point(75, 258);
            this.btnDistribuidores.Margin = new System.Windows.Forms.Padding(2);
            this.btnDistribuidores.Name = "btnDistribuidores";
            this.btnDistribuidores.Size = new System.Drawing.Size(150, 81);
            this.btnDistribuidores.TabIndex = 14;
            this.btnDistribuidores.Text = "Distribuidoras";
            this.btnDistribuidores.UseVisualStyleBackColor = true;
            this.btnDistribuidores.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnMercancia
            // 
            this.btnMercancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMercancia.Location = new System.Drawing.Point(75, 96);
            this.btnMercancia.Margin = new System.Windows.Forms.Padding(2);
            this.btnMercancia.Name = "btnMercancia";
            this.btnMercancia.Size = new System.Drawing.Size(150, 81);
            this.btnMercancia.TabIndex = 13;
            this.btnMercancia.Text = "Mercancia";
            this.btnMercancia.UseVisualStyleBackColor = true;
            this.btnMercancia.Click += new System.EventHandler(this.btnMerchan_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMenu.Location = new System.Drawing.Point(229, 32);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(141, 25);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menú Principal";
            // 
            // btnRegistroVent
            // 
            this.btnRegistroVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegistroVent.Location = new System.Drawing.Point(375, 258);
            this.btnRegistroVent.Name = "btnRegistroVent";
            this.btnRegistroVent.Size = new System.Drawing.Size(150, 81);
            this.btnRegistroVent.TabIndex = 18;
            this.btnRegistroVent.Text = "Registro de Ventas";
            this.btnRegistroVent.UseVisualStyleBackColor = true;
            this.btnRegistroVent.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnRegistroVent);
            this.Controls.Add(this.btnSalirSesion);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnDistribuidores);
            this.Controls.Add(this.btnMercancia);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirSesion;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnDistribuidores;
        private System.Windows.Forms.Button btnMercancia;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnRegistroVent;
    }
}