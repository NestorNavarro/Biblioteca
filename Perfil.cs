/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 23/05/2019
 * Hora: 11:03 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
	/// <summary>
	/// Description of Perfil.
	/// </summary>
	public partial class Perfil : UserControl
	{
		public string user;
		MySqlConnection conexion;
		string sentencia;
		string puesto;
		public Perfil()
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
		void PbCloseClick(object sender, EventArgs e)
		{
			this.Hide();
			
		}
		void PerfilLoad(object sender, EventArgs e)
		{
			
			
			try{
				sentencia = "SELECT a.idA, a.nombre, a.app, a.apm, u.tipo " +
							"FROM administrador AS a JOIN usuario AS u ON a.username=u.username " +
							"WHERE a.username='';";
				VerificarPuesto();
				if(puesto=="Administrador"){
					sentencia = SentenciaA();
				}
				if (puesto=="Operador"){
					sentencia = SentenciaO();
				}
				Conexion();
				
				MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
				conexion.Open();
				
				MySqlDataReader lector=cmd.ExecuteReader();
				
				if(lector.Read()){
					lbId.Text = lector.GetString(0);
					lbNombre.Text = lector.GetString(1);
					lbPaterno.Text = lector.GetString(2);
					lbMAterno.Text = lector.GetString(3);
					lbPuesto.Text = lector.GetString(4);
				}
				conexion.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message + ex.StackTrace);
			}
			
			
		}
		string SentenciaA(){
			string sentenciaA = "SELECT a.idA, a.nombre, a.app, a.apm, u.tipo " +
								"FROM administrador AS a JOIN usuario AS u ON a.username=u.username " +
								"WHERE a.username='"+user+"';";	
			return sentenciaA;
		}
		string SentenciaO(){
			string sentenciaO = "SELECT o.idO, o.nombre, o.app, o.apm, u.tipo " +
								"FROM operador AS o JOIN usuario AS u ON o.username=u.username " +
								"WHERE o.username='"+user+"';";
			return sentenciaO;
		}
		void VerificarPuesto()
		{
			sentencia = "SELECT tipo FROM usuario WHERE username='"+user+"';";
			Conexion();
				
			MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
			conexion.Open();
				
			MySqlDataReader lector=cmd.ExecuteReader();
				
			if(lector.Read()){
				puesto = lector.GetString(0);
			}
			conexion.Close();
		}
	}
}
