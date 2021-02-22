using System.Drawing;

namespace Actividades_de_Aprendizaje_1_U1
{
    class ListaColores
    {
        public NodoListaC cabeza;
        public NodoListaC aux;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ListaColores() 
        {
            cabeza = null;
        }

        /// <summary>
        /// Constructor con parametro color
        /// </summary>
        /// <param name="color"></param>
        public ListaColores(Color color)
        {
            InsertarALaCabeza(color);
        }

        /// <summary>
        /// Inserta un elemento en la cabeza de la lista
        /// </summary>
        /// <param name="dato">Color que se va a insertar en el elemento del nodo</param>
        private void InsertarALaCabeza(Color? dato = null)
        {
            if (dato == null)
                dato = Color.Black;

            //Se crea el nodo
            NodoListaC nodoC = new NodoListaC(dato.GetValueOrDefault());
            //Se establece la sigueinte referencia
            nodoC.Siguiente = cabeza;
            cabeza = nodoC;
        }

        /// <summary>
        /// Metodo para insertar al final de la lista
        /// </summary>
        /// <param name="dato">Color de relleno</param>
        /// <param name="delineado">Color de delineado</param>
        public void InsertarAlFinal(Color dato, Color? delineado = null)
        {
            if (delineado==null)
                delineado = Color.Black;


            //Se verifica que haya elementos en la lista
            if (cabeza == null)
            {
                //De no haberlos crea el primer elemento
                InsertarALaCabeza(dato);
            }
            else
            {
                //Variable final como variable temporal
                aux = cabeza;
                //Cabeza = nuevo nodo
                cabeza = new NodoListaC(dato, delineado);
                //Se reestablecen los apuntadores con la variable final
                cabeza.Siguiente = aux;

                #region Comentario
                /*
                 * En este caso realmente se puede pasar por alto la variable final,
                 * ya que podemos hacer uso de la variable auxiliar para poder
                 * "reestablecer" el orden de la lista.
                */
                #endregion
            }
        }

        /// <summary>
        /// Metodo para tomar el color de la lista
        /// </summary>
        /// <returns>Un arreglo de colores</returns>
        public Color[] Tomar() 
        {
            if (cabeza==null)
                throw new System.NullReferenceException("Ya no hay elementos en la lista");

            aux = cabeza;
            cabeza = cabeza.Siguiente;

            Color[] colores = { aux.relleno, aux.delineado };

            return colores;
        }

    }
}
