/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 23/05/2019
 * Hora: 11:03 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class Perfil
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.Label lbPaterno;
		private System.Windows.Forms.Label lbMAterno;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbPuesto;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
			this.lbNombre = new System.Windows.Forms.Label();
			this.lbPaterno = new System.Windows.Forms.Label();
			this.lbMAterno = new System.Windows.Forms.Label();
			this.lbId = new System.Windows.Forms.Label();
			this.lbPuesto = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelTop = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// lbNombre
			// 
			this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNombre.Location = new System.Drawing.Point(3, 76);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(100, 23);
			this.lbNombre.TabIndex = 0;
			this.lbNombre.Text = "Nombre";
			// 
			// lbPaterno
			// 
			this.lbPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPaterno.Location = new System.Drawing.Point(3, 112);
			this.lbPaterno.Name = "lbPaterno";
			this.lbPaterno.Size = new System.Drawing.Size(100, 23);
			this.lbPaterno.TabIndex = 1;
			this.lbPaterno.Text = "APaterno";
			// 
			// lbMAterno
			// 
			this.lbMAterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMAterno.Location = new System.Drawing.Point(3, 144);
			this.lbMAterno.Name = "lbMAterno";
			this.lbMAterno.Size = new System.Drawing.Size(100, 23);
			this.lbMAterno.TabIndex = 2;
			this.lbMAterno.Text = "AMaterno";
			// 
			// lbId
			// 
			this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbId.Location = new System.Drawing.Point(3, 42);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(100, 23);
			this.lbId.TabIndex = 3;
			this.lbId.Text = "ID";
			// 
			// lbPuesto
			// 
			this.lbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPuesto.Location = new System.Drawing.Point(3, 176);
			this.lbPuesto.Name = "lbPuesto";
			this.lbPuesto.Size = new System.Drawing.Size(138, 23);
			this.lbPuesto.TabIndex = 4;
			this.lbPuesto.Text = "Puesto";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(147, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(154, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
			this.panelTop.Controls.Add(this.label1);
			this.panelTop.Controls.Add(this.pbClose);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(324, 39);
			this.panelTop.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(111, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Perfil";
			// 
			// pbClose
			// 
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(276, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(47, 40);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 7;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.PbCloseClick);
			// 
			// Perfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbPuesto);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.lbMAterno);
			this.Controls.Add(this.lbPaterno);
			this.Controls.Add(this.lbNombre);
			this.Name = "Perfil";
			this.Size = new System.Drawing.Size(324, 253);
			this.Load += new System.EventHandler(this.PerfilLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
