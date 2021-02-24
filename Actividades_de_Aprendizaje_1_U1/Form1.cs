using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /// <summary>
        /// Recorta las esquinas de un formulario.
        /// </summary>
        /// <param name="nLeftRect">Coordenada en x de la esquina superior izquierda</param>
        /// <param name="nTopRect">Coordenada en y de la esquina superior izquierda</param>
        /// <param name="nRightRect">Coordenada en x de la esquina inferior derecha</param>
        /// <param name="nBottomRect">Coordenada en y de la esquina inferior derecha</param>
        /// <param name="nWidthEllipse">Altura del elipse</param>
        /// <param name="nHeightEllipse">Ancho del elipse</param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.IconColor = Color.DarkRed;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.IconColor = Color.Red;
        }

        private void btnCerrar_DoubleClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form forma = new prog1();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form forma = new prog2();
            forma.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form forma = new prog3();
            forma.ShowDialog(); 
        }

    }
}
