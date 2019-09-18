using System;

namespace ArregloInfinito
{
    public class Lista
    {
        private int Indice = 0;
        private string[] Tabla = new string[1];

        public Lista()
        {

        }
        private void ModificaArreglo(int cambio)
        {

        }
        public string[] CargarProducto(string producto)
        {
            try
            {
                Tabla[Indice] = producto;
                Indice++;

            }
            catch (IndexOutOfRangeException)
            {
                string[] Extensivo = new string[Tabla.Length + 1];
                for (int i = 0; i < Indice; i++)
                {
                    Extensivo[i] = Tabla[i];
                }
                Tabla = Extensivo;
                Tabla[Indice] = producto;
                Indice++;
            }
            return Tabla;
        }
        public string MostrarTodo()
        {

            return null;
        }
        public int BuscarElemento(string elemento)
        {
            return 0;
        }
        public string Editar(int elemento)
        {
            return null;
        }
        public string Eliminar(int elemento)
        {
            return null;
        }

    }
}