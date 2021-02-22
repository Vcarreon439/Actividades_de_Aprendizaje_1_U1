using System;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    public partial class DrawInfo : Form
    {
        private int x;
        private int y;
        private int Ancho;
        private int Alto;

        public DrawInfo()
        {
            InitializeComponent();
        }

        public int Alto1 { get => Alto; set => Alto = value; }
        public int Ancho1 { get => Ancho; set => Ancho = value; }
        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                X = int.Parse(txtCoordX.Text);
                Y = int.Parse(txtCoordY.Text);
                Ancho1 = int.Parse(txtAncho.Text);
                Alto1 = int.Parse(txtAlto.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese solo valores numéricos en los espacios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
