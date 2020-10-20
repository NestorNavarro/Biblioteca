/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 27/05/2019
 * Hora: 12:32 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class Revista
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureboxsalir;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnBuscarPeriodico;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBuscarRevista;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lbNoR;
		private System.Windows.Forms.Label lbNombreR;
		private System.Windows.Forms.Label lbCantidad;
		private System.Windows.Forms.Label lCantidadP;
		private System.Windows.Forms.Label lbSeccion;
		private System.Windows.Forms.Label lbNombreP;
		private System.Windows.Forms.Label lbCodigoP;
		private System.Windows.Forms.Label lbCodigoV;
		private System.Windows.Forms.Label lbVideo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revista));
			this.pictureboxsalir = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnBuscarPeriodico = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscarRevista = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lbNoR = new System.Windows.Forms.Label();
			this.lbNombreR = new System.Windows.Forms.Label();
			this.lbCantidad = new System.Windows.Forms.Label();
			this.lCantidadP = new System.Windows.Forms.Label();
			this.lbSeccion = new System.Windows.Forms.Label();
			this.lbNombreP = new System.Windows.Forms.Label();
			this.lbCodigoP = new System.Windows.Forms.Label();
			this.lbCodigoV = new System.Windows.Forms.Label();
			this.lbVideo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureboxsalir
			// 
			this.pictureboxsalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxsalir.Image")));
			this.pictureboxsalir.Location = new System.Drawing.Point(50, 471);
			this.pictureboxsalir.Name = "pictureboxsalir";
			this.pictureboxsalir.Size = new System.Drawing.Size(68, 50);
			this.pictureboxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureboxsalir.TabIndex = 183;
			this.pictureboxsalir.TabStop = false;
			this.pictureboxsalir.Click += new System.EventHandler(this.PictureboxsalirClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(512, 359);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 23);
			this.label6.TabIndex = 182;
			this.label6.Text = "Código:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel2.ForeColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(437, 413);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 3);
			this.panel2.TabIndex = 180;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(693, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 45);
			this.button1.TabIndex = 179;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.textBox1.Location = new System.Drawing.Point(437, 385);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(250, 22);
			this.textBox1.TabIndex = 178;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(97, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 38);
			this.label5.TabIndex = 177;
			this.label5.Text = "VÍDEO";
			// 
			// btnBuscarPeriodico
			// 
			this.btnBuscarPeriodico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.btnBuscarPeriodico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPeriodico.BackgroundImage")));
			this.btnBuscarPeriodico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBuscarPeriodico.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarPeriodico.FlatAppearance.BorderSize = 0;
			this.btnBuscarPeriodico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnBuscarPeriodico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnBuscarPeriodico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarPeriodico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarPeriodico.ForeColor = System.Drawing.Color.Black;
			this.btnBuscarPeriodico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscarPeriodico.Location = new System.Drawing.Point(693, 195);
			this.btnBuscarPeriodico.Name = "btnBuscarPeriodico";
			this.btnBuscarPeriodico.Size = new System.Drawing.Size(46, 45);
			this.btnBuscarPeriodico.TabIndex = 176;
			this.btnBuscarPeriodico.UseVisualStyleBackColor = false;
			this.btnBuscarPeriodico.Click += new System.EventHandler(this.BtnBuscarPeriodicoClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(512, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 23);
			this.label4.TabIndex = 175;
			this.label4.Text = "Código:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.ForeColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(437, 232);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 3);
			this.panel1.TabIndex = 174;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtCodigo.Location = new System.Drawing.Point(437, 204);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(250, 22);
			this.txtCodigo.TabIndex = 173;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(85, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 38);
			this.label3.TabIndex = 171;
			this.label3.Text = "PERIÓDICO";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(85, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 38);
			this.label2.TabIndex = 170;
			this.label2.Text = "REVISTA";
			// 
			// btnBuscarRevista
			// 
			this.btnBuscarRevista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.btnBuscarRevista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarRevista.BackgroundImage")));
			this.btnBuscarRevista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBuscarRevista.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarRevista.FlatAppearance.BorderSize = 0;
			this.btnBuscarRevista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnBuscarRevista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnBuscarRevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarRevista.ForeColor = System.Drawing.Color.Black;
			this.btnBuscarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscarRevista.Location = new System.Drawing.Point(681, 21);
			this.btnBuscarRevista.Name = "btnBuscarRevista";
			this.btnBuscarRevista.Size = new System.Drawing.Size(46, 45);
			this.btnBuscarRevista.TabIndex = 169;
			this.btnBuscarRevista.UseVisualStyleBackColor = false;
			this.btnBuscarRevista.Click += new System.EventHandler(this.BtnBuscarRevistaClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(512, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 23);
			this.label1.TabIndex = 168;
			this.label1.Text = "Número:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel3.ForeColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(446, 58);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 3);
			this.panel3.TabIndex = 167;
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtNumero.Location = new System.Drawing.Point(425, 30);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(250, 22);
			this.txtNumero.TabIndex = 166;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbNoR
			// 
			this.lbNoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNoR.ForeColor = System.Drawing.Color.Silver;
			this.lbNoR.Location = new System.Drawing.Point(328, 103);
			this.lbNoR.Name = "lbNoR";
			this.lbNoR.Size = new System.Drawing.Size(132, 40);
			this.lbNoR.TabIndex = 184;
			this.lbNoR.Text = "No";
			// 
			// lbNombreR
			// 
			this.lbNombreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNombreR.ForeColor = System.Drawing.Color.Silver;
			this.lbNombreR.Location = new System.Drawing.Point(503, 103);
			this.lbNombreR.Name = "lbNombreR";
			this.lbNombreR.Size = new System.Drawing.Size(132, 40);
			this.lbNombreR.TabIndex = 185;
			this.lbNombreR.Text = "Nombre";
			// 
			// lbCantidad
			// 
			this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCantidad.ForeColor = System.Drawing.Color.Silver;
			this.lbCantidad.Location = new System.Drawing.Point(693, 103);
			this.lbCantidad.Name = "lbCantidad";
			this.lbCantidad.Size = new System.Drawing.Size(132, 40);
			this.lbCantidad.TabIndex = 186;
			this.lbCantidad.Text = "Cantidad";
			// 
			// lCantidadP
			// 
			this.lCantidadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCantidadP.ForeColor = System.Drawing.Color.Silver;
			this.lCantidadP.Location = new System.Drawing.Point(730, 261);
			this.lCantidadP.Name = "lCantidadP";
			this.lCantidadP.Size = new System.Drawing.Size(132, 40);
			this.lCantidadP.TabIndex = 187;
			this.lCantidadP.Text = "Cantidad";
			// 
			// lbSeccion
			// 
			this.lbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSeccion.ForeColor = System.Drawing.Color.Silver;
			this.lbSeccion.Location = new System.Drawing.Point(564, 261);
			this.lbSeccion.Name = "lbSeccion";
			this.lbSeccion.Size = new System.Drawing.Size(132, 40);
			this.lbSeccion.TabIndex = 188;
			this.lbSeccion.Text = "Seccion";
			// 
			// lbNombreP
			// 
			this.lbNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNombreP.ForeColor = System.Drawing.Color.Silver;
			this.lbNombreP.Location = new System.Drawing.Point(399, 261);
			this.lbNombreP.Name = "lbNombreP";
			this.lbNombreP.Size = new System.Drawing.Size(132, 40);
			this.lbNombreP.TabIndex = 189;
			this.lbNombreP.Text = "Nombre";
			// 
			// lbCodigoP
			// 
			this.lbCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCodigoP.ForeColor = System.Drawing.Color.Silver;
			this.lbCodigoP.Location = new System.Drawing.Point(238, 261);
			this.lbCodigoP.Name = "lbCodigoP";
			this.lbCodigoP.Size = new System.Drawing.Size(132, 40);
			this.lbCodigoP.TabIndex = 190;
			this.lbCodigoP.Text = "Codigo";
			// 
			// lbCodigoV
			// 
			this.lbCodigoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCodigoV.ForeColor = System.Drawing.Color.Silver;
			this.lbCodigoV.Location = new System.Drawing.Point(399, 436);
			this.lbCodigoV.Name = "lbCodigoV";
			this.lbCodigoV.Size = new System.Drawing.Size(132, 40);
			this.lbCodigoV.TabIndex = 191;
			this.lbCodigoV.Text = "Codigo";
			// 
			// lbVideo
			// 
			this.lbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbVideo.ForeColor = System.Drawing.Color.Silver;
			this.lbVideo.Location = new System.Drawing.Point(574, 436);
			this.lbVideo.Name = "lbVideo";
			this.lbVideo.Size = new System.Drawing.Size(132, 40);
			this.lbVideo.TabIndex = 192;
			this.lbVideo.Text = "Nombre";
			// 
			// Revista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.Controls.Add(this.lbVideo);
			this.Controls.Add(this.lbCodigoV);
			this.Controls.Add(this.lbCodigoP);
			this.Controls.Add(this.lbNombreP);
			this.Controls.Add(this.lbSeccion);
			this.Controls.Add(this.lCantidadP);
			this.Controls.Add(this.lbCantidad);
			this.Controls.Add(this.lbNombreR);
			this.Controls.Add(this.lbNoR);
			this.Controls.Add(this.pictureboxsalir);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnBuscarPeriodico);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBuscarRevista);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.txtNumero);
			this.Name = "Revista";
			this.Size = new System.Drawing.Size(908, 529);
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
