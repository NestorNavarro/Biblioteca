/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 27/05/2019
 * Hora: 12:32 a. m.
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
	/// Description of Revista.
	/// </summary>
	public partial class Revista : UserControl
	{
		MySqlConnection conexion;
		MySqlCommand cmd;
		MySqlDataReader lector;
		string sentencia;
		public Revista()
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
		void PictureboxsalirClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		void BtnBuscarRevistaClick(object sender, EventArgs e)
		{
			try{
				int cod = Int32.Parse(txtNumero.Text);
				sentencia = "SELECT *FROM revista WHERE no="+cod+";";
				Conexion();
				conexion.Open();
				cmd = new MySqlCommand(sentencia, conexion);
				lector = cmd.ExecuteReader();
				if(lector.Read()){
					lbNoR.Text =lector.GetInt32(0).ToString();
					lbNombreR.Text = lector.GetString(1);
					lbCantidad.Text = lector.GetInt32(2).ToString();
				}else{
					MessageBox.Show("No existe el id de la revista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		void BtnBuscarPeriodicoClick(object sender, EventArgs e)
		{
			try{
				int cod = Int32.Parse(txtCodigo.Text);
				sentencia = "SELECT *FROM periodico WHERE codigoP="+cod+";";
				Conexion();
				conexion.Open();
				cmd = new MySqlCommand(sentencia, conexion);
				lector = cmd.ExecuteReader();
				if(lector.Read()){
					lbCodigoP.Text =lector.GetInt32(0).ToString();
					lbNombreP.Text = lector.GetString(1);
					lbSeccion.Text = lector.GetInt32(2).ToString();
					lCantidadP.Text = lector.GetString(3);
				}else{
					MessageBox.Show("No existe el id del periodico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				conexion.Close();
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			try{
				int cod = Int32.Parse(textBox1.Text);
				sentencia = "SELECT *FROM video WHERE codVideo="+cod+";";
				Conexion();
				conexion.Open();
				cmd = new MySqlCommand(sentencia, conexion);
				lector = cmd.ExecuteReader();
				if(lector.Read()){
					lbCodigoV.Text =lector.GetInt32(0).ToString();
					lbVideo.Text = lector.GetString(1);
				}else{
					MessageBox.Show("No existe el id del periodico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				conexion.Close();
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
