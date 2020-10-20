/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 22/05/2019
 * Hora: 11:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Biblioteca
{
	partial class btnPrestamo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataviewlibro;
		private System.Windows.Forms.DataGridView dataviewcliente;
		private System.Windows.Forms.Label lbLibro;
		private System.Windows.Forms.Label lbPrestamo;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Button btnISBN;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btPrestamo;
		private System.Windows.Forms.Button btnDevolver;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Button btnLiquidar;
		private System.Windows.Forms.Panel panelLineUser;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnaddcli;
		private System.Windows.Forms.Button btnconsulta;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.PictureBox pictureboxsalir;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnPerfil;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbUsuario;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox txtIdEj;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn autor;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
		private System.Windows.Forms.DataGridViewTextBoxColumn edicion;
		private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
		private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn ejemplar;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numEjemplar;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechalimite;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaentrega;
		private System.Windows.Forms.DataGridViewTextBoxColumn folio;
		private System.Windows.Forms.DataGridViewTextBoxColumn estatusMulta;
		private System.Windows.Forms.DataGridViewTextBoxColumn importe;
		private System.Windows.Forms.Label lbfPrestamo;
		private System.Windows.Forms.Label lblimite;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txtEntrega;
		private System.Windows.Forms.Label label4;
		
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnPrestamo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataviewcliente = new System.Windows.Forms.DataGridView();
			this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numEjemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechalimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estatusMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbLibro = new System.Windows.Forms.Label();
			this.lbPrestamo = new System.Windows.Forms.Label();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.btnISBN = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btPrestamo = new System.Windows.Forms.Button();
			this.btnDevolver = new System.Windows.Forms.Button();
			this.txtIdEj = new System.Windows.Forms.TextBox();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.btnLiquidar = new System.Windows.Forms.Button();
			this.panelLineUser = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnaddcli = new System.Windows.Forms.Button();
			this.btnconsulta = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.pictureboxsalir = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnPerfil = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbUsuario = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dataviewlibro = new System.Windows.Forms.DataGridView();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbfPrestamo = new System.Windows.Forms.Label();
			this.lblimite = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtEntrega = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataviewcliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataviewlibro)).BeginInit();
			this.SuspendLayout();
			// 
			// dataviewcliente
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataviewcliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataviewcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataviewcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nombreCliente,
			this.apellidoCliente,
			this.isbn,
			this.numEjemplar,
			this.fecha,
			this.fechalimite,
			this.fechaentrega,
			this.folio,
			this.estatusMulta,
			this.importe});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataviewcliente.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataviewcliente.Location = new System.Drawing.Point(28, 224);
			this.dataviewcliente.Name = "dataviewcliente";
			this.dataviewcliente.Size = new System.Drawing.Size(629, 90);
			this.dataviewcliente.TabIndex = 1;
			// 
			// nombreCliente
			// 
			this.nombreCliente.HeaderText = "Nombre";
			this.nombreCliente.Name = "nombreCliente";
			// 
			// apellidoCliente
			// 
			this.apellidoCliente.HeaderText = "Apellido";
			this.apellidoCliente.Name = "apellidoCliente";
			// 
			// isbn
			// 
			this.isbn.HeaderText = "ISBN";
			this.isbn.Name = "isbn";
			// 
			// numEjemplar
			// 
			this.numEjemplar.HeaderText = "Num. Ejemplar";
			this.numEjemplar.Name = "numEjemplar";
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha prestamo";
			this.fecha.Name = "fecha";
			// 
			// fechalimite
			// 
			this.fechalimite.HeaderText = "Fecha limite";
			this.fechalimite.Name = "fechalimite";
			// 
			// fechaentrega
			// 
			this.fechaentrega.HeaderText = "Fecha Entrega";
			this.fechaentrega.Name = "fechaentrega";
			// 
			// folio
			// 
			this.folio.HeaderText = "Folio Multa";
			this.folio.Name = "folio";
			// 
			// estatusMulta
			// 
			this.estatusMulta.HeaderText = "Estatus multa";
			this.estatusMulta.Name = "estatusMulta";
			// 
			// importe
			// 
			this.importe.HeaderText = "Importe";
			this.importe.Name = "importe";
			// 
			// lbLibro
			// 
			this.lbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLibro.ForeColor = System.Drawing.Color.White;
			this.lbLibro.Location = new System.Drawing.Point(295, 63);
			this.lbLibro.Name = "lbLibro";
			this.lbLibro.Size = new System.Drawing.Size(100, 23);
			this.lbLibro.TabIndex = 2;
			this.lbLibro.Text = "Libro";
			this.lbLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPrestamo
			// 
			this.lbPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPrestamo.ForeColor = System.Drawing.Color.White;
			this.lbPrestamo.Location = new System.Drawing.Point(295, 185);
			this.lbPrestamo.Name = "lbPrestamo";
			this.lbPrestamo.Size = new System.Drawing.Size(100, 23);
			this.lbPrestamo.TabIndex = 3;
			this.lbPrestamo.Text = "Cliente";
			this.lbPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtISBN
			// 
			this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtISBN.Location = new System.Drawing.Point(87, 410);
			this.txtISBN.Multiline = true;
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(100, 23);
			this.txtISBN.TabIndex = 4;
			this.txtISBN.Text = "ISBN";
			this.txtISBN.Enter += new System.EventHandler(this.TxtISBNEnter);
			this.txtISBN.Leave += new System.EventHandler(this.TxtISBNLeave);
			// 
			// txtCliente
			// 
			this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtCliente.Location = new System.Drawing.Point(87, 467);
			this.txtCliente.Multiline = true;
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(100, 23);
			this.txtCliente.TabIndex = 5;
			this.txtCliente.Text = "Cliente";
			this.txtCliente.Enter += new System.EventHandler(this.TxtClienteEnter);
			this.txtCliente.Leave += new System.EventHandler(this.TxtClienteLeave);
			// 
			// btnISBN
			// 
			this.btnISBN.BackColor = System.Drawing.Color.White;
			this.btnISBN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnISBN.Image = ((System.Drawing.Image)(resources.GetObject("btnISBN.Image")));
			this.btnISBN.Location = new System.Drawing.Point(28, 395);
			this.btnISBN.Name = "btnISBN";
			this.btnISBN.Size = new System.Drawing.Size(53, 38);
			this.btnISBN.TabIndex = 6;
			this.btnISBN.UseVisualStyleBackColor = false;
			this.btnISBN.Click += new System.EventHandler(this.BtnISBNClick);
			// 
			// btnCliente
			// 
			this.btnCliente.BackColor = System.Drawing.Color.White;
			this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCliente.ForeColor = System.Drawing.Color.White;
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(28, 451);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(56, 41);
			this.btnCliente.TabIndex = 7;
			this.btnCliente.UseVisualStyleBackColor = false;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// btPrestamo
			// 
			this.btPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPrestamo.ForeColor = System.Drawing.Color.Black;
			this.btPrestamo.Location = new System.Drawing.Point(266, 464);
			this.btPrestamo.Name = "btPrestamo";
			this.btPrestamo.Size = new System.Drawing.Size(122, 35);
			this.btPrestamo.TabIndex = 8;
			this.btPrestamo.Text = "Prestamo";
			this.btPrestamo.UseVisualStyleBackColor = true;
			this.btPrestamo.Click += new System.EventHandler(this.BtPrestamoClick);
			// 
			// btnDevolver
			// 
			this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDevolver.ForeColor = System.Drawing.Color.Black;
			this.btnDevolver.Location = new System.Drawing.Point(413, 464);
			this.btnDevolver.Name = "btnDevolver";
			this.btnDevolver.Size = new System.Drawing.Size(122, 35);
			this.btnDevolver.TabIndex = 9;
			this.btnDevolver.Text = "Devolución";
			this.btnDevolver.UseVisualStyleBackColor = true;
			this.btnDevolver.Click += new System.EventHandler(this.BtnDevolverClick);
			// 
			// txtIdEj
			// 
			this.txtIdEj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtIdEj.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtIdEj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdEj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtIdEj.Location = new System.Drawing.Point(29, 353);
			this.txtIdEj.Multiline = true;
			this.txtIdEj.Name = "txtIdEj";
			this.txtIdEj.Size = new System.Drawing.Size(98, 26);
			this.txtIdEj.TabIndex = 10;
			this.txtIdEj.Text = "ID Ejemplar";
			this.txtIdEj.Enter += new System.EventHandler(this.TxtIdEjEnter);
			this.txtIdEj.Leave += new System.EventHandler(this.TxtIdEjLeave);
			// 
			// txtFolio
			// 
			this.txtFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtFolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtFolio.Location = new System.Drawing.Point(711, 441);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(100, 22);
			this.txtFolio.TabIndex = 11;
			this.txtFolio.Text = "Folio";
			this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFolio.Enter += new System.EventHandler(this.TextBox4Enter);
			this.txtFolio.Leave += new System.EventHandler(this.TextBox4Leave);
			// 
			// btnLiquidar
			// 
			this.btnLiquidar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLiquidar.ForeColor = System.Drawing.Color.Black;
			this.btnLiquidar.Location = new System.Drawing.Point(697, 479);
			this.btnLiquidar.Name = "btnLiquidar";
			this.btnLiquidar.Size = new System.Drawing.Size(122, 33);
			this.btnLiquidar.TabIndex = 13;
			this.btnLiquidar.Text = "Liquidar";
			this.btnLiquidar.UseVisualStyleBackColor = true;
			this.btnLiquidar.Click += new System.EventHandler(this.BtnLiquidarClick);
			// 
			// panelLineUser
			// 
			this.panelLineUser.BackColor = System.Drawing.Color.Black;
			this.panelLineUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineUser.Location = new System.Drawing.Point(28, 439);
			this.panelLineUser.Name = "panelLineUser";
			this.panelLineUser.Size = new System.Drawing.Size(159, 4);
			this.panelLineUser.TabIndex = 19;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Location = new System.Drawing.Point(28, 504);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(159, 4);
			this.panel1.TabIndex = 20;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel2.Location = new System.Drawing.Point(29, 385);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(122, 4);
			this.panel2.TabIndex = 20;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel3.Location = new System.Drawing.Point(711, 469);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(100, 4);
			this.panel3.TabIndex = 21;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.Location = new System.Drawing.Point(697, 89);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(144, 51);
			this.btnAdd.TabIndex = 23;
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnaddcli
			// 
			this.btnaddcli.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnaddcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnaddcli.ForeColor = System.Drawing.Color.Black;
			this.btnaddcli.Location = new System.Drawing.Point(697, 171);
			this.btnaddcli.Name = "btnaddcli";
			this.btnaddcli.Size = new System.Drawing.Size(144, 51);
			this.btnaddcli.TabIndex = 24;
			this.btnaddcli.Text = "Cliente";
			this.btnaddcli.UseVisualStyleBackColor = true;
			this.btnaddcli.Click += new System.EventHandler(this.BtnaddcliClick);
			// 
			// btnconsulta
			// 
			this.btnconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnconsulta.ForeColor = System.Drawing.Color.Black;
			this.btnconsulta.Location = new System.Drawing.Point(697, 250);
			this.btnconsulta.Name = "btnconsulta";
			this.btnconsulta.Size = new System.Drawing.Size(144, 51);
			this.btnconsulta.TabIndex = 25;
			this.btnconsulta.Text = "Consulta";
			this.btnconsulta.UseVisualStyleBackColor = true;
			this.btnconsulta.Click += new System.EventHandler(this.BtnconsultaClick);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
			this.btnlimpiar.Location = new System.Drawing.Point(697, 328);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(144, 51);
			this.btnlimpiar.TabIndex = 26;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// pictureboxsalir
			// 
			this.pictureboxsalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureboxsalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxsalir.Image")));
			this.pictureboxsalir.Location = new System.Drawing.Point(849, 490);
			this.pictureboxsalir.Name = "pictureboxsalir";
			this.pictureboxsalir.Size = new System.Drawing.Size(47, 33);
			this.pictureboxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureboxsalir.TabIndex = 27;
			this.pictureboxsalir.TabStop = false;
			this.pictureboxsalir.Click += new System.EventHandler(this.PictureboxsalirClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(734, 402);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(52, 33);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 28;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(834, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(74, 50);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 29;
			this.pictureBox3.TabStop = false;
			// 
			// btnPerfil
			// 
			this.btnPerfil.ForeColor = System.Drawing.Color.Black;
			this.btnPerfil.Location = new System.Drawing.Point(830, 56);
			this.btnPerfil.Name = "btnPerfil";
			this.btnPerfil.Size = new System.Drawing.Size(75, 23);
			this.btnPerfil.TabIndex = 30;
			this.btnPerfil.Text = "Perfil";
			this.btnPerfil.UseVisualStyleBackColor = true;
			this.btnPerfil.Click += new System.EventHandler(this.BtnPerfilClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(615, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 31;
			this.label1.Text = "-Usuario:";
			// 
			// lbUsuario
			// 
			this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsuario.ForeColor = System.Drawing.Color.White;
			this.lbUsuario.Location = new System.Drawing.Point(711, 12);
			this.lbUsuario.Name = "lbUsuario";
			this.lbUsuario.Size = new System.Drawing.Size(100, 23);
			this.lbUsuario.TabIndex = 32;
			// 
			// lbTime
			// 
			this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.White;
			this.lbTime.Location = new System.Drawing.Point(251, 12);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(233, 23);
			this.lbTime.TabIndex = 33;
			this.lbTime.Text = "hora";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// dataviewlibro
			// 
			this.dataviewlibro.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataviewlibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataviewlibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataviewlibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nombre,
			this.autor,
			this.apellido,
			this.editorial,
			this.edicion,
			this.paginas,
			this.estatus,
			this.ejemplar});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataviewlibro.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataviewlibro.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataviewlibro.Location = new System.Drawing.Point(28, 89);
			this.dataviewlibro.Name = "dataviewlibro";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataviewlibro.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataviewlibro.Size = new System.Drawing.Size(629, 90);
			this.dataviewlibro.TabIndex = 34;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			// 
			// autor
			// 
			this.autor.HeaderText = "Nom. Autor";
			this.autor.Name = "autor";
			// 
			// apellido
			// 
			this.apellido.HeaderText = "Ap. Autor";
			this.apellido.Name = "apellido";
			// 
			// editorial
			// 
			this.editorial.HeaderText = "Editorial";
			this.editorial.Name = "editorial";
			// 
			// edicion
			// 
			this.edicion.HeaderText = "Edicion";
			this.edicion.Name = "edicion";
			// 
			// paginas
			// 
			this.paginas.HeaderText = "Paginas";
			this.paginas.Name = "paginas";
			// 
			// estatus
			// 
			this.estatus.HeaderText = "Estatus";
			this.estatus.Name = "estatus";
			// 
			// ejemplar
			// 
			this.ejemplar.HeaderText = "Num. Ejemplar";
			this.ejemplar.Name = "ejemplar";
			// 
			// lbfPrestamo
			// 
			this.lbfPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbfPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbfPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.lbfPrestamo.Location = new System.Drawing.Point(216, 423);
			this.lbfPrestamo.Name = "lbfPrestamo";
			this.lbfPrestamo.Size = new System.Drawing.Size(122, 23);
			this.lbfPrestamo.TabIndex = 35;
			this.lbfPrestamo.Text = "Fecha Prestamo";
			// 
			// lblimite
			// 
			this.lblimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.lblimite.Location = new System.Drawing.Point(361, 423);
			this.lblimite.Name = "lblimite";
			this.lblimite.Size = new System.Drawing.Size(100, 23);
			this.lblimite.TabIndex = 36;
			this.lblimite.Text = "Fecha Limite";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel4.Location = new System.Drawing.Point(216, 452);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 4);
			this.panel4.TabIndex = 22;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel5.Location = new System.Drawing.Point(354, 452);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(122, 4);
			this.panel5.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(216, 385);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 23);
			this.label2.TabIndex = 37;
			this.label2.Text = "Fecha Prestamo";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(361, 385);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 23);
			this.label3.TabIndex = 38;
			this.label3.Text = "Fecha Limite";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel6.Location = new System.Drawing.Point(482, 451);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(122, 4);
			this.panel6.TabIndex = 23;
			// 
			// txtEntrega
			// 
			this.txtEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.txtEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
			this.txtEntrega.Location = new System.Drawing.Point(489, 426);
			this.txtEntrega.Multiline = true;
			this.txtEntrega.Name = "txtEntrega";
			this.txtEntrega.Size = new System.Drawing.Size(100, 20);
			this.txtEntrega.TabIndex = 39;
			this.txtEntrega.Text = "dd-mm-yyyy";
			this.txtEntrega.Enter += new System.EventHandler(this.TxtEntregaEnter);
			this.txtEntrega.Leave += new System.EventHandler(this.TxtEntregaLeave);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(482, 384);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 23);
			this.label4.TabIndex = 40;
			this.label4.Text = "Fecha Entrega ";
			// 
			// btnPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEntrega);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.lblimite);
			this.Controls.Add(this.lbfPrestamo);
			this.Controls.Add(this.dataviewlibro);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPerfil);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureboxsalir);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btnconsulta);
			this.Controls.Add(this.btnaddcli);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btPrestamo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelLineUser);
			this.Controls.Add(this.btnLiquidar);
			this.Controls.Add(this.txtFolio);
			this.Controls.Add(this.txtIdEj);
			this.Controls.Add(this.btnDevolver);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.btnISBN);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.txtISBN);
			this.Controls.Add(this.lbPrestamo);
			this.Controls.Add(this.lbLibro);
			this.Controls.Add(this.dataviewcliente);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "btnPrestamo";
			this.Size = new System.Drawing.Size(908, 529);
			this.Load += new System.EventHandler(this.BtnPrestamoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataviewcliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxsalir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataviewlibro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
