using System;

namespace Parcial_3
{
    public class Lista
    {
        #region PROPIEDADES
        private string[] listaAlumnos = new string[1];
        private string[] listaNotas = new string[1];
        private int ProximaPosicion = 0;
        #endregion

        #region CONSTRUCTOR
        #endregion

        #region METODOS
        public bool Agregar(string alumno, string nota)
        {
            bool Resp = false;
            try
            {
                if (ProximaPosicion == listaAlumnos.Length)
                {
                    this.AgregaRegistro(1);
                }

                listaAlumnos[ProximaPosicion] = alumno;
                listaNotas[ProximaPosicion] = nota;
                ProximaPosicion++;
                Resp = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return Resp;
        }

        public string MostrarLista()
        {
            string Respuesta = "";
            if (ProximaPosicion > 0)
            {
                Respuesta = listaAlumnos[0] + " - " + listaNotas[0];
                for (int i = 1; i < ProximaPosicion; i++)
                {
                    Respuesta = Respuesta + "\r\n" + listaAlumnos[i] + " - " + listaNotas[i];
                }
            }
            return Respuesta;
        }

        private void AgregaRegistro(int incremento)
        {
            string[] Temp = new string[listaAlumnos.Length + incremento];
            listaAlumnos = this.Copiar(listaAlumnos, Temp);
            string[] TempNotas = new string[listaNotas.Length + incremento];
            listaNotas = this.Copiar(listaNotas, TempNotas);
        }

        private string[] Copiar(string[] Origen, string[] Destino)
        {
            for (int i = 0; i < ProximaPosicion; i++)
            {
                Destino[i] = Origen[i];
            }
            return Destino;
        }

        /// <summary>
        /// Devuelve la posicion del texto (entero) dentro del arregla, <br/>
        /// la cuenta inicia en 0 (cero).
        /// Devuelve -1 cuando no encuentra Que en la lista.
        /// </summary>
        /// <param name="Que">texto completo a buscar en la lista</param>
        public int BuscarPosicion(string Que)
        {
            int Resp = -1;

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                if (listaAlumnos[i].CompareTo(Que) == 0)
                {
                    Resp = i;
                    break;
                }
            }

            return Resp;
        }

        public string Borrar(string Que)
        {
            string Resp = "";
            int Pos = this.BuscarPosicion(Que);
            if (Pos == -1)
            {
                Resp = Que + " no ha sido encontrado en la lista.";
            }
            else
            {
                for (int i = Pos; i < ProximaPosicion - 1; i++)
                {
                    this.listaAlumnos[i] = this.listaAlumnos[i + 1];
                    this.listaNotas[i] = this.listaNotas[i + 1];

                }
                this.listaAlumnos[ProximaPosicion - 1] = null;
                this.listaNotas[ProximaPosicion - 1] = null;
                ProximaPosicion = ProximaPosicion - 1;
                AgregaRegistro(-1);
            }

            return Resp;
        }
        /// <summary>
        /// Ordena una lista en forma alfabetica 
        /// </summary>
        /// <returns></returns>
        public string Ordenar()
        {
            string salida = "";
            string[] listaOrdenadaAlumnos = new string[listaAlumnos.Length];
            string[] listaOrdenadaNotas = new string[listaNotas.Length];
            Copiar(listaAlumnos, listaOrdenadaAlumnos);
            Copiar(listaNotas, listaOrdenadaNotas);

            if (listaOrdenadaAlumnos.Length > 1)
            {
                for (int j = 0; j < listaOrdenadaAlumnos.Length; j++)
                {
                    for (int i = 0; i < listaOrdenadaAlumnos.Length; i++)
                    {
                        try
                        {
                            if (listaOrdenadaAlumnos[i].CompareTo(listaOrdenadaAlumnos[i + 1]) == 1)
                            {
                                //El que sigue es mayor
                                string Temp = listaOrdenadaAlumnos[i];
                                string TempNotas = listaOrdenadaNotas[i];
                                listaOrdenadaAlumnos[i] = listaOrdenadaAlumnos[i + 1];
                                listaOrdenadaNotas[i] = listaOrdenadaNotas[i + 1];
                                listaOrdenadaAlumnos[i + 1] = Temp;
                                listaOrdenadaNotas[i + 1] = TempNotas;

                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Finalizo la revision de la lista");
                        }
                    }

                }
            }
            for (int i = 0; i < listaOrdenadaAlumnos.Length; i++)
            {
                salida = salida + listaOrdenadaAlumnos[i] +" - "+ listaOrdenadaNotas[i] + "\r\n";
            }

            return salida;
        }
        #endregion
    }
}
