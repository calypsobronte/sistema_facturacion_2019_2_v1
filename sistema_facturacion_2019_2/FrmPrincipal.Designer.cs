namespace sistema_facturacion_2019_2
{
    partial class FrmPrincipal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pblContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablas = new System.Windows.Forms.TabPage();
            this.btnCatergoria = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.facturacion = new System.Windows.Forms.TabPage();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.seguridad = new System.Windows.Forms.TabPage();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ayuda = new System.Windows.Forms.TabPage();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbpOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pblContenedor.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pblContenedor);
            this.pnlPrincipal.Controls.Add(this.pnlMenu);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 64);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1200, 585);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pblContenedor
            // 
            this.pblContenedor.Controls.Add(this.label1);
            this.pblContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblContenedor.Location = new System.Drawing.Point(200, 0);
            this.pblContenedor.Name = "pblContenedor";
            this.pblContenedor.Size = new System.Drawing.Size(1000, 585);
            this.pblContenedor.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tbpMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 585);
            this.pnlMenu.TabIndex = 0;
            // 
            // tbpMenu
            // 
            this.tbpMenu.Controls.Add(this.Principal);
            this.tbpMenu.Controls.Add(this.tablas);
            this.tbpMenu.Controls.Add(this.facturacion);
            this.tbpMenu.Controls.Add(this.seguridad);
            this.tbpMenu.Controls.Add(this.ayuda);
            this.tbpMenu.Depth = 0;
            this.tbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMenu.Location = new System.Drawing.Point(0, 0);
            this.tbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbpMenu.Name = "tbpMenu";
            this.tbpMenu.SelectedIndex = 0;
            this.tbpMenu.Size = new System.Drawing.Size(200, 585);
            this.tbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.DodgerBlue;
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 559);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Image = global::sistema_facturacion_2019_2.Properties.Resources.logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 131);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 43);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_facturacion_2019_2.Properties.Resources.calypsobrontez;
            this.pictureBox1.Location = new System.Drawing.Point(6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.DodgerBlue;
            this.tablas.Controls.Add(this.btnCatergoria);
            this.tablas.Controls.Add(this.btnCliente);
            this.tablas.Controls.Add(this.btnProductos);
            this.tablas.Controls.Add(this.pictureBox2);
            this.tablas.Location = new System.Drawing.Point(4, 22);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(192, 559);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Admin Tablas";
            // 
            // btnCatergoria
            // 
            this.btnCatergoria.FlatAppearance.BorderSize = 0;
            this.btnCatergoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCatergoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatergoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatergoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatergoria.Image = global::sistema_facturacion_2019_2.Properties.Resources.time_management;
            this.btnCatergoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatergoria.Location = new System.Drawing.Point(1, 258);
            this.btnCatergoria.Name = "btnCatergoria";
            this.btnCatergoria.Size = new System.Drawing.Size(206, 43);
            this.btnCatergoria.TabIndex = 4;
            this.btnCatergoria.Text = "CATEGORIA";
            this.btnCatergoria.UseVisualStyleBackColor = true;
            this.btnCatergoria.Click += new System.EventHandler(this.BtnCatergoria_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCliente.Image = global::sistema_facturacion_2019_2.Properties.Resources.multiple_users_silhouette;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(1, 157);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(206, 43);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.Image = global::sistema_facturacion_2019_2.Properties.Resources.box;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(1, 206);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(206, 43);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistema_facturacion_2019_2.Properties.Resources.calypsobrontez;
            this.pictureBox2.Location = new System.Drawing.Point(6, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // facturacion
            // 
            this.facturacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.facturacion.Controls.Add(this.btnInformes);
            this.facturacion.Controls.Add(this.btnFacturacion);
            this.facturacion.Controls.Add(this.pictureBox3);
            this.facturacion.Location = new System.Drawing.Point(4, 22);
            this.facturacion.Name = "facturacion";
            this.facturacion.Size = new System.Drawing.Size(192, 559);
            this.facturacion.TabIndex = 2;
            this.facturacion.Text = "Facturación";
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInformes.Image = global::sistema_facturacion_2019_2.Properties.Resources.big_data;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(2, 242);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(206, 43);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "INFORMES";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.BtnInformes_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacturacion.Image = global::sistema_facturacion_2019_2.Properties.Resources.invoice;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(2, 189);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(206, 43);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "    FACTURACIÓN";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sistema_facturacion_2019_2.Properties.Resources.calypsobrontez;
            this.pictureBox3.Location = new System.Drawing.Point(6, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // seguridad
            // 
            this.seguridad.BackColor = System.Drawing.Color.DodgerBlue;
            this.seguridad.Controls.Add(this.btnSeguridad);
            this.seguridad.Controls.Add(this.btnRoles);
            this.seguridad.Controls.Add(this.btnEmpleados);
            this.seguridad.Controls.Add(this.pictureBox4);
            this.seguridad.Location = new System.Drawing.Point(4, 22);
            this.seguridad.Name = "seguridad";
            this.seguridad.Size = new System.Drawing.Size(192, 559);
            this.seguridad.TabIndex = 3;
            this.seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeguridad.Image = global::sistema_facturacion_2019_2.Properties.Resources.shield;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(2, 313);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(206, 43);
            this.btnSeguridad.TabIndex = 8;
            this.btnSeguridad.Text = "SEGURIDAD";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.BtnSeguridad_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoles.Image = global::sistema_facturacion_2019_2.Properties.Resources.role;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(2, 258);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(206, 43);
            this.btnRoles.TabIndex = 7;
            this.btnRoles.Text = "ROLES";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.Image = global::sistema_facturacion_2019_2.Properties.Resources.big_data;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(2, 200);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(206, 43);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::sistema_facturacion_2019_2.Properties.Resources.calypsobrontez;
            this.pictureBox4.Location = new System.Drawing.Point(6, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // ayuda
            // 
            this.ayuda.BackColor = System.Drawing.Color.DodgerBlue;
            this.ayuda.Controls.Add(this.btnAcerca);
            this.ayuda.Controls.Add(this.btnAyuda);
            this.ayuda.Controls.Add(this.pictureBox5);
            this.ayuda.Location = new System.Drawing.Point(4, 22);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(192, 559);
            this.ayuda.TabIndex = 4;
            this.ayuda.Text = "Ayuda";
            // 
            // btnAcerca
            // 
            this.btnAcerca.FlatAppearance.BorderSize = 0;
            this.btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcerca.Image = global::sistema_facturacion_2019_2.Properties.Resources.team;
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(2, 258);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(206, 43);
            this.btnAcerca.TabIndex = 8;
            this.btnAcerca.Text = "ACERCA DE ";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.BtnAcerca_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAyuda.Image = global::sistema_facturacion_2019_2.Properties.Resources.help;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(2, 191);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(206, 43);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::sistema_facturacion_2019_2.Properties.Resources.calypsobrontez;
            this.pictureBox5.Location = new System.Drawing.Point(6, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(180, 93);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // tbpOpcionesMenu
            // 
            this.tbpOpcionesMenu.BaseTabControl = this.tbpMenu;
            this.tbpOpcionesMenu.Depth = 0;
            this.tbpOpcionesMenu.Location = new System.Drawing.Point(277, 33);
            this.tbpOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbpOpcionesMenu.Name = "tbpOpcionesMenu";
            this.tbpOpcionesMenu.Size = new System.Drawing.Size(637, 23);
            this.tbpOpcionesMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nasalization Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Facturación";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tbpOpcionesMenu);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pblContenedor.ResumeLayout(false);
            this.pblContenedor.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.tbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ayuda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialTabControl tbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.TabPage facturacion;
        private System.Windows.Forms.TabPage seguridad;
        private System.Windows.Forms.TabPage ayuda;
        private MaterialSkin.Controls.MaterialTabSelector tbpOpcionesMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCatergoria;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel pblContenedor;
        private System.Windows.Forms.Label label1;
    }
}