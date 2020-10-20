/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 23/05/2019
 * Hora: 11:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class Agregar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelUbicacion;
		public System.Windows.Forms.Button btnLimiar;
		public System.Windows.Forms.Button btActivar;
		private System.Windows.Forms.TextBox tbCant;
		private System.Windows.Forms.Label lbCant;
		private System.Windows.Forms.TextBox tbApellido;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Panel panelLineUser;
		public System.Windows.Forms.TextBox tbSearchQuotation;
		public System.Windows.Forms.Button btnBarCode;
		public System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lbDatos;
		private System.Windows.Forms.TextBox tbEditionBook;
		private System.Windows.Forms.TextBox tbNPages;
		private System.Windows.Forms.TextBox tbEditorial;
		private System.Windows.Forms.TextBox tbAuthor;
		private System.Windows.Forms.TextBox tbISBN;
		private System.Windows.Forms.TextBox tbdAnio;
		private System.Windows.Forms.TextBox tbNameBook;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.PictureBox pictureboxsalir;
		private System.Windows.Forms.TextBox tbUbicacion;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
			this.labelUbicacion = new System.Windows.Forms.Label();
			this.btnLimiar = new System.Windows.Forms.Button();
			this.btActivar = new System.Windows.Forms.Button();
			this.tbCant = new System.Windows.Forms.TextBox();
			this.lbCant = new System.Windows.Forms.Label();
			this.tbApellido = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelLineUser = new System.Windows.Forms.Panel();
			this.tbSearchQuotation = new System.Windows.Forms.TextBox();
			this.btnBarCode = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lbDatos = new System.Windows.Forms.Label();
			this.tbEditionBook = new System.Windows.Forms.TextBox();
			this.tbNPages = new System.Windows.Forms.TextBox();
			this.tbEditorial = new System.Windows.Forms.TextBox();
			this.tbAuthor = new System.Windows.Forms.TextBox();
			this.tbISBN = new System.Windows.Forms.TextBox();
			this.tbNameBook = new System.Windows.Forms.TextBox();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.tbdAnio = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureboxsalir = new System.Windows.Forms.PictureBox();
			this.tbUbicacion = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).BeginInit();
			this.SuspendLayout();
			// 
			// labelUbicacion
			// 
			this.labelUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUbicacion.Location = new System.Drawing.Point(452, 144);
			this.labelUbicacion.Name = "labelUbicacion";
			this.labelUbicacion.Size = new System.Drawing.Size(82, 23);
			this.labelUbicacion.TabIndex = 79;
			this.labelUbicacion.Text = "Ubicación:";
			// 
			// btnLimiar
			// 
			this.btnLimiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btnLimiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimiar.FlatAppearance.BorderSize = 0;
			this.btnLimiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimiar.ForeColor = System.Drawing.Color.White;
			this.btnLimiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimiar.Image")));
			this.btnLimiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimiar.Location = new System.Drawing.Point(561, 194);
			this.btnLimiar.Name = "btnLimiar";
			this.btnLimiar.Size = new System.Drawing.Size(292, 73);
			this.btnLimiar.TabIndex = 78;
			this.btnLimiar.Text = "Limpiar";
			this.btnLimiar.UseVisualStyleBackColor = false;
			this.btnLimiar.Click += new System.EventHandler(this.BtnLimiarClick);
			// 
			// btActivar
			// 
			this.btActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btActivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btActivar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btActivar.FlatAppearance.BorderSize = 0;
			this.btActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btActivar.ForeColor = System.Drawing.Color.White;
			this.btActivar.Image = ((System.Drawing.Image)(resources.GetObject("btActivar.Image")));
			this.btActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btActivar.Location = new System.Drawing.Point(690, 462);
			this.btActivar.Name = "btActivar";
			this.btActivar.Size = new System.Drawing.Size(198, 45);
			this.btActivar.TabIndex = 77;
			this.btActivar.Text = "Activar";
			this.btActivar.UseVisualStyleBackColor = false;
			this.btActivar.Click += new System.EventHandler(this.BtActivarClick);
			// 
			// tbCant
			// 
			this.tbCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCant.Location = new System.Drawing.Point(557, 107);
			this.tbCant.Name = "tbCant";
			this.tbCant.Size = new System.Drawing.Size(292, 20);
			this.tbCant.TabIndex = 76;
			// 
			// lbCant
			// 
			this.lbCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCant.Location = new System.Drawing.Point(452, 107);
			this.lbCant.Name = "lbCant";
			this.lbCant.Size = new System.Drawing.Size(76, 23);
			this.lbCant.TabIndex = 75;
			this.lbCant.Text = "Cantidad:";
			// 
			// tbApellido
			// 
			this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbApellido.Location = new System.Drawing.Point(132, 197);
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(292, 20);
			this.tbApellido.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 197);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 23);
			this.label1.TabIndex = 73;
			this.label1.Text = "Apellido autor:";
			// 
			// panelLineUser
			// 
			this.panelLineUser.BackColor = System.Drawing.Color.Black;
			this.panelLineUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineUser.Location = new System.Drawing.Point(690, 368);
			this.panelLineUser.Name = "panelLineUser";
			this.panelLineUser.Size = new System.Drawing.Size(198, 3);
			this.panelLineUser.TabIndex = 72;
			// 
			// tbSearchQuotation
			// 
			this.tbSearchQuotation.BackColor = System.Drawing.SystemColors.Control;
			this.tbSearchQuotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSearchQuotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbSearchQuotation.ForeColor = System.Drawing.Color.Black;
			this.tbSearchQuotation.Location = new System.Drawing.Point(703, 339);
			this.tbSearchQuotation.MaxLength = 13;
			this.tbSearchQuotation.Name = "tbSearchQuotation";
			this.tbSearchQuotation.Size = new System.Drawing.Size(150, 19);
			this.tbSearchQuotation.TabIndex = 71;
			this.tbSearchQuotation.Text = "Introduce ID";
			// 
			// btnBarCode
			// 
			this.btnBarCode.BackColor = System.Drawing.SystemColors.Control;
			this.btnBarCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBarCode.BackgroundImage")));
			this.btnBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBarCode.FlatAppearance.BorderSize = 0;
			this.btnBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBarCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBarCode.Location = new System.Drawing.Point(859, 336);
			this.btnBarCode.Name = "btnBarCode";
			this.btnBarCode.Size = new System.Drawing.Size(39, 26);
			this.btnBarCode.TabIndex = 70;
			this.btnBarCode.UseVisualStyleBackColor = false;
			this.btnBarCode.Click += new System.EventHandler(this.BtnBarCodeClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(690, 392);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(198, 45);
			this.btnDelete.TabIndex = 69;
			this.btnDelete.Text = "Desactivar";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// lbDatos
			// 
			this.lbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDatos.Location = new System.Drawing.Point(21, 19);
			this.lbDatos.Name = "lbDatos";
			this.lbDatos.Size = new System.Drawing.Size(136, 47);
			this.lbDatos.TabIndex = 68;
			this.lbDatos.Text = "Datos:";
			// 
			// tbEditionBook
			// 
			this.tbEditionBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEditionBook.Location = new System.Drawing.Point(557, 71);
			this.tbEditionBook.Name = "tbEditionBook";
			this.tbEditionBook.Size = new System.Drawing.Size(292, 20);
			this.tbEditionBook.TabIndex = 62;
			// 
			// tbNPages
			// 
			this.tbNPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNPages.Location = new System.Drawing.Point(132, 296);
			this.tbNPages.Name = "tbNPages";
			this.tbNPages.Size = new System.Drawing.Size(292, 20);
			this.tbNPages.TabIndex = 61;
			// 
			// tbEditorial
			// 
			this.tbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEditorial.Location = new System.Drawing.Point(133, 247);
			this.tbEditorial.Name = "tbEditorial";
			this.tbEditorial.Size = new System.Drawing.Size(292, 20);
			this.tbEditorial.TabIndex = 63;
			// 
			// tbAuthor
			// 
			this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAuthor.Location = new System.Drawing.Point(133, 147);
			this.tbAuthor.Name = "tbAuthor";
			this.tbAuthor.Size = new System.Drawing.Size(292, 20);
			this.tbAuthor.TabIndex = 66;
			// 
			// tbISBN
			// 
			this.tbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbISBN.Location = new System.Drawing.Point(133, 108);
			this.tbISBN.Name = "tbISBN";
			this.tbISBN.Size = new System.Drawing.Size(292, 20);
			this.tbISBN.TabIndex = 67;
			// 
			// tbNameBook
			// 
			this.tbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNameBook.Location = new System.Drawing.Point(132, 69);
			this.tbNameBook.Name = "tbNameBook";
			this.tbNameBook.Size = new System.Drawing.Size(292, 20);
			this.tbNameBook.TabIndex = 65;
			// 
			// btnAddBook
			// 
			this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddBook.FlatAppearance.BorderSize = 0;
			this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddBook.ForeColor = System.Drawing.Color.White;
			this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddBook.Location = new System.Drawing.Point(196, 462);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(229, 57);
			this.btnAddBook.TabIndex = 60;
			this.btnAddBook.Text = "Añadir libro";
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.BtnAddBookClick);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(452, 68);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(76, 23);
			this.label11.TabIndex = 58;
			this.label11.Text = "Edición:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(10, 296);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 23);
			this.label12.TabIndex = 59;
			this.label12.Text = "Páginas:";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(10, 247);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 23);
			this.label14.TabIndex = 57;
			this.label14.Text = "Editorial:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(10, 147);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(116, 23);
			this.label15.TabIndex = 54;
			this.label15.Text = "Nombre autor:";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(10, 108);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(65, 23);
			this.label16.TabIndex = 53;
			this.label16.Text = "ISBN:";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(9, 69);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(116, 23);
			this.label18.TabIndex = 55;
			this.label18.Text = "Nombre libro:";
			// 
			// tbdAnio
			// 
			this.tbdAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbdAnio.Location = new System.Drawing.Point(133, 341);
			this.tbdAnio.Name = "tbdAnio";
			this.tbdAnio.Size = new System.Drawing.Size(292, 20);
			this.tbdAnio.TabIndex = 64;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(10, 339);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 23);
			this.label17.TabIndex = 56;
			this.label17.Text = "Año:";
			// 
			// pictureboxsalir
			// 
			this.pictureboxsalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxsalir.Image")));
			this.pictureboxsalir.Location = new System.Drawing.Point(10, 476);
			this.pictureboxsalir.Name = "pictureboxsalir";
			this.pictureboxsalir.Size = new System.Drawing.Size(68, 50);
			this.pictureboxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureboxsalir.TabIndex = 81;
			this.pictureboxsalir.TabStop = false;
			this.pictureboxsalir.Click += new System.EventHandler(this.PictureboxsalirClick);
			// 
			// tbUbicacion
			// 
			this.tbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUbicacion.Location = new System.Drawing.Point(557, 144);
			this.tbUbicacion.Name = "tbUbicacion";
			this.tbUbicacion.Size = new System.Drawing.Size(292, 20);
			this.tbUbicacion.TabIndex = 82;
			// 
			// Agregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbUbicacion);
			this.Controls.Add(this.pictureboxsalir);
			this.Controls.Add(this.labelUbicacion);
			this.Controls.Add(this.btnLimiar);
			this.Controls.Add(this.btActivar);
			this.Controls.Add(this.tbCant);
			this.Controls.Add(this.lbCant);
			this.Controls.Add(this.tbApellido);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelLineUser);
			this.Controls.Add(this.tbSearchQuotation);
			this.Controls.Add(this.btnBarCode);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lbDatos);
			this.Controls.Add(this.tbEditionBook);
			this.Controls.Add(this.tbNPages);
			this.Controls.Add(this.tbEditorial);
			this.Controls.Add(this.tbAuthor);
			this.Controls.Add(this.tbISBN);
			this.Controls.Add(this.tbdAnio);
			this.Controls.Add(this.tbNameBook);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Name = "Agregar";
			this.Size = new System.Drawing.Size(908, 529);
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
