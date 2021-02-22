using System;
using System.Drawing;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    public partial class prog1 : Form
    {
        public prog1()
        {
            InitializeComponent();
            this.Size = new Size(390,340);
        }


        private void Dibujar(ref PictureBox pct) 
        {
            Graphics papel;

            papel = pct.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
            papel.DrawRectangle(lapiz, 10, 75, 100, 100);
        }

        private void Dibujar(ref PictureBox pct, int x, int y, int width, int height, Color? color = null)
        {
            //Error de argumento en caso de no declararse un color
            if (color == null)
                throw new ArgumentException("El color de pluma no fue especificado");
            //Error en caso que el ancho sea mayor a 349
            if (width > 349)
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            //Error en caso que el largo sea mayor a 232
            if (height > 232)
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            
            //En caso de especificar las dimensiones de 349 o 232
            if (width==349|height==232)
            {
                width -= 10;
                height -= 10;
                x = 0;
                y = 0;
                MessageBox.Show("Figura redimensionada para ser visible");
            }

            Graphics papel;
                papel = pct.CreateGraphics();
                Pen lapiz = new Pen(color.GetValueOrDefault());
                papel.DrawRectangle(lapiz, x, y, width, height);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            try
            {
                Dibujar(ref pctAreaDibujo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRectangulo_Click2(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtCoordX.Text);
                int y = int.Parse(txtCoordY.Text);
                int ancho = int.Parse(txtAncho.Text);
                int alto = int.Parse(txtAlto.Text);
                Color pluma;

                using (ColorDialog clr = new ColorDialog())
                {
                    clr.ShowDialog();
                    pluma = clr.Color;
                }

                Dibujar(ref pctAreaDibujo, x, y, ancho, alto, pluma);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.FormatException) 
            {
                MessageBox.Show("Porfavor llene correctamente los campos");
            }
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

            if (this.Size.Height<400)
            {
                //Cambio de tamaño de la forma
                this.Size = new Size(this.Size.Width, 430);
                //Cambio del icono flecha
                this.icnPctBoxFlecha.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                //Cambio de Evento Click para opcion de coordenadas
                btnRectangulo.Click -= new EventHandler(btnRectangulo_Click);
                btnRectangulo.Click += new EventHandler(btnRectangulo_Click2);
            }
            else
            {
                //Cambio de tamaño de la forma
                this.Size = new Size(this.Size.Width, 340);
                //Cambio del icono flecha
                this.icnPctBoxFlecha.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                //Cambio de Evento Click para opcion de coordenadas
                btnRectangulo.Click -= new EventHandler(btnRectangulo_Click2);
                btnRectangulo.Click += new EventHandler(btnRectangulo_Click);
            }

            

        }

    }
}
