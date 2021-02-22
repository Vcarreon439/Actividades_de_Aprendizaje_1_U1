using System;
using System.Drawing;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    class Dibujo
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Dibujo() 
        {
        
        }

        /// <summary>
        /// Metodo para deibujar un rectangulo dentro de un PictureBox.
        /// </summary>
        /// <param name="pct">PictureBox que se va a modificar</param>
        /// <param name="x">Coordenada en X</param>
        /// <param name="y">Coordenada en Y</param>
        /// <param name="width">Ancho del dibujo</param>
        /// <param name="height">Alto del dibujo</param>
        /// <param name="clrLinea">Color de Linea del dibujo</param>
        /// <param name="clrRelleno">Color de Relleno del dibujo</param>
        public void DibujarRectangulo(ref PictureBox pct, int x, int y, int width, int height, Color? clrLinea = null, Color? clrRelleno = null)
        {
            int[] delimeters = { pct.Width, pct.Height};

            //Error de argumento en caso de no declararse un color de relleno
            if (clrRelleno == null)
                throw new ArgumentException("Color de relleno no declarado");

            //Error de argumento en caso de no declararse un color
            if (clrLinea == null)
                throw new ArgumentException("El color de pluma no fue especificado");
            
            if (width > delimeters[0])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            
            if (height > delimeters[1])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");

            //En caso de rebasar los limites del lienzo
            if (width > delimeters[0] | height == delimeters[1])
            {
                width = (delimeters[0]-10);
                height = (delimeters[1]-10);
                x = 0;
                y = 0;
                MessageBox.Show("Figura redimensionada para ser visible");
            }

            Graphics papel;
            SolidBrush Relleno = new SolidBrush(clrRelleno.GetValueOrDefault());
            papel = pct.CreateGraphics();
            Pen lapiz = new Pen(clrLinea.GetValueOrDefault());
            papel.FillRectangle(Relleno, x, y, width, height);
            papel.DrawRectangle(lapiz, x, y, width, height);
            
        }

        /// <summary>
        /// Metodo para dibujar un elipse en un picturebox
        /// </summary>
        /// <param name="pct">Picturebox en el que se va a adibujar</param>
        /// <param name="x">Coordenada en x</param>
        /// <param name="y">Coordenada en y</param>
        /// <param name="width">Ancho de la figura</param>
        /// <param name="height">Alto de la figura</param>
        /// <param name="clrLinea">Color de linea de la figura</param>
        /// <param name="clrRelleno">Color de relleno de la figura</param>
        public void DibujarElipse(ref PictureBox pct, int x, int y, int width, int height, Color? clrLinea = null, Color? clrRelleno = null)
        {
            int[] delimeters = { pct.Width, pct.Height };

            //Error de argumento en caso de no declararse un color de relleno
            if (clrRelleno == null)
            {
                clrRelleno = Color.White;
                throw new ArgumentException("Color de relleno no declarado Default{0}", clrRelleno.ToString());
            }

            //Error de argumento en caso de no declararse un color
            if (clrLinea == null)
                throw new ArgumentException("El color de pluma no fue especificado");
            //Error en caso que el ancho sea mayor a 349
            if (width > delimeters[0])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            //Error en caso que el largo sea mayor a 232
            if (height > delimeters[1])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");

            //En caso de especificar las dimensiones de 349 o 232
            if (width > delimeters[0] | height == delimeters[1])
            {
                width -= 10;
                height -= 10;
                x = 0;
                y = 0;
                MessageBox.Show("Figura redimensionada para ser visible");
            }

            Graphics papel;
            SolidBrush Relleno = new SolidBrush(clrRelleno.GetValueOrDefault());
            papel = pct.CreateGraphics();
            Pen lapiz = new Pen(clrLinea.GetValueOrDefault());
            papel.FillEllipse(Relleno, x, y, width, height);
            papel.DrawEllipse(lapiz, x, y, width, height);
        }

        /// <summary>
        /// Metodo para dibujar un elipse dentro de un rectangulo
        /// </summary>
        /// <param name="pct">PictureBox en donde se va a dibujar</param>
        /// <param name="x">Coordenada en X</param>
        /// <param name="y">Coordenada en y</param>
        /// <param name="width">Ancho de la figura</param>
        /// <param name="height">Alto de la figura</param>
        /// <param name="clrLinea">Color de la linea de la figura</param>
        /// <param name="clrRelleno">Color del relleno de la linea</param>
        public void DibujarElipseEnRectangulo(ref PictureBox pct, int x, int y, int width, int height, Color? clrLinea = null, Color? clrRelleno = null)
        {
            int[] delimeters = { pct.Width, pct.Height };

            //Error de argumento en caso de no declararse un color de relleno
            if (clrRelleno == null)
            {
                clrRelleno = Color.White;
                throw new ArgumentException("Color de relleno no declarado Default{0}", clrRelleno.ToString());
            }

            //Error de argumento en caso de no declararse un color
            if (clrLinea == null)
                throw new ArgumentException("El color de pluma no fue especificado");
            //Error en caso que el ancho sea mayor a 349
            if (width > delimeters[0])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            //Error en caso que el largo sea mayor a 232
            if (height > delimeters[1])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");

            //En caso de especificar las dimensiones de 349 o 232
            if (width > delimeters[0] | height == delimeters[1])
            {
                width -= 10;
                height -= 10;
                x = 0;
                y = 0;
                MessageBox.Show("Figura redimensionada para ser visible");
            }

            Graphics papel;
            SolidBrush Relleno = new SolidBrush(clrRelleno.GetValueOrDefault());
            papel = pct.CreateGraphics();
            Pen lapiz = new Pen(clrLinea.GetValueOrDefault());
            papel.DrawRectangle(lapiz, x, y, width, height);
            papel.FillEllipse(Relleno, x, y, width, height);
            papel.DrawEllipse(lapiz, x, y, width, height);
        }

        /// <summary>
        /// Metodo para dibujar un rectangulo con una raya atravesandolo
        /// </summary>
        /// <param name="pct">Picturebox en el que se va a dibujar</param>
        /// <param name="x">Coordenada en x</param>
        /// <param name="y">Coordenada en y</param>
        /// <param name="width">Ancho de la figura</param>
        /// <param name="height">Alto de la figura</param>
        /// <param name="clrLinea">Color de la linea</param>
        /// <param name="clrRelleno">Color del relleno</param>
        public void DibujarRectanguloIntersectado(ref PictureBox pct, int x, int y, int width, int height, Color? clrLinea = null, Color? clrRelleno = null)
        {
            int[] delimeters = { pct.Width, pct.Height };

            //Error de argumento en caso de no declararse un color de relleno
            if (clrRelleno == null)
            {
                clrRelleno = Color.White;
                throw new ArgumentException("Color de relleno no declarado Default{0}", clrRelleno.ToString());
            }

            //Error de argumento en caso de no declararse un color
            if (clrLinea == null)
                throw new ArgumentException("El color de pluma no fue especificado");
            //Error en caso que el ancho sea mayor a 349
            if (width > delimeters[0])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            //Error en caso que el largo sea mayor a 232
            if (height > delimeters[1])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");

            //En caso de especificar las dimensiones de 349 o 232
            if (width > delimeters[0] | height == delimeters[1])
            {
                width -= 10;
                height -= 10;
                x = 0;
                y = 0;
                MessageBox.Show("Figura redimensionada para ser visible");
            }

            Graphics papel;
            SolidBrush Relleno = new SolidBrush(clrRelleno.GetValueOrDefault());
            papel = pct.CreateGraphics();
            Pen lapiz = new Pen(clrLinea.GetValueOrDefault());
            papel.FillRectangle(Relleno, x, y, width, height);
            papel.DrawRectangle(lapiz, x, y, width, height);
            papel.DrawLine(lapiz, x, y, width+10, height+10);
        }

        /// <summary>
        /// Metodo para dibujar una imagen en un picture box
        /// </summary>
        /// <param name="pct">Picturebox en donde se va a dibujar</param>
        /// <param name="x">Coordenada en x</param>
        /// <param name="y">Coordenada en y</param>
        /// <param name="width">Ancho de laimagen</param>
        /// <param name="height">Alto de la imagen</param>
        public void DibujarImagen(ref PictureBox pct, int x, int y, int width, int height)
        {
            int[] delimeters = { pct.Width, pct.Height };

            //Error en caso que el ancho sea mayor a 349
            if (width > delimeters[0])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");
            //Error en caso que el largo sea mayor a 232
            if (height > delimeters[1])
                throw new ArgumentException("El ancho rebasa el ancho del lienzo");

            //En caso de especificar las dimensiones de 349 o 232
            if (width > delimeters[0] | height == delimeters[1])
            {
                width -= 10;
                height -= 10;
                x = 0;
                y = 0;
                MessageBox.Show("Figura redimensionada para ser visible");
            }

            Graphics papel;
            papel = pct.CreateGraphics();
            Bitmap ima;

            using (OpenFileDialog frm = new OpenFileDialog())
            {
                frm.Filter="Imagenes (*.jpeg)|(*.jpg)|All files (*.*)|*.*";
                frm.FilterIndex = 2;
                frm.RestoreDirectory = true;

                if (frm.ShowDialog()==DialogResult.OK)
                {
                    string fuente = frm.FileName;
                    ima = new Bitmap(fuente);
                    papel.DrawImage(ima,x,y,width,height);
                }

            }
            
        }

        /// <summary>
        /// Método para predefinir colores de la lista
        /// </summary>
        /// <param name="lista">Lista a modificar</param>
        private void ColoresPredeterminados(ref ListaColores lista) 
        {
            lista = new ListaColores(Color.Black);
            lista.InsertarAlFinal(Color.Blue);
            lista.InsertarAlFinal(Color.Yellow);
            lista.InsertarAlFinal(Color.Red);
            lista.InsertarAlFinal(Color.Blue, Color.White);
            lista.InsertarAlFinal(Color.Black, Color.White);
        }


        /// <summary>
        /// Metodo para dibujar una Diana en un picture box
        /// </summary>
        /// <param name="pictureBox1">Picture box donde se va a dibujar la diana</param>
        /// <param name="coordX">Coordenada en x</param>
        /// <param name="coordY">Coordenada en y</param>
        /// <param name="lista">Lisra de colores</param>
        /// <param name="tamaño">Tamaño de la diana</param>
        /// <param name="circunferencias">Candidad de pares de circulos que se realizarán</param>
        public void Dibujar_Diana(ref PictureBox pictureBox1, int coordX = 0, int coordY = 0, ListaColores lista = null, int tamaño = 160, int circunferencias = 4)
        {
            int[] center = null;

            #region Condidiones
            if (lista == null)
                ColoresPredeterminados(ref lista);

            if (coordX == 0 && coordY == 0)
                center = new int[] { pictureBox1.Width / 2, pictureBox1.Height / 2 };
            else
                center = new int[] { coordX, coordY };
            #endregion

            #region Elementos Graficos
            Graphics papel;
            papel = pictureBox1.CreateGraphics();

            Pen lapiz ;
            SolidBrush solidBrush;
            #endregion

            #region Ciclo For para dibujar las elipses
            for (int i = 0; i < circunferencias; i++)
            {
                Color[] colores = lista.Tomar();

                solidBrush = new SolidBrush(colores[0]);
                lapiz = new Pen(colores[1]);
                
                for (int j = 0; j < 2; j++)
                {
                    //solidBrush = new SolidBrush(lista.Tomar());
                    papel.FillEllipse(solidBrush, center[0], center[1], tamaño, tamaño);
                    papel.DrawEllipse(lapiz, center[0], center[1], tamaño, tamaño);
                    MessageBox.Show($"{center[0].ToString()}  {center[1].ToString()}");
                    tamaño -= 20;
                    center[0] += 10;
                    center[1] += 10;
                }
            }
            #endregion

        }

        /// <summary>
        /// Destructor por defecto
        /// </summary>
        ~Dibujo() 
        {

        }

    }
}
