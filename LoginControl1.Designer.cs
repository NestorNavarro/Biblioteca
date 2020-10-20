/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 20/05/2019
 * Hora: 10:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class LoginControl1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelLineUser;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pBusuario;
		private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Panel panel3;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelLineUser = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pBusuario = new System.Windows.Forms.PictureBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelLineUser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBusuario)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.tbPassword);
			this.panel1.Controls.Add(this.tbUser);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panelLineUser);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pBusuario);
			this.panel1.Controls.Add(this.btnInicio);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(261, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(403, 439);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(156, 67);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(114, 74);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// tbPassword
			// 
			this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.tbPassword.Location = new System.Drawing.Point(156, 269);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(150, 24);
			this.tbPassword.TabIndex = 7;
			this.tbPassword.Text = "Password";
			this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbPassword.UseSystemPasswordChar = true;
			this.tbPassword.Enter += new System.EventHandler(this.TbPasswordEnter);
			this.tbPassword.Leave += new System.EventHandler(this.TbPasswordLeave);
			// 
			// tbUser
			// 
			this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.tbUser.Location = new System.Drawing.Point(156, 191);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(150, 24);
			this.tbUser.TabIndex = 1;
			this.tbUser.Text = "Username";
			this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbUser.Enter += new System.EventHandler(this.TbUserEnter);
			this.tbUser.Leave += new System.EventHandler(this.TbUserLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel2.Location = new System.Drawing.Point(81, 299);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(270, 3);
			this.panel2.TabIndex = 6;
			// 
			// panelLineUser
			// 
			this.panelLineUser.BackColor = System.Drawing.Color.Black;
			this.panelLineUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineUser.Controls.Add(this.panel3);
			this.panelLineUser.Location = new System.Drawing.Point(81, 221);
			this.panelLineUser.Name = "panelLineUser";
			this.panelLineUser.Size = new System.Drawing.Size(270, 3);
			this.panelLineUser.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(81, 253);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(76, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pBusuario
			// 
			this.pBusuario.Image = ((System.Drawing.Image)(resources.GetObject("pBusuario.Image")));
			this.pBusuario.Location = new System.Drawing.Point(81, 175);
			this.pBusuario.Name = "pBusuario";
			this.pBusuario.Size = new System.Drawing.Size(76, 40);
			this.pBusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBusuario.TabIndex = 3;
			this.pBusuario.TabStop = false;
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.Gray;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnInicio.ForeColor = System.Drawing.Color.White;
			this.btnInicio.Location = new System.Drawing.Point(156, 326);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(136, 49);
			this.btnInicio.TabIndex = 2;
			this.btnInicio.Text = "Login";
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.BtnInicioClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(270, 3);
			this.panel3.TabIndex = 6;
			// 
			// LoginControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Name = "LoginControl1";
			this.Size = new System.Drawing.Size(908, 529);
			this.Load += new System.EventHandler(this.LoginControl1Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelLineUser.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBusuario)).EndInit();
			this.ResumeLayout(false);

		}

		}
}
