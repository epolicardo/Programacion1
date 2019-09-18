namespace ListaAlumnos.Repositorios
{
    using System;

    public class Lista
    {
        #region Propiedades
        private string[] lista = new string[5];
        private int ProximaPosicion = 0;
        #endregion

        #region Constructores
        public Lista()
        {

        }
        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve todos los elementos encontrados en una lista.
        /// </summary>
        public string[] GetAll()
        {
            string[] output = null;

            return output;
        }

        /// <summary>
        /// Devuelve un solo elemento de la lista, identificado por su Id
        /// </summary>
        public string[] Get(int id)
        {
            string[] output = null;

            return output;
        }

        /// <summary>
        /// Agrega un elemento a la lista
        /// </summary>
        public bool Create(string elemento)
        {
            bool output = false;

            if (ProximaPosicion == lista.Length)
            {
                this.AgregaRegistro(1);
            }
            lista[ProximaPosicion] = elemento;
            ProximaPosicion++;
            output = true;

            return output;
        }

        private void AgregaRegistro(int v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actualiza un elemento de la lista, identificado por su Id
        /// </summary>
        public string Update(int id)
        {
            string output = null;

            return output;
        }

        /// <summary>
        /// Elimina un elemento de la lista, identificado por su Id
        /// Devuelve un mensaje con información del resultado.
        /// </summary>
        public string Delete(int id)
        {
            string output = null;

            return output;
        }

        #endregion
    }


}
