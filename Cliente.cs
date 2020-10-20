/*
 * Created by SharpDevelop.
 * User: sony_
 * Date: 24/05/2019
 * Time: 10:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public partial class Cliente : UserControl
	{
		MySqlConnection conexion;
		MySqlCommand cmd;
		MySqlDataReader lector;
		string sentencia;
		
		public Cliente()
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
		void PBoxSalirClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
					
			mForm.lbPanelC.Text = "Prestamo";
		}
		void BtnAddBookClick(object sender, EventArgs e)
		{
			try{
				if(verificarTextBox()){
					
					InsertUsuario();
					InsertCliente();
					MessageBox.Show("Libro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				}else{
					MessageBox.Show("Faltao llenar un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void InsertUsuario()
		{
			sentencia = "INSERT INTO usuario VALUES ('"+textBox2.Text+"', '"+textBox1.Text+"', 'Cliente');";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		void InsertCliente()
		{
			int numero = Int32.Parse(tbNPages.Text);
			int cod = Int32.Parse(tbEditionBook.Text);
			sentencia = "INSERT INTO cliente (nombre, app, apm, curp, calle, No, cp, email, estado, username) VALUES ('"+tbNameBook.Text+"', '"+tbISBN.Text+"', '"+tbAuthor.Text+"', '"+tbApellido.Text+"', '"+tbEditorial.Text+"', "+numero+", "+cod+", '"+c.Text+"', 'Activo', '"+textBox2.Text+"');";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			tbNameBook.Clear();
			tbISBN.Clear();
			tbAuthor.Clear();
			tbApellido.Clear();
			tbEditorial.Clear();
			tbNPages.Clear();
			tbEditionBook.Clear();
			c.Clear();
			textBox1.Clear();
			textBox2.Clear();
	
		}
		bool verificarTextBox()
		{
			bool flag = false;
			
			if(!String.IsNullOrEmpty(tbISBN.Text))
				if(!String.IsNullOrEmpty(tbNameBook.Text))
					if(!String.IsNullOrEmpty(tbNPages.Text))
							if(!String.IsNullOrEmpty(tbEditorial.Text))
								if(!String.IsNullOrEmpty(tbEditionBook.Text))
									if(!String.IsNullOrEmpty(c.Text))
										if(!String.IsNullOrEmpty(tbAuthor.Text))
											if(!String.IsNullOrEmpty(tbApellido.Text))
												if(!String.IsNullOrEmpty(textBox1.Text))
													if(!String.IsNullOrEmpty(textBox2.Text))													
																flag = true;
			return flag;
		}
	}
}
