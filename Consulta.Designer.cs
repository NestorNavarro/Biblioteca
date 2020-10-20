/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 23/05/2019
 * Hora: 12:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class Consulta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSearch;
		public System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnOtros;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView dataviewlibro;
		private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreautor;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoautor;
		private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
		private System.Windows.Forms.DataGridViewTextBoxColumn edicion;
		private System.Windows.Forms.DataGridViewTextBoxColumn anio;
		private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.PictureBox pictureboxsalir;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnOtros = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dataviewlibro = new System.Windows.Forms.DataGridView();
			this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreautor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoautor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.pictureboxsalir = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataviewlibro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(960, 70);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(46, 45);
			this.btnSearch.TabIndex = 33;
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.White;
			this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
			this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiar.Location = new System.Drawing.Point(466, 355);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(229, 57);
			this.btnLimpiar.TabIndex = 186;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnOtros
			// 
			this.btnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btnOtros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnOtros.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOtros.FlatAppearance.BorderSize = 0;
			this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOtros.ForeColor = System.Drawing.Color.White;
			this.btnOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOtros.Location = new System.Drawing.Point(195, 355);
			this.btnOtros.Name = "btnOtros";
			this.btnOtros.Size = new System.Drawing.Size(229, 57);
			this.btnOtros.TabIndex = 185;
			this.btnOtros.Text = "Otros";
			this.btnOtros.UseVisualStyleBackColor = false;
			this.btnOtros.Click += new System.EventHandler(this.BtnOtrosClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
			this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(844, 18);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(46, 45);
			this.btnBuscar.TabIndex = 184;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// dataviewlibro
			// 
			this.dataviewlibro.BackgroundColor = System.Drawing.Color.White;
			this.dataviewlibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataviewlibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.isbn,
			this.titulo,
			this.nombreautor,
			this.apellidoautor,
			this.editorial,
			this.edicion,
			this.anio,
			this.paginas,
			this.cantidad,
			this.ubicacion});
			this.dataviewlibro.Location = new System.Drawing.Point(18, 144);
			this.dataviewlibro.Name = "dataviewlibro";
			this.dataviewlibro.Size = new System.Drawing.Size(883, 159);
			this.dataviewlibro.TabIndex = 183;
			// 
			// isbn
			// 
			this.isbn.HeaderText = "ISBN";
			this.isbn.Name = "isbn";
			// 
			// titulo
			// 
			this.titulo.HeaderText = "Título";
			this.titulo.Name = "titulo";
			// 
			// nombreautor
			// 
			this.nombreautor.HeaderText = "Nombre Autor";
			this.nombreautor.Name = "nombreautor";
			// 
			// apellidoautor
			// 
			this.apellidoautor.HeaderText = "Apellido Autor";
			this.apellidoautor.Name = "apellidoautor";
			// 
			// editorial
			// 
			this.editorial.HeaderText = "Editorial";
			this.editorial.Name = "editorial";
			// 
			// edicion
			// 
			this.edicion.HeaderText = "Edición";
			this.edicion.Name = "edicion";
			// 
			// anio
			// 
			this.anio.HeaderText = "Año";
			this.anio.Name = "anio";
			// 
			// paginas
			// 
			this.paginas.HeaderText = "Páginas";
			this.paginas.Name = "paginas";
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
			// 
			// ubicacion
			// 
			this.ubicacion.HeaderText = "Ubicación";
			this.ubicacion.Name = "ubicacion";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(706, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 182;
			this.label3.Text = "ISBN";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(424, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 181;
			this.label2.Text = "Autor";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(109, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 23);
			this.label1.TabIndex = 180;
			this.label1.Text = "Nombre";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel3.ForeColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(31, 95);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 3);
			this.panel3.TabIndex = 177;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel2.ForeColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(610, 95);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 3);
			this.panel2.TabIndex = 179;
			// 
			// txtISBN
			// 
			this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtISBN.Location = new System.Drawing.Point(660, 59);
			this.txtISBN.MaxLength = 13;
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(190, 22);
			this.txtISBN.TabIndex = 178;
			this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.ForeColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(327, 95);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 3);
			this.panel1.TabIndex = 176;
			// 
			// txtAutor
			// 
			this.txtAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.txtAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtAutor.Location = new System.Drawing.Point(327, 59);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(250, 22);
			this.txtAutor.TabIndex = 175;
			this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtNombre.Location = new System.Drawing.Point(18, 59);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(250, 22);
			this.txtNombre.TabIndex = 174;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureboxsalir
			// 
			this.pictureboxsalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxsalir.Image")));
			this.pictureboxsalir.Location = new System.Drawing.Point(8, 460);
			this.pictureboxsalir.Name = "pictureboxsalir";
			this.pictureboxsalir.Size = new System.Drawing.Size(68, 50);
			this.pictureboxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureboxsalir.TabIndex = 173;
			this.pictureboxsalir.TabStop = false;
			this.pictureboxsalir.Click += new System.EventHandler(this.PictureboxsalirClick);
			// 
			// Consulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnOtros);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dataviewlibro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtISBN);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.pictureboxsalir);
			this.Controls.Add(this.btnSearch);
			this.Name = "Consulta";
			this.Size = new System.Drawing.Size(908, 529);
			((System.ComponentModel.ISupportInitialize)(this.dataviewlibro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
