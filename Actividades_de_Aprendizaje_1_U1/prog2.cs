using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    public partial class prog2 : Form
    {
        public prog2()
        {
            InitializeComponent();
        }

        private async Task Basic() 
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Bitmap ima = new Bitmap(@"hola.jpg");
            Pen lapiz = new Pen(Color.Black);
            SolidBrush pincelRelleno = new SolidBrush(Color.Gray);
            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
            papel.DrawLine(lapiz, 10, 10, 110, 60);
            papel.DrawRectangle(lapiz, 10, 80, 100, 50);
            papel.DrawEllipse(lapiz, 10, 80, 100, 50);
            papel.FillEllipse(pincelRelleno, 10, 150, 100, 50); ;
            papel.DrawRectangle(lapiz, 130, 10, 150, 150);
            papel.DrawImage(ima, 130, 10, 150, 150);
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            await Basic();            
        }

        private void btnDibujar_Click2(object sender, EventArgs e) 
        {

        }

        private void ChangeVisibleObjects() 
        {
            if (btnElip.Visible==false)
            {
                btnElip.Visible = true;
                btnElipRect.Visible = true;
                btnRect.Visible = true;
                btnRectInter.Visible = true;
                btnImagen.Visible = true;
            }
            else
            {
                btnElip.Visible = false;
                btnElipRect.Visible = false;
                btnRect.Visible = false;
                btnRectInter.Visible = false;
                btnImagen.Visible = false;
            }
        }


        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            ChangeVisibleObjects();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            try
            {
                Dibujo obj = new Dibujo();
                DrawInfo frm = new DrawInfo();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (ColorDialog clr = new ColorDialog())
                    {
                        ColorDialog clr2 = new ColorDialog();
                        MessageBox.Show("Color de Linea");
                        clr.ShowDialog();
                        MessageBox.Show("Color de Relleno");
                        clr2.ShowDialog();
                        obj.DibujarRectangulo(ref pictureBox1, frm.X, frm.Y, frm.Ancho1, frm.Alto1, clr.Color, clr2.Color);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnElip_Click(object sender, EventArgs e)
        {
            try
            {
                Dibujo obj = new Dibujo();
                DrawInfo frm = new DrawInfo();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (ColorDialog clr = new ColorDialog())
                    {
                        ColorDialog clr2 = new ColorDialog();
                        MessageBox.Show("Color de Linea");
                        clr.ShowDialog();
                        MessageBox.Show("Color de Relleno");
                        clr2.ShowDialog();
                        obj.DibujarElipse(ref pictureBox1, frm.X, frm.Y, frm.Ancho1, frm.Alto1, clr.Color, clr2.Color);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRectInter_Click(object sender, EventArgs e)
        {
            try
            {
                Dibujo obj = new Dibujo();
                DrawInfo frm = new DrawInfo();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (ColorDialog clr = new ColorDialog())
                    {
                        ColorDialog clr2 = new ColorDialog();
                        MessageBox.Show("Color de Linea");
                        clr.ShowDialog();
                        MessageBox.Show("Color de Relleno");
                        clr2.ShowDialog();
                        obj.DibujarRectanguloIntersectado(ref pictureBox1, frm.X, frm.Y, frm.Ancho1, frm.Alto1, clr.Color, clr2.Color);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnElipRect_Click(object sender, EventArgs e)
        {
            try
            {
                Dibujo obj = new Dibujo();
                DrawInfo frm = new DrawInfo();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (ColorDialog clr = new ColorDialog())
                    {
                        ColorDialog clr2 = new ColorDialog();
                        MessageBox.Show("Color de Linea");
                        clr.ShowDialog();
                        MessageBox.Show("Color de Relleno");
                        clr2.ShowDialog();
                        obj.DibujarElipseEnRectangulo(ref pictureBox1, frm.X, frm.Y, frm.Ancho1, frm.Alto1, clr.Color, clr2.Color);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                Dibujo obj = new Dibujo();
                DrawInfo frm = new DrawInfo();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    obj.DibujarImagen(ref pictureBox1, frm.X, frm.Y, frm.Ancho1, frm.Alto1);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
