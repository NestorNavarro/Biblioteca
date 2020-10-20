/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 20/05/2019
 * Hora: 08:19 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.PictureBox pbClose;
		public System.Windows.Forms.Label lbPanelC;
		private System.Windows.Forms.Panel panel1;
		private Biblioteca.LoginControl1 loginControl11;
		private Biblioteca.btnPrestamo btnPrestamo1;
		private Biblioteca.Perfil perfil1;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelTop = new System.Windows.Forms.Panel();
			this.lbPanelC = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.loginControl11 = new Biblioteca.LoginControl1();
			this.btnPrestamo1 = new Biblioteca.btnPrestamo();
			this.perfil1 = new Biblioteca.Perfil();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
			this.panelTop.Controls.Add(this.lbPanelC);
			this.panelTop.Controls.Add(this.pbClose);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(908, 46);
			this.panelTop.TabIndex = 0;
			this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTopMouseDown);
			// 
			// lbPanelC
			// 
			this.lbPanelC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbPanelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPanelC.ForeColor = System.Drawing.Color.Black;
			this.lbPanelC.Location = new System.Drawing.Point(385, 9);
			this.lbPanelC.Name = "lbPanelC";
			this.lbPanelC.Size = new System.Drawing.Size(332, 29);
			this.lbPanelC.TabIndex = 2;
			this.lbPanelC.Text = "label1";
			this.lbPanelC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LbPanelCMouseDown);
			// 
			// pbClose
			// 
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(861, 3);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(47, 40);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(0, 0);
			this.panel1.TabIndex = 1;
			// 
			// loginControl11
			// 
			this.loginControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.loginControl11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.loginControl11.Location = new System.Drawing.Point(0, 41);
			this.loginControl11.Name = "loginControl11";
			this.loginControl11.Size = new System.Drawing.Size(905, 572);
			this.loginControl11.TabIndex = 2;
			// 
			// btnPrestamo1
			// 
			this.btnPrestamo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.btnPrestamo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrestamo1.Location = new System.Drawing.Point(0, 41);
			this.btnPrestamo1.Name = "btnPrestamo1";
			this.btnPrestamo1.Size = new System.Drawing.Size(908, 529);
			this.btnPrestamo1.TabIndex = 3;
			// 
			// perfil1
			// 
			this.perfil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.perfil1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.perfil1.Location = new System.Drawing.Point(324, 113);
			this.perfil1.Name = "perfil1";
			this.perfil1.Size = new System.Drawing.Size(322, 251);
			this.perfil1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(908, 572);
			this.Controls.Add(this.perfil1);
			this.Controls.Add(this.btnPrestamo1);
			this.Controls.Add(this.loginControl11);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTop);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Biblioteca";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panelTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
