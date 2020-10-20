/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 20/05/2019
 * Hora: 10:07 p. m.
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
	/// Description of LoginControl1.
	/// </summary>
	public partial class LoginControl1 : UserControl
	{	
		 MySqlConnection conexion;
		string sentencia;
		public string tipo;
		
		public LoginControl1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnInicioClick(object sender, EventArgs e)
		{
						
			try{
				sentencia = "SELECT *FROM usuario WHERE username='"+tbUser.Text+"' AND password='"+tbPassword.Text+"';";
				
				conexion = new MySqlConnection();
				conexion.ConnectionString = "server = localhost;password=;database = biblioteca; User Id=root";
				
				MySqlCommand comando = new MySqlCommand(sentencia, conexion);
					conexion.Open();
					
					MySqlDataReader lector; 
					lector = comando.ExecuteReader();
					
					if(lector.Read()){
						 tipo = lector.GetString(2);
						if(tipo == "Operador" || tipo == "Administrador"){
							
							//Llamamos el menu 
							
							btnPrestamo prestamo = new btnPrestamo();
							prestamo.usuario = tbUser.Text;
							this.Controls.Add(prestamo);
		           			prestamo.BringToFront();
		           			
		           			//Actualizo el label del panel 
		           			MainForm mForm;
							mForm = (MainForm)this.FindForm();
					
							mForm.lbPanelC.Text = "Prestamo";
						
					}
				if(tipo == "Cliente"){
					//Llamamos al menu cliente
					Consulta consulta = new Consulta();
					this.Controls.Add(consulta);
					consulta.BringToFront();
					
					MainForm mForm;
					mForm = (MainForm)this.FindForm();
					
					mForm.lbPanelC.Text = "Consultas";
				}
				
				} else {
					MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			
				conexion.Close();
				
			}
			catch(Exception ex){
				
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void TbUserEnter(object sender, EventArgs e)
		{
			if(tbUser.Text == "Username"){
				tbUser.Text = "";
				tbUser.ForeColor = Color.FromArgb(197, 190, 186);
			}
			
		}
		void TbUserLeave(object sender, EventArgs e)
		{
			if(tbUser.Text == ""){
				tbUser.Text = "Username";
				tbUser.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void TbPasswordEnter(object sender, EventArgs e)
		{
			if(tbPassword.Text == "Password"){
				tbPassword.Text = "";
				tbPassword.ForeColor = Color.FromArgb(197, 190, 186);
			}
		}
		void TbPasswordLeave(object sender, EventArgs e)
		{
			if(tbPassword.Text == ""){
				tbPassword.Text = "Password";
				tbPassword.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void LoginControl1Load(object sender, EventArgs e)
		{
	
		}


	}
}
