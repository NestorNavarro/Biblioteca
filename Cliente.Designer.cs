/*
 * Created by SharpDevelop.
 * User: sony_
 * Date: 24/05/2019
 * Time: 10:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class Cliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbCant;
		private System.Windows.Forms.TextBox tbApellido;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbEditionBook;
		private System.Windows.Forms.TextBox tbNPages;
		private System.Windows.Forms.TextBox tbEditorial;
		private System.Windows.Forms.TextBox tbAuthor;
		private System.Windows.Forms.TextBox tbISBN;
		private System.Windows.Forms.TextBox tbNameBook;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.PictureBox pBoxSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox c;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
			this.c = new System.Windows.Forms.TextBox();
			this.lbCant = new System.Windows.Forms.Label();
			this.tbApellido = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbEditionBook = new System.Windows.Forms.TextBox();
			this.tbNPages = new System.Windows.Forms.TextBox();
			this.tbEditorial = new System.Windows.Forms.TextBox();
			this.tbAuthor = new System.Windows.Forms.TextBox();
			this.tbISBN = new System.Windows.Forms.TextBox();
			this.tbNameBook = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.pBoxSalir = new System.Windows.Forms.PictureBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pBoxSalir)).BeginInit();
			this.SuspendLayout();
			// 
			// c
			// 
			this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c.Location = new System.Drawing.Point(139, 236);
			this.c.Name = "c";
			this.c.Size = new System.Drawing.Size(292, 20);
			this.c.TabIndex = 97;
			// 
			// lbCant
			// 
			this.lbCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCant.Location = new System.Drawing.Point(16, 233);
			this.lbCant.Name = "lbCant";
			this.lbCant.Size = new System.Drawing.Size(108, 23);
			this.lbCant.TabIndex = 96;
			this.lbCant.Text = "Email:";
			// 
			// tbApellido
			// 
			this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbApellido.Location = new System.Drawing.Point(138, 197);
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(292, 20);
			this.tbApellido.TabIndex = 95;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 23);
			this.label1.TabIndex = 94;
			this.label1.Text = "CURP:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 47);
			this.label2.TabIndex = 93;
			this.label2.Text = "Datos del Cliente:";
			// 
			// tbEditionBook
			// 
			this.tbEditionBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEditionBook.Location = new System.Drawing.Point(138, 430);
			this.tbEditionBook.Name = "tbEditionBook";
			this.tbEditionBook.Size = new System.Drawing.Size(292, 20);
			this.tbEditionBook.TabIndex = 88;
			// 
			// tbNPages
			// 
			this.tbNPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNPages.Location = new System.Drawing.Point(137, 390);
			this.tbNPages.Name = "tbNPages";
			this.tbNPages.Size = new System.Drawing.Size(292, 20);
			this.tbNPages.TabIndex = 87;
			// 
			// tbEditorial
			// 
			this.tbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEditorial.Location = new System.Drawing.Point(138, 355);
			this.tbEditorial.Name = "tbEditorial";
			this.tbEditorial.Size = new System.Drawing.Size(292, 20);
			this.tbEditorial.TabIndex = 89;
			// 
			// tbAuthor
			// 
			this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAuthor.Location = new System.Drawing.Point(139, 158);
			this.tbAuthor.Name = "tbAuthor";
			this.tbAuthor.Size = new System.Drawing.Size(292, 20);
			this.tbAuthor.TabIndex = 91;
			// 
			// tbISBN
			// 
			this.tbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbISBN.Location = new System.Drawing.Point(139, 119);
			this.tbISBN.Name = "tbISBN";
			this.tbISBN.Size = new System.Drawing.Size(292, 20);
			this.tbISBN.TabIndex = 92;
			// 
			// tbNameBook
			// 
			this.tbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNameBook.Location = new System.Drawing.Point(138, 80);
			this.tbNameBook.Name = "tbNameBook";
			this.tbNameBook.Size = new System.Drawing.Size(292, 20);
			this.tbNameBook.TabIndex = 90;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(14, 427);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(116, 23);
			this.label11.TabIndex = 85;
			this.label11.Text = "Código Postal:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(14, 390);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 23);
			this.label12.TabIndex = 86;
			this.label12.Text = "Número:";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(15, 355);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 23);
			this.label14.TabIndex = 84;
			this.label14.Text = "Calle:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(16, 158);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(116, 23);
			this.label15.TabIndex = 82;
			this.label15.Text = "Apellido M:";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 119);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(93, 23);
			this.label16.TabIndex = 81;
			this.label16.Text = "Apellido P:";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(15, 80);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(116, 23);
			this.label18.TabIndex = 83;
			this.label18.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 299);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(265, 47);
			this.label3.TabIndex = 101;
			this.label3.Text = "Domicilio:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(640, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(265, 47);
			this.label4.TabIndex = 102;
			this.label4.Text = "Cuenta:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(578, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(292, 20);
			this.textBox1.TabIndex = 106;
			this.textBox1.UseSystemPasswordChar = true;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(577, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(292, 20);
			this.textBox2.TabIndex = 105;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(473, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 23);
			this.label5.TabIndex = 103;
			this.label5.Text = "Contraseña:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(473, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 23);
			this.label6.TabIndex = 104;
			this.label6.Text = "Usuario:";
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
			this.btnAddBook.Location = new System.Drawing.Point(640, 289);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(229, 57);
			this.btnAddBook.TabIndex = 107;
			this.btnAddBook.Text = "Añadir";
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.BtnAddBookClick);
			// 
			// pBoxSalir
			// 
			this.pBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pBoxSalir.Image")));
			this.pBoxSalir.Location = new System.Drawing.Point(780, 460);
			this.pBoxSalir.Name = "pBoxSalir";
			this.pBoxSalir.Size = new System.Drawing.Size(100, 50);
			this.pBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBoxSalir.TabIndex = 113;
			this.pBoxSalir.TabStop = false;
			this.pBoxSalir.Click += new System.EventHandler(this.PBoxSalirClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.White;
			this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiar.Location = new System.Drawing.Point(640, 194);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(229, 57);
			this.btnLimpiar.TabIndex = 114;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.pBoxSalir);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.c);
			this.Controls.Add(this.lbCant);
			this.Controls.Add(this.tbApellido);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbEditionBook);
			this.Controls.Add(this.tbNPages);
			this.Controls.Add(this.tbEditorial);
			this.Controls.Add(this.tbAuthor);
			this.Controls.Add(this.tbISBN);
			this.Controls.Add(this.tbNameBook);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label18);
			this.Name = "Cliente";
			this.Size = new System.Drawing.Size(908, 529);
			((System.ComponentModel.ISupportInitialize)(this.pBoxSalir)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
