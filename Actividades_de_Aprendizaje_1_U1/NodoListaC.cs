using System.Drawing;

namespace Actividades_de_Aprendizaje_1_U1
{
    class NodoListaC
    {
        public Color relleno;
        public Color delineado;
        public NodoListaC Siguiente;


        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public NodoListaC() 
        {
        
        }


        /// <summary>
        /// Contructor que define en color de relleno
        /// </summary>
        /// <param name="Dato">Color de relleno</param>
        /// <param name="linea">Color de delineado en caso de no pasar parametro, sera negro</param>
        public NodoListaC(Color Dato, Color? linea=null)
        {
            if (linea.GetValueOrDefault() == null)
                linea = Color.Black;
            else
                this.delineado = linea.GetValueOrDefault();

            this.relleno = Dato;
        }
    }
}
