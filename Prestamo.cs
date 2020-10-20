/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 22/05/2019
 * Hora: 11:22 p. m.
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
	/// Description of Prestamo.
	/// </summary>
	public partial class btnPrestamo : UserControl
	{
		MySqlConnection conexion;
		MySqlCommand cmd;
		MySqlDataReader lector;
		string sentencia;
		public string usuario;
		string sentenciaO;
		string sentenciaA;
		bool idA = false;
		bool idO = false;
		string auxisbn = "";
		bool pretamo1 = false;
		bool uA = false;
		bool uO = false;
		long iduA;
		int iduO;
		
		public btnPrestamo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
			
		
		void Timer1Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
		}
		
		//> TODO: Inicializo conexion a la base de datos.
		void Conexion()
		{
			conexion = new MySqlConnection();
			conexion.ConnectionString = "server = localhost;password=;database = biblioteca; User Id=root";
		}
		//>Mostramos el perfil del usuario.
		void BtnPerfilClick(object sender, EventArgs e)
		{
			Perfil perfil = new Perfil();
			perfil.user = usuario;
			this.Controls.Add(perfil);
			perfil.BringToFront();
		}
		//>Regresamos al Login
		void PictureboxsalirClick(object sender, EventArgs e)
		{
			LoginControl1 login = new LoginControl1();
			this.Controls.Add(login);
			login.BringToFront();
		}
		//>Abrimos la userControl agregar(libro)
		void BtnAddClick(object sender, EventArgs e)
		{
			string tipo = "";
			sentencia = "SELECT tipo FROM usuario WHERE username='"+lbUsuario.Text+"';";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			if(lector.Read()){
				tipo = lector.GetString(0);
			}
			
			if(tipo == "Administrador"){
				Agregar agregar = new Agregar();
				this.Controls.Add(agregar);
				agregar.BringToFront();
			
				MainForm mainForm;
				mainForm = (MainForm)this.FindForm();
				mainForm.lbPanelC.Text = "Agregar libro";
			} else {
				MessageBox.Show("No eres admin", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			
		}
		
		//>Método principal de la userControl(Prestamo)
		void BtnPrestamoLoad(object sender, EventArgs e)
		{
			
			lbUsuario.Text = usuario;
			
			//>Inicializo el lbtime para tener la hora actua
			timer1.Enabled = true;
			timer1.Start();
			lbTime.Text = DateTime.Now.ToString("dd-MM-yyyy h:mm tt");
			//<
			
		}
		
		//>Consulta Libro por ISBN
		void BtnISBNClick(object sender, EventArgs e)
		{
			
			
			try{				
				
				if(txtISBN.Text != "ISBN" && txtIdEj.Text != "ID Ejemplar"){
					
					int result = Int32.Parse(txtISBN.Text);
					int result1 = Int32.Parse(txtIdEj.Text);
					sentencia = "SELECT l.estado, l.nombre, a.nombre, a.app, e.nombreEd, le.edicion, le.paginas, ej.estatus, ej.numEjemplar, l.isbn, ej.idE " +
								"FROM libro AS l JOIN autor AS a ON l.idAutor=a.idAutor JOIN ejemplar AS ej ON ej.isbn=l.isbn JOIN libroeditorial " +
								"AS le ON l.isbn=le.isbn JOIN editorial AS e ON le.idEditorial=e.idEditorial WHERE l.isbn = "+result+" AND ej.numEjemplar = "+result1+";";			
					Conexion();
					
					conexion.Open();
					cmd = new MySqlCommand(sentencia, conexion);
					lector = cmd.ExecuteReader(); 
					
					if(lector.Read()){
						if(lector.GetString(0) == "Activo"){
							
							conexion.Close();
							CargarDataViewLibro();
						} 
						else{
							MessageBox.Show("El libro se encuentra desactivado", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					} 
					else {
						MessageBox.Show("No existe el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else{
					MessageBox.Show("Asegurese de llenar el campo Ejemplar y ISBN del libro", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				conexion.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			
			
		}//<
		
		//>>>>>CARGAMOS NUESTRA DATAGRID LIBRO
		void CargarDataViewLibro()
		{
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			
			
			while(lector.Read()){
				int renglon = dataviewlibro.Rows.Add();

				
				dataviewlibro.Rows[renglon].Cells["nombre"].Value =
					lector.GetString(1);
				
				dataviewlibro.Rows[renglon].Cells["autor"].Value =
					lector.GetString(2);
				
				dataviewlibro.Rows[renglon].Cells["apellido"].Value =
					lector.GetString(3);
				
				dataviewlibro.Rows[renglon].Cells["editorial"].Value =
					lector.GetString(4);
				
				
				dataviewlibro.Rows[renglon].Cells["edicion"].Value =
					lector.GetString(5);
				
				dataviewlibro.Rows[renglon].Cells["paginas"].Value =
					lector.GetInt32(6).ToString();
				
				dataviewlibro.Rows[renglon].Cells["estatus"].Value =
					lector.GetString(7);
				
				dataviewlibro.Rows[renglon].Cells["ejemplar"].Value =
					lector.GetInt32(8).ToString();
			}
			
			conexion.Close();	
		}
		//<<<<<
		
		//>>Consulta cliente
		void BtnClienteClick(object sender, EventArgs e)
		{
			try{
				bool flag = false;
				if(txtCliente.Text != "Cliente"){
					
					
					sentencia = VerificarSentencia();
					
					Conexion();
					
					conexion.Open();
					cmd = new MySqlCommand(sentencia, conexion);
					lector = cmd.ExecuteReader(); 
					
					if(lector.Read()){ //con multa
						if(lector.GetString(0) == "Activo"){							
							conexion.Close();
							CargarDataViewCliente();
														
						}
						else{
							MessageBox.Show("El cliente se encuentra desactivado", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}					
					else{
						if(VerificaCliente() == true){
							if(VerificarMultaidO() == false || VerificarMultaidA() == false){
								sentencia = InicializoSentencia();
						
								Conexion();
								
								conexion.Open();
								cmd = new MySqlCommand(sentencia, conexion);
								lector = cmd.ExecuteReader(); 
								
								if(lector.Read()){
									
									conexion.Close();
									CargarDataViewCliente();
									
								}else{
									conexion.Close();
									sentencia = "SELECT *FROM usuario WHERE username='"+txtCliente.Text+"';";
									Conexion();
									
									conexion.Open();
									cmd = new MySqlCommand(sentencia, conexion);
									lector = cmd.ExecuteReader(); 
										
									if(lector.Read()){
										conexion.Close();
										pretamo1 = true;
										MessageBox.Show("El usuario no tiene un prestamo activo, por lo tanto puede realizar prestamo.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
									else{
										MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}							
							}
						}						
						else{
							MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
						}
																
					}//
					
				}
				else{
					MessageBox.Show("Asegurese de llenar el campo Clinete", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				conexion.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		bool VerificaCliente()
		{
			bool flag = false;
			string s = "SELECT  *FROM usuario WHERE username='"+txtCliente.Text+"';";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(s, conexion);
			lector = cmd.ExecuteReader(); 
			if(lector.Read()){
				flag = true;
			}
			return flag;
		}
		string InicializoSentencia()
		{
				
				//Sentencia idA
				 sentenciaA = 	"SELECT c.estado, u.username, c.nombre, c.app, l.isbn, ej.numEjemplar, p.fecha, p.fechalimite, d.fechaEntrega, a.idA " +
				 				"FROM cliente AS c JOIN usuario AS u ON u.username=c.username JOIN prestamo AS p ON c.idC=p.idC JOIN administrador AS a ON a.idA=p.idA " +
				 				"JOIN ejemplar_contiene_prestamo AS ecp ON ecp.idP=p.idP JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP " +
				 				"WHERE c.username='"+txtCliente.Text+"'; ";
				Conexion();					
				conexion.Open();
				cmd = new MySqlCommand(sentenciaA, conexion);
				lector = cmd.ExecuteReader(); 
					
				if(lector.Read()){
					//conexion.Close();
					//idA = true;
					return sentenciaA;
				}else{
					 sentenciaO = "SELECT c.estado, u.username, c.nombre, c.app, l.isbn, ej.numEjemplar, p.fecha, p.fechalimite, d.fechaEntrega, o.idO " +
					 				"FROM cliente AS c JOIN usuario AS u ON u.username=c.username JOIN prestamo AS p ON c.idC=p.idC JOIN operador AS o ON o.idO=p.idP " +
					 				"JOIN ejemplar_contiene_prestamo AS ecp ON ecp.idP=p.idP JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP " +
					 				"WHERE c.username='"+txtCliente.Text+"';  ";
					//idO = true;
					//conexion.Close();
					return sentenciaO;
				}
		}
		string VerificarSentencia()
		{
				//con multa
				//Sentencia idA
				 sentenciaA = "SELECT c.estado, u.username, c.nombre, c.app, l.isbn, ej.numEjemplar, p.fecha, p.fechalimite, d.fechaEntrega, m.folio, m.estatus, m.importe, a.idA " +
							"FROM cliente AS c JOIN usuario AS u ON u.username=c.username JOIN prestamo AS p ON c.idC=p.idC JOIN administrador AS a ON a.idA=p.idA JOIN ejemplar_contiene_prestamo AS " +
							"ecp ON ecp.idP=p.idP JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP " +
							"JOIN multa AS m ON m.idD=d.idD WHERE c.username='"+txtCliente.Text+"'; ";
				Conexion();					
				conexion.Open();
				cmd = new MySqlCommand(sentenciaA, conexion);
				lector = cmd.ExecuteReader(); 
					
				if(lector.Read()){
					//conexion.Close();
					//idA = true;
					return sentenciaA;
				}else{
					 sentenciaO = "SELECT c.estado, u.username, c.nombre, c.app, l.isbn, ej.numEjemplar, p.fecha, p.fechalimite, d.fechaEntrega, m.folio, m.estatus, m.importe, o.idO " +
								"FROM cliente AS c JOIN usuario AS u ON u.username=c.username JOIN prestamo AS p ON c.idC=p.idC JOIN operador AS o ON o.idO=p.idP JOIN ejemplar_contiene_prestamo AS ecp " +
								"ON ecp.idP=p.idP JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP " +
						        "JOIN multa AS m ON m.idD=d.idD WHERE c.username='"+txtCliente.Text+"'; ";
					//idO = true;
					//conexion.Close();
					return sentenciaO;
				}												
		}
		bool VerificarMultaidA()
		{
			bool flag = false;
			//idA
			 sentenciaA = "SELECT c.estado, u.username, c.nombre, c.app, l.isbn, ej.numEjemplar, p.fecha, p.fechalimite, d.fechaEntrega, m.folio, m.estatus, m.importe, a.idA " +
						  "FROM cliente AS c JOIN usuario AS u ON u.username=c.username JOIN prestamo AS p ON c.idC=p.idC JOIN administrador AS a ON a.idA=p.idA JOIN ejemplar_contiene_prestamo " +
						  "AS ecp ON ecp.idP=p.idP JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP " +
						  "JOIN multa AS m ON m.idD=d.idD WHERE c.username='"+txtCliente.Text+"';  ";
			Conexion();
					
			conexion.Open();
			cmd = new MySqlCommand(sentenciaA, conexion);
			lector = cmd.ExecuteReader(); 
			if(lector.Read()){
				flag = true;
			}
			//conexion.Close();
			return flag;
		}
		bool VerificarMultaidO()
		{
			bool flag = false;
			 sentenciaO = "SELECT c.estado, u.username, c.nombre, c.app, l.isbn, ej.numEjemplar, p.fecha, p.fechalimite, d.fechaEntrega, m.folio, m.estatus, m.importe, o.idO " +
						"FROM cliente AS c JOIN usuario AS u ON u.username=c.username JOIN prestamo AS p ON c.idC=p.idC JOIN operador AS o ON o.idO=p.idO JOIN ejemplar_contiene_prestamo " +
						"AS ecp ON ecp.idP=p.idP JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP " +
						"JOIN multa AS m ON m.idD=d.idD WHERE c.username='"+txtCliente.Text+"';  ";
			Conexion();
					
			conexion.Open();
			cmd = new MySqlCommand(sentenciaO, conexion);
			lector = cmd.ExecuteReader(); 
			if(lector.Read()){
				
				flag = true;
			}
			//conexion.Close();
			return flag;			
		}	
		//<<
		void CargarDataViewCliente()
		{
			bool flag = true;
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			
			
			while(lector.Read()){
				int renglon = dataviewcliente.Rows.Add();

				
				dataviewcliente.Rows[renglon].Cells["nombreCliente"].Value =
					lector.GetString(2);
				
				dataviewcliente.Rows[renglon].Cells["apellidoCliente"].Value =
					lector.GetString(3);
				
				dataviewcliente.Rows[renglon].Cells["isbn"].Value =
					lector.GetInt32(4).ToString();
					auxisbn = lector.GetInt32(4).ToString();
				
				dataviewcliente.Rows[renglon].Cells["numEjemplar"].Value =
					lector.GetInt32(5).ToString();
							
				dataviewcliente.Rows[renglon].Cells["fecha"].Value =
					lector.GetString(6);
				
				dataviewcliente.Rows[renglon].Cells["fechalimite"].Value =
					lector.GetString(7);
				
				dataviewcliente.Rows[renglon].Cells["fechaEntrega"].Value =
					lector.GetString(8);
				
				if(VerificarMultaidO() == flag || VerificarMultaidA() == flag){
					
					dataviewcliente.Rows[renglon].Cells["folio"].Value =
						lector.GetInt32(9).ToString();
					
					dataviewcliente.Rows[renglon].Cells["estatusMulta"].Value =
						lector.GetString(10);
				
					dataviewcliente.Rows[renglon].Cells["importe"].Value =
						lector.GetInt32(11).ToString();
					/*if(idO == true){
						dataviewcliente.Rows[renglon].Cells["idOperador"].Value =
							lector.GetInt32(12).ToString();
					}else{
						dataviewcliente.Rows[renglon].Cells["idAdmin"].Value =
							lector.GetInt32(12).ToString();
					}*/					
					
				}
				else{
					dataviewcliente.Rows[renglon].Cells["folio"].Value = "****";
											
					dataviewcliente.Rows[renglon].Cells["estatusMulta"].Value = "No tiene Multa";
										
					dataviewcliente.Rows[renglon].Cells["importe"].Value = "0";
					
					/*if(idO == true ){
						MessageBox.Show("Entro");
						dataviewcliente.Rows[renglon].Cells["idOperador"].Value =
						lector.GetInt32(9).ToString();
					
						dataviewcliente.Rows[renglon].Cells["idAdmin"].Value = "**";
					}
					if(idA == true){
						dataviewcliente.Rows[renglon].Cells["idAdmin"].Value =
							lector.GetInt32(9).ToString();
					
						dataviewcliente.Rows[renglon].Cells["idOperador"].Value = "**";
					}*/
				}				

			}
			
			conexion.Close();	
		}
		//<<
		
		//>>Prestamo
		void BtPrestamoClick(object sender, EventArgs e)
		{
			try{
				string estatus = obterenEstadoEjemplar();
				
				if(txtISBN.Text != "ISBN" && txtIdEj.Text != "ID Ejemplar" && txtCliente.Text != "Cliente"){
					
					int result = Int32.Parse(txtISBN.Text);
					int result1 = Int32.Parse(txtIdEj.Text);
					sentencia = "SELECT p.idP, p.fecha, p.fechalimite, c.username, c.estado, ej.isbn, ej.numEjemplar, ej.estatus, l.estado, m.estatus " +
								"FROM prestamo AS p JOIN cliente AS c ON p.idC=c.idC JOIN ejemplar_contiene_prestamo AS ecp ON ecp.idP=p.idP JOIN ejemplar AS ej " +
								"ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn JOIN devolucion AS d ON d.idP=p.idP JOIN multa AS m ON m.idD=d.idD " +
								"WHERE c.username='"+txtCliente.Text+"' AND l.isbn="+result+";";
					Conexion();
									
					conexion.Open();
					cmd = new MySqlCommand(sentencia, conexion);
					lector = cmd.ExecuteReader();
					
	
					if(lector.Read()){
						if(lector.GetString(4)=="Activo"){
							if(lector.GetString(7)=="Disponible"){
								if(lector.GetString(8)=="Activo"){
									if(lector.GetString(9)=="N"){
										if(auxisbn != txtISBN.Text && auxisbn != ""){
											getFechas();
											Insertarprestamo();
											InsertarPrestamEjemplar();
											Insertardevolucion();
																						
										}else{
											MessageBox.Show("Para realizar esta operacion debe de buscar al cliente primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
										}
									}else{
										MessageBox.Show("Tiene una multa activa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}								
								}else{
									MessageBox.Show("El libro no está activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}else{
								MessageBox.Show("Este ejemplar está prestado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}else{
							MessageBox.Show("El cliente no está activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else{
						
						sentencia = "SELECT p.idP, p.fecha, p.fechalimite, c.username, c.estado, ej.isbn, ej.numEjemplar, ej.estatus, l.estado " +
									"FROM prestamo AS p JOIN cliente AS c ON p.idC=c.idC JOIN ejemplar_contiene_prestamo AS ecp ON ecp.idP=p.idP " +
									"JOIN ejemplar AS ej ON ecp.idE=ej.idE JOIN libro AS l ON l.isbn=ej.isbn " +
									"WHERE c.username='"+txtCliente.Text+"' AND l.isbn="+result+";";
						Conexion();
									
						conexion.Open();
						cmd = new MySqlCommand(sentencia, conexion);
						lector = cmd.ExecuteReader();
						
						if(lector.Read()){
							if(lector.GetString(4)=="Activo"){
								if(lector.GetString(7)=="Disponible"){
									if(lector.GetString(8)=="Activo"){
										if(auxisbn != txtISBN.Text && auxisbn != ""){
											
											getFechas();
											Insertarprestamo();
											InsertarPrestamEjemplar();
											Insertardevolucion();
											
										}else{
											MessageBox.Show("Para realizar esta operacion debe de buscar al cliente primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
										}
									}else{
										MessageBox.Show("El libro no está activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}else{
									MessageBox.Show("Este ejemplar está prestado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}else{
								MessageBox.Show("El cliente no está activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}else{
							
							if(pretamo1==true){
								if(estatus == "Disponible"){
									getFechas();
									Insertarprestamo();
									InsertarPrestamEjemplar();
									Insertardevolucion();
								}else{
									MessageBox.Show("Ese ejemplar se encuentra "+estatus+"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								}
								
							}else{
								MessageBox.Show("Verifique los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
											
					}
					
					}else{
						MessageBox.Show("Asegurese de llenar los campo ID Ejemplar, ISBN y Cliente", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
				}					
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		string obterenEstadoEjemplar()
		{
			string estado="";
			try{
				
				int result = Int32.Parse(txtISBN.Text);
				int result1 = Int32.Parse(txtIdEj.Text);
				sentencia = "SELECT estatus FROM ejemplar WHERE isbn="+result+" AND numEjemplar="+result1+";";
				Conexion();
				conexion.Open();
			
				cmd = new MySqlCommand(sentencia, conexion);
				lector = cmd.ExecuteReader();
			if(lector.Read()){
				estado = lector.GetString(0);
				return estado;
			}
			conexion.Close();
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return estado;
		}
		void Insertarprestamo()
		{
			VerificarEmpleado();
			int idC = getIdcliente();

			if(uO == true){
				sentencia = "INSERT INTO prestamo (fecha, idC, idO, fechalimite) VALUES ('"+lbfPrestamo.Text+"', "+idC+", 1, '"+lblimite.Text+"');";
			}
			else if (uA == true){
				sentencia = "INSERT INTO prestamo (fecha, idC, idA, fechalimite) VALUES ('"+lbfPrestamo.Text+"', "+idC+", 1, '"+lblimite.Text+"');";
			}
			
			Conexion();
			conexion.Open();
			
			cmd = new MySqlCommand(sentencia, conexion);
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		int getIdcliente()
		{
			int idC = 0;
			sentencia = "SELECT c.idC FROM cliente AS c JOIN usuario AS u ON c.username=u.username " +
						"WHERE c.username='"+txtCliente.Text+"';";
			Conexion();
			conexion.Open();
			
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			if(lector.Read()){
				
				idC = lector.GetInt32(0);
			}
			conexion.Close();
			return idC;
		}
		void VerificarEmpleado()
		{
			sentencia = "SELECT idO FROM operador WHERE username='"+lbUsuario.Text+"';";
			
			Conexion();
			conexion.Open();
			
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			
			if(lector.Read()){
				conexion.Close();
				uO = true;
				//iduO = lector.GetInt32(0);
			}else{
				sentencia = "SELECT idA FROM administrador WHERE username='"+lbUsuario.Text+"';";
				Conexion();
				conexion.Open();
			
				cmd = new MySqlCommand(sentencia, conexion);
				lector = cmd.ExecuteReader();
				if(lector.Read()){
					conexion.Close();
					uA = true;
					//MessageBox.Show(""+lector.GetInt16(0)+"");
					//iduA = lector.GetInt32(0);
					//MessageBox.Show(""+iduA+"");
				}
				
			}
		}
		void InsertarPrestamEjemplar()
		{
			long idP=0;
			sentencia = "SELECT idP FROM prestamo WHERE idP=LAST_INSERT_ID();";
			
			Conexion();
			conexion.Open();
			
			 cmd = new MySqlCommand(sentencia, conexion);
			 lector = cmd.ExecuteReader();
			 if(lector.Read()){
			 	idP=lector.GetInt64(0);
			 }
			 conexion.Close();
			 
			 int result1 = Int32.Parse(txtIdEj.Text);
			 sentencia = "INSERT INTO ejemplar_contiene_prestamo(idE, IdP) VALUES ("+result1+","+idP+");";
			 Conexion();
			 conexion.Open();
			 cmd = new MySqlCommand(sentencia, conexion);
			 cmd.ExecuteNonQuery();			 
			 conexion.Close();
			 
			 sentencia = "UPDATE ejemplar SET estatus = 'No disponible' WHERE idE ="+result1+";";
			 Conexion();
			 conexion.Open();
			 cmd = new MySqlCommand(sentencia, conexion);
			 cmd.ExecuteNonQuery();			 
			 conexion.Close();
		}
		void Insertardevolucion()
		{
			int idP=0;
			sentencia = "SELECT idP FROM prestamo WHERE idP=LAST_INSERT_ID(idP);";
			
			Conexion();
			conexion.Open();
			
			 cmd = new MySqlCommand(sentencia, conexion);
			 lector = cmd.ExecuteReader();
			 if(lector.Read()){
			 	idP=lector.GetInt32(0);
			 }
			 conexion.Close();
			 
			 sentencia = "INSERT INTO devolucion(fechaEntrega, idP) VALUES('--/--/----', "+idP+");";
			 Conexion();
			 conexion.Open();
			 cmd = new MySqlCommand(sentencia, conexion);
			 cmd.ExecuteNonQuery();			 
			 conexion.Close();			 
			 
		}
		//<<
		
		//>>Devolucion 
		void BtnDevolverClick(object sender, EventArgs e)
		{
			try{
				
				if(txtISBN.Text != "ISBN" && txtIdEj.Text != "ID Ejemplar" && txtCliente.Text != "Cliente"){
					//if(auxisbn != txtISBN.Text && auxisbn != ""){
						
						sentencia = "SELECT d.idD, p.idP, c.idC FROM prestamo AS p JOIN ejemplar_contiene_prestamo AS ecp ON ecp.idP=p.idP JOIN ejemplar as ej " +
									"ON ej.idE=ecp.idE JOIN devolucion AS d ON d.idP=p.idP JOIN cliente as c ON  c.idC=p.idC WHERE c.username='"+txtCliente.Text+"'; ";
						Conexion();
						conexion.Open();
						cmd = new MySqlCommand(sentencia, conexion);
						lector = cmd.ExecuteReader();
						int idP;
						
						if(lector.Read()){
							int idD;
							idP = lector.GetInt32(1);
							idD = lector.GetInt32(0);
							conexion.Close();
							
							int result = Int32.Parse(txtISBN.Text);
							int result1 = Int32.Parse(txtIdEj.Text);
							sentencia = "SELECT ej.estatus, ej.isbn FROM ejemplar AS ej JOIN ejemplar_contiene_prestamo AS ecp " +
										"ON ecp.idE=ej.idE JOIN prestamo AS p ON ecp.idP=p.idP " +
										"WHERE isbn="+result+" AND numEjemplar="+result1+" AND p.idP="+idP+";";
							
							Conexion();
							conexion.Open();
							cmd = new MySqlCommand(sentencia, conexion);
							lector = cmd.ExecuteReader();
							
							if(lector.Read()){
								
								string fechaEntrega1;
								DateTime fechaPrestamo;
								DateTime fechaLimite;
								DateTime fechaEntrega;
								
								fechaPrestamo = DateTime.Now;
										
								fechaLimite = fechaPrestamo.AddDays(5);
								
								lbfPrestamo.Text = fechaPrestamo.ToString("dd-MM-yyyy");
								lblimite.Text = fechaLimite.ToString("dd-MM-yyyy");
								
								fechaEntrega = DateTime.Parse(""+txtEntrega.Text+"");
								fechaEntrega.ToString("dd-MM-yyyy");
								
								fechaEntrega1 = fechaLimite.Subtract(fechaEntrega).Days.ToString();
								
								 int resultado = Int32.Parse(fechaEntrega1);
								 MessageBox.Show(""+resultado+"");
								 if(resultado >= 0){
								 	
								 	sentencia = "UPDATE devolucion SET fechaEntrega = '"+txtEntrega.Text+"' WHERE idP="+idP+" AND fechaEntrega = '--/--/----';";
								 	Conexion();
									conexion.Open();
									cmd = new MySqlCommand(sentencia, conexion);
									//cmd.ExecuteNonQuery();
									bool proc = Convert.ToBoolean(cmd.ExecuteNonQuery());
									
									if(proc){
									
										conexion.Close();
										sentencia= "UPDATE ejemplar SET estatus = 'Disponible' WHERE numEjemplar = "+result1+" AND isbn="+result+";";
										Conexion();
										conexion.Open();
										cmd = new MySqlCommand(sentencia, conexion);
										cmd.ExecuteNonQuery();
										conexion.Close();
										
									} else{
										MessageBox.Show("Verifique los datos de devolucion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								 } else {
								 	
								 	MessageBox.Show("Se le genero una multa", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								 	sentencia = "UPDATE devolucion SET fechaEntrega = '"+txtEntrega.Text+"' WHERE idP="+idP+";";
								 	Conexion();
									conexion.Open();
									cmd = new MySqlCommand(sentencia, conexion);
									
									cmd.ExecuteNonQuery();
									
										
									conexion.Close();
									sentencia= "UPDATE ejemplar SET estatus = 'Disponible' WHERE numEjemplar = "+result1+" AND isbn="+result+";";
									Conexion();
									conexion.Open();
									cmd = new MySqlCommand(sentencia, conexion);
									cmd.ExecuteNonQuery();
									conexion.Close();
										
									int imp = resultado*-5;
									sentencia= "INSERT INTO multa(importe, estatus, idD) VALUES("+imp+", 'A', "+idD+");";
									Conexion();
									conexion.Open();
									cmd = new MySqlCommand(sentencia, conexion);
									cmd.ExecuteNonQuery();
									conexion.Close();
																																			
								 }
								
							}else{
								MessageBox.Show("El ISBN o Ejemplar es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}							
							
						} else{
							MessageBox.Show("El usuario es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}				
						
					//}else{
						//MessageBox.Show("Para realizar esta operacion debe de buscar al cliente primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//}
					
				} else {
					MessageBox.Show("Asegurese de llenar los campo ID Ejemplar, ISBN y Cliente", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
				}				
				 
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//<<
		//>>
		void BtnLiquidarClick(object sender, EventArgs e)
		{
			try{
				if(txtFolio.Text != "Folio"){
					int result = Int32.Parse(txtFolio.Text);
					sentencia = "SELECT estatus FROM multa WHERE folio="+result+";";	
					Conexion();
					conexion.Open();
					cmd = new MySqlCommand(sentencia, conexion);
					lector = cmd.ExecuteReader();
					
					if(lector.Read()){
						sentencia = "UPDATE multa SET estatus = 'N' WHERE Folio ="+result+";";	
						Conexion();
						conexion.Open();
						cmd = new MySqlCommand(sentencia, conexion);
						lector = cmd.ExecuteReader();
						conexion.Close();
						
						sentencia = "UPDATE multa SET importe = 0 WHERE Folio ="+result+";";	
						Conexion();
						conexion.Open();
						cmd = new MySqlCommand(sentencia, conexion);
						lector = cmd.ExecuteReader();
						conexion.Close();
						
						MessageBox.Show("Se realizo el pago con exito", "Nota",  MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}else{
						MessageBox.Show("El folio no existe ISBN y Cliente", "Nota",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}else{
					MessageBox.Show("Asegurese de llenar los campo ID Ejemplar, ISBN y Cliente", "Alto",  MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//<<
		//>>Inicializo la fecha del prestamo y la fecha limite
		void getFechas(){
			
			DateTime fechaPrestamo;
			DateTime fechaLimite;
				
			fechaPrestamo = DateTime.Now;
			fechaLimite = fechaPrestamo.AddDays(5);
					
			lbfPrestamo.Text = fechaPrestamo.ToString("dd-MM-yyyy");
			lblimite.Text = fechaLimite.ToString("dd-MM-yyyy");
		}
		//<<
		//>Limpio e inserto texto de todas las textBox
		void TxtIdEjEnter(object sender, EventArgs e)
		{
			if(txtIdEj.Text == "ID Ejemplar"){
				txtIdEj.Text = "";
				txtIdEj.ForeColor = Color.FromArgb(197, 190, 186);
			}
		}
		void TxtIdEjLeave(object sender, EventArgs e)
		{
			if(txtIdEj.Text == ""){
				txtIdEj.Text = "ID Ejemplar";
				txtIdEj.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void TxtISBNEnter(object sender, EventArgs e)
		{
			if(txtISBN.Text == "ISBN"){
				txtISBN.Text = "";
				txtISBN.ForeColor = Color.FromArgb(197, 190, 186);
			}
		}
		void TxtISBNLeave(object sender, EventArgs e)
		{
			if(txtISBN.Text == ""){
				txtISBN.Text = "ISBN";
				txtISBN.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void TxtClienteEnter(object sender, EventArgs e)
		{
			if(txtCliente.Text == "Cliente"){
				txtCliente.Text = "";
				txtCliente.ForeColor = Color.FromArgb(197, 190, 186);
			}
		}
		void TxtClienteLeave(object sender, EventArgs e)
		{
			if(txtCliente.Text == ""){
				txtCliente.Text = "Cliente";
				txtCliente.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void TextBox4Enter(object sender, EventArgs e)
		{
			if(txtFolio.Text == "Folio"){
				txtFolio.Text = "";
				txtFolio.ForeColor = Color.FromArgb(197, 190, 186);
			}
		}
		void TextBox4Leave(object sender, EventArgs e)
		{
			if(txtFolio.Text == ""){
				txtFolio.Text = "Folio";
				txtFolio.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void TxtEntregaEnter(object sender, EventArgs e)
		{
			if(txtEntrega.Text == "dd-mm-yyyy"){
				txtEntrega.Text = "";
				txtEntrega.ForeColor = Color.FromArgb(197, 190, 186);
			}
		}
		void TxtEntregaLeave(object sender, EventArgs e)
		{
			if(txtEntrega.Text == ""){
				txtEntrega.Text = "dd-mm-yyyy";
				txtEntrega.ForeColor = Color.FromArgb(129, 131, 127);
			}
		}
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			txtCliente.Text = "Cliente";
			txtIdEj.Text = "ID Ejemplar";
			txtFolio.Text = "Folio";
			txtISBN.Text = "ISBN";
			lblimite.Text = "Fecha Limite";
			lbfPrestamo.Text = "Fecha Prestamo";
			txtEntrega.Text = "dd-mm-yyyy";
			dataviewlibro.Rows.Clear();
			dataviewcliente.Rows.Clear();
			
		}
		void BtnconsultaClick(object sender, EventArgs e)
		{
			Consulta consulta = new Consulta();
			this.Controls.Add(consulta);
		    consulta.BringToFront();
		    
		    MainForm mainForm;
			mainForm = (MainForm)this.FindForm();
			mainForm.lbPanelC.Text = "Consultas";
		}
		void BtnaddcliClick(object sender, EventArgs e)
		{
			
			string tipo = "";
			sentencia = "SELECT tipo FROM usuario WHERE username='"+lbUsuario.Text+"';";
			Conexion();
			conexion.Open();
			cmd = new MySqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			if(lector.Read()){
				tipo = lector.GetString(0);
			}
			
			if(tipo == "Administrador"){
				Cliente cliente = new Cliente();
				this.Controls.Add(cliente);
				cliente.BringToFront();
			
				MainForm mainForm;
				mainForm = (MainForm)this.FindForm();
				mainForm.lbPanelC.Text = "Agregar Cliente";
			} else {
				MessageBox.Show("No eres admin", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		//<<<<<
		
	}
}
