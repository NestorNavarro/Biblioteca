/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 20/05/2019
 * Hora: 08:19 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Biblioteca
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
				///> Me permite que la ventana tenga bordes redondos
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        //<
        
        //> Me permite mover la ventana, usando un estilo sin bordes
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
		public MainForm()
		{
			InitializeComponent();
			
			//> Me permite que la ventana tenga bordes redondos
			this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //<
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//>Métodos que permiten mover la ventana
		void PanelTopMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		//>Método para inicializar mi usercontrol(login) y la label
		void MainFormLoad(object sender, EventArgs e)
		{
			lbPanelC.Text = "Inicio de sesión";
			
			loginControl11.BringToFront();
			
		}
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		void LbPanelCMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		//<
	}
}
