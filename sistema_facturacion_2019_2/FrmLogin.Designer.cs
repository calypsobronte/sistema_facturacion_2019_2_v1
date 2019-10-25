namespace sistema_facturacion_2019_2
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblvalidar = new MaterialSkin.Controls.MaterialLabel();
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcontrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnvalidar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btncancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_facturacion_2019_2.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblvalidar
            // 
            this.lblvalidar.AutoSize = true;
            this.lblvalidar.Depth = 0;
            this.lblvalidar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblvalidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblvalidar.Location = new System.Drawing.Point(328, 21);
            this.lblvalidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblvalidar.Name = "lblvalidar";
            this.lblvalidar.Size = new System.Drawing.Size(136, 19);
            this.lblvalidar.TabIndex = 1;
            this.lblvalidar.Text = "VALIDAR USUARIO";
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.Hint = "Usuario";
            this.txtusuario.Location = new System.Drawing.Point(240, 76);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(196, 23);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.TabStop = false;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Depth = 0;
            this.txtcontrasena.Hint = "Contraseña";
            this.txtcontrasena.Location = new System.Drawing.Point(240, 134);
            this.txtcontrasena.MaxLength = 32767;
            this.txtcontrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.SelectedText = "";
            this.txtcontrasena.SelectionLength = 0;
            this.txtcontrasena.SelectionStart = 0;
            this.txtcontrasena.Size = new System.Drawing.Size(196, 23);
            this.txtcontrasena.TabIndex = 3;
            this.txtcontrasena.TabStop = false;
            this.txtcontrasena.UseSystemPasswordChar = false;
            // 
            // btnvalidar
            // 
            this.btnvalidar.AutoSize = true;
            this.btnvalidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnvalidar.Depth = 0;
            this.btnvalidar.Icon = null;
            this.btnvalidar.Location = new System.Drawing.Point(241, 194);
            this.btnvalidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Primary = true;
            this.btnvalidar.Size = new System.Drawing.Size(77, 36);
            this.btnvalidar.TabIndex = 4;
            this.btnvalidar.Text = "VALIDAR";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.Btnvalidar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Depth = 0;
            this.btncancelar.Icon = null;
            this.btncancelar.Location = new System.Drawing.Point(395, 194);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Primary = true;
            this.btncancelar.Size = new System.Drawing.Size(91, 36);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblvalidar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblvalidar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontrasena;
        private MaterialSkin.Controls.MaterialRaisedButton btnvalidar;
        private MaterialSkin.Controls.MaterialRaisedButton btncancelar;
    }
}

