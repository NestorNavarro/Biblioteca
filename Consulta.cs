/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 23/05/2019
 * Hora: 12:32 p. m.
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
	/// Description of Consulta.
	/// </summary>
	public partial class Consulta : UserControl
	{
		 MySqlConnection conexion;
		public Consulta()
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
		void BtnBuscarClick(object sender, EventArgs e)
		{
			try{
					string sentencia = "SELECT *FROM libro;";
					
					if(validarTextbox() == 1){
						sentencia = sentenciaISBN();
					}
							
					if(validarTextbox() == 2){
						sentencia = sentenciaNombre();
					}
						
					if(validarTextbox() == 3){
						sentencia = sentenciaAutor();
					}			
							
					
					Conexion();
					conexion.Open();
					MySqlCommand comando = new MySqlCommand(sentencia,conexion);
					MySqlDataReader myReader = comando.ExecuteReader();
			
					if(myReader.Read()){
						if(myReader.GetString(10) == "Activo"){
							
							conexion.Close();
						
							cargarDataView(sentencia, comando, myReader);
						} else{
							MessageBox.Show("Ese libro se encuentra desactivado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						
					} else{
						MessageBox.Show("No existe el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					
					conexion.Close();
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		string sentenciaISBN(){
			
				int result = Int32.Parse(txtISBN.Text);
		        string sentencia= "SELECT l.isbn,l.nombre,i.cantidad,l.ubicacion,a.nombre,a.app,e.nombreed,i.edicion,i.anio,i.paginas, l.estado " +
		        				  "FROM libroeditorial AS i JOIN editorial AS e ON e.idEditorial=i.idEditorial JOIN libro AS l ON i.ISBN=l.ISBN " +
		        				  "JOIN autor AS a ON l.idAutor=a.idAutor WHERE l.ISBN="+result+";";
			
				return sentencia;
		}
		string sentenciaNombre(){
			
				string sentencia="SELECT l.isbn,l.nombre,i.cantidad,l.ubicacion,a.nombre,a.app,e.nombreed,i.edicion,i.anio,i.paginas, l.estado " +
		        				  "FROM libroeditorial AS i JOIN editorial AS e ON e.idEditorial=i.idEditorial JOIN libro AS l ON i.ISBN=l.ISBN " +
		        				  "JOIN autor AS a ON l.idAutor=a.idAutor WHERE l.nombre='"+txtNombre.Text+"';";
			
				return sentencia;
			
		}
		string sentenciaAutor(){
			
				string sentencia="SELECT l.isbn,l.nombre,i.cantidad,l.ubicacion,a.nombre,a.app,e.nombreed,i.edicion,i.anio,i.paginas, l.estado " +
		        				  "FROM libroeditorial AS i JOIN editorial AS e ON e.idEditorial=i.idEditorial JOIN libro AS l ON i.ISBN=l.ISBN " +
		        				  "JOIN autor AS a ON l.idAutor=a.idAutor WHERE a.nombre='"+txtAutor.Text+"';";
			
			
				return sentencia;
			
			
		}
		
		int validarTextbox(){
			int bandera = 0;
			if(!String.IsNullOrEmpty(txtISBN.Text)){
				bandera =1;
			}
			if(!String.IsNullOrEmpty(txtNombre.Text)){
				bandera=2;
			}
			if(!String.IsNullOrEmpty(txtAutor.Text)){
			   	bandera=3;
			}
			return bandera;
			
		}
		
		void cargarDataView(string sentencia, MySqlCommand comando, MySqlDataReader Reader){
			try{
				dataviewlibro.Rows.Clear();
				conexion.Open();
				comando = new MySqlCommand(sentencia, conexion);
			    Reader = comando.ExecuteReader();
				
				while(Reader.Read()){
					int renglon = dataviewlibro.Rows.Add();
	
					dataviewlibro.Rows[renglon].Cells["isbn"].Value = 
						Reader.GetInt32(0).ToString();
	            
					dataviewlibro.Rows[renglon].Cells["titulo"].Value=
						Reader.GetString(1);
			  
	                dataviewlibro.Rows[renglon].Cells["nombreautor"].Value =
	                	Reader.GetString(4);
	                
	                dataviewlibro.Rows[renglon].Cells["apellidoautor"].Value =
	                	Reader.GetString(5);
	               
	                dataviewlibro.Rows[renglon].Cells["editorial"].Value =
	                	Reader.GetString(7);
	                
	                 dataviewlibro.Rows[renglon].Cells["edicion"].Value =
	                	Reader.GetString(6);
	                 
	                 dataviewlibro.Rows[renglon].Cells["anio"].Value =
	                	Reader.GetInt32(8).ToString();
	                
	                dataviewlibro.Rows[renglon].Cells["paginas"].Value = 
						Reader.GetInt32(9).ToString();
	                
	                dataviewlibro.Rows[renglon].Cells["cantidad"].Value =
	                	Reader.GetInt32(2).ToString();
	                
	                dataviewlibro.Rows[renglon].Cells["ubicacion"].Value =
	                	Reader.GetString(3);
	                
				}
				 conexion.Close();

			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtNombre.Text="";
			txtAutor.Text="";
			txtISBN.Text="";
			dataviewlibro.Rows.Clear();
		}
		void PictureboxsalirClick(object sender, EventArgs e)
		{
			this.Hide();
			
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
					
			mForm.lbPanelC.Text = "Prestamo";
		}
		void BtnOtrosClick(object sender, EventArgs e)
		{
			Revista rev = new Revista();
			this.Controls.Add(rev);
		    rev.BringToFront();
		}

	}
}
