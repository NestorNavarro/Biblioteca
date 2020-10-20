/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 23/05/2019
 * Hora: 11:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
	/// <summary>
	/// Description of Agregar.
	/// </summary>
	public partial class Agregar : UserControl
	{	
		MySqlConnection conexion;
		MySqlCommand cmd;
		MySqlDataReader lector;
		string sentencia;
		public Agregar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Conexion()
		{
			conexion = new MySqlConnection();
			conexion.ConnectionString = "server = localhost;password=;database = biblioteca; User Id=root";
		}
		void BtnBarCodeClick(object sender, EventArgs e)
		{
			int result = Int32.Parse(tbSearchQuotation.Text);
			sentencia = "SELECT l.isbn,l.nombre,i.cantidad,l.ubicacion,a.nombre,a.app,e.nombreed,i.edicion,i.anio,i.paginas, l.estado " +
						"FROM libroeditorial AS i JOIN editorial AS e ON e.idEditorial=i.idEditorial JOIN libro AS l ON i.ISBN=l.ISBN " +
						"JOIN autor AS a ON l.idAutor=a.idAutor WHERE l.ISBN="+result+";";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			string estado;
			
			if(lector.Read()){
				
				estado = lector.GetString(10);
				
				if(estado == "Activo"){
					tbNameBook.Text = lector.GetString(1);					
					tbISBN.Text = lector.GetString(0);
					tbCant.Text = lector.GetInt32(2).ToString();
					tbUbicacion.Text = lector.GetString(3);
					tbAuthor.Text =	lector.GetString(4);
					tbApellido.Text = lector.GetString(5);
					tbEditionBook.Text = lector.GetString(7);
					tbEditorial.Text = lector.GetString(6);
					tbNPages.Text =	lector.GetInt32(9).ToString();
					tbdAnio.Text= lector.GetInt32(8).ToString();
				   
				   
					
				} else{
					MessageBox.Show("Ese libro se encuentra desactivado","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
							
		    
			} else{
				MessageBox.Show("El ISBN que ingreso no existe", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			conexion.Close();
		}
		void PictureboxsalirClick(object sender, EventArgs e)
		{
			this.Hide();
			
			MainForm mainForm;
			mainForm = (MainForm)this.FindForm();
			mainForm.lbPanelC.Text = "Agregar libro";
		}
		void BtnLimiarClick(object sender, EventArgs e)
		{
			tbNameBook.Clear();
			tbdAnio.Clear();
			tbUbicacion.Clear();
			tbISBN.Clear();
			tbAuthor.Clear();
			tbApellido.Clear();
			tbEditorial.Clear();
			tbNPages.Clear();
			tbEditionBook.Clear();
			tbCant.Clear();
		}
		bool verificarTextBox(){
			bool flag = false;
			
			if(!String.IsNullOrEmpty(tbISBN.Text))
				if(!String.IsNullOrEmpty(tbNameBook.Text))
					if(!String.IsNullOrEmpty(tbNPages.Text))
						if(!String.IsNullOrEmpty(tbdAnio.Text))
							if(!String.IsNullOrEmpty(tbEditorial.Text))
								if(!String.IsNullOrEmpty(tbEditionBook.Text))
									if(!String.IsNullOrEmpty(tbCant.Text))
										if(!String.IsNullOrEmpty(tbAuthor.Text))
											if(!String.IsNullOrEmpty(tbApellido.Text))
												if(!String.IsNullOrEmpty(tbUbicacion.Text))
													flag = true;
			return flag;
		}
		void BtnAddBookClick(object sender, EventArgs e)
		{
			try{
				if(verificarTextBox()){
				
					InsertAutor();
					InsertLibro();
					InsertEditorial();
					InsertLibroEditorial();
					InsertEjemplar();
					MessageBox.Show("Libro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				} else{ 
					MessageBox.Show("Faltao llenar un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}			
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
		}
		void InsertAutor()
		{			
			sentencia = "INSERT INTO autor(nombre, app) VALUES ('"+tbAuthor.Text+"', '"+tbApellido.Text+"');";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		void InsertLibro()
		{
			int idA = 1;
			sentencia = "SELECT COUNT(*) FROM autor;";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector= cmd.ExecuteReader();
			if(lector.Read()){
				idA = lector.GetInt32(0);
			}
			conexion.Close();
			
			int isbn = Int32.Parse(tbISBN.Text);
			
			sentencia = "INSERT INTO libro (isbn, nombre, ubicacion, idAutor, estado) " +
						"VALUES ("+isbn+", '"+tbNameBook.Text+"', '"+tbUbicacion.Text+"', "+idA+", 'Activo');";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		void InsertEditorial()
		{
			sentencia = "INSERT INTO editorial(nombreEd) VALUES ('"+tbEditorial.Text+"');";
			
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		void InsertLibroEditorial()
		{
			int idE=1;
			sentencia = "SELECT COUNT(*) FROM editorial;";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector= cmd.ExecuteReader();
			if(lector.Read()){
				idE = lector.GetInt32(0);
			}
			conexion.Close();
			
			int result = Int32.Parse(tbISBN.Text);
			int anio = Int32.Parse(tbdAnio.Text);
			int paginas = Int32.Parse(tbNPages.Text);
			int cant = Int32.Parse(tbCant.Text);
			sentencia = "INSERT INTO libroeditorial(idEditorial, isbn, anio, edicion, paginas, cantidad) " +
						"VALUES ("+idE+", "+result+", "+anio+", '"+tbEditionBook.Text+"', "+paginas+", "+cant+");";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		void InsertEjemplar()
		{
			int cant = Int32.Parse(tbCant.Text);
			int i = 1;
			int result = Int32.Parse(tbISBN.Text);
			while(i<=cant){
				
				sentencia = "INSERT INTO ejemplar(estatus, isbn, numEjemplar) " +
							"VALUES ('Disponible', "+result+", "+i+");";
				Conexion();
				conexion.Open();
				cmd = new MySqlCommand(sentencia, conexion);
				cmd.ExecuteNonQuery();
				conexion.Close();
				i++;
			}
		}
		void BtActivarClick(object sender, EventArgs e)
		{
			sentencia = "SELECT *From libro WHERE isbn='"+tbSearchQuotation.Text+"';";
			
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			 lector = cmd.ExecuteReader();
			
			if(lector.Read()){				
				conexion.Close();
				 sentencia = "UPDATE libro SET estado= 'Activo' WHERE ISBN ='"+tbSearchQuotation.Text+"';";
				
				Conexion();
				conexion.Open();
				cmd = new MySqlCommand(sentencia, conexion);				
				
				cmd.ExecuteNonQuery();
				
				MessageBox.Show("Libro Activado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}else {
				MessageBox.Show("El ISBN no existe","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
			
			conexion.Close();
		}
		void BtnDeleteClick(object sender, EventArgs e)
		{
			sentencia = "SELECT *From libro WHERE isbn='"+tbSearchQuotation.Text+"';";
			
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			 lector = cmd.ExecuteReader();
			
			if(lector.Read()){				
				conexion.Close();
				 sentencia = "UPDATE libro SET estado= 'Desactivado' WHERE ISBN ='"+tbSearchQuotation.Text+"';";
				
				Conexion();
				conexion.Open();
				cmd = new MySqlCommand(sentencia, conexion);				
				
				cmd.ExecuteNonQuery();
				
				MessageBox.Show("Libro Desactivado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
			}else {
				MessageBox.Show("El ISBN no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
			
			conexion.Close();
		}

	}
}
