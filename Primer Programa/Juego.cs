namespace Primer_Programa
{
    using System;
    using System.Windows.Forms;

    public partial class Juego : Form
    {


        public int vRespuestasCorrectas;
        public int vPremioAcumulado;
        string[] vPreguntas = new string[21];
        string[] vRespuestas = new string[21];
        string respuestaValida;



        public Juego()
        {

            InitializeComponent();


            vPreguntas[0] = "¿QUÉ POETA ROMANO ES EL GUÍA DE DANTE A TRAVÉS DEL INFIERNO EN LA DIVINA COMEDIA?"; //;
            vRespuestas[0] = "VIRGILIO";

            vPreguntas[1] = "¿CUÁL FUE EL ÚNICO COMBATE EN TERRITORIO ARGENTINO QUE LIBRÓ EL REGIMIENTO DE GRANADEROS A CABALLO?"; //
            vRespuestas[1] = "SAN LORENZO";

            vPreguntas[2] = "SEGÚN EL HIMNO NACIONAL ARGENTINO ¿QUIÉNES RESPONDEN “AL GRAN PUEBLO ARGENTINO SALUD”";//
            vRespuestas[2] = "LOS LIBRES DEL MUNDO";

            vPreguntas[3] = "¿CÓMO SE LES DICE INFORMALMENTE A LOS MIEMBROS DEL MOVIMIENTO DE LOS SANTOS DE LOS ÚLTIMOS DÍAS?"; //
            vRespuestas[3] = "MORMONES";

            vPreguntas[4] = "¿CUÁL ES EL SIGNIFICADO DE LA FRASE EN LATÍN “HABEMUS PAPAM”"; //
            vRespuestas[4] = "TENEMOS PAPA";

            vPreguntas[5] = "¿CUÁL FUE LA PRIMER PELÍCULA ARGENTINA EN SER NOMINADA AL OSCAR COMO “MEJOR PELÍCULA EXTRANJERA”"; //
            vRespuestas[5] = "LA TREGUA";

            vPreguntas[6] = "¿CUÁL ERA EL NOMBRE CÓDIGO EN IDIOMA INGLÉS DE LA BOMBA NUCLEAR QUE DETONÓ SOBRE LA CIUDAD DE NAGASAKI?"; //
            vRespuestas[6] = "FAT MAN";

            vPreguntas[7] = "¿CUÁL ERA EL NOMBRE CÓDIGO EN IDIOMA INGLÉS DE LA BOMBA NUCLEAR QUE DETONÓ SOBRE LA CIUDAD DE HIROSHIMA?"; //
            vRespuestas[7] = "LITTLE BOY";

            vPreguntas[8] = "EN LAS DIRECCIONES DE CORREO ELECTRÓNICO ¿QUÉ SIGNO SEPARA EL NOMBRE DEL USUARIO Y EL NOMBRE DEL ADMINISTRADOR DEL SERVICIO?"; //
            vRespuestas[8] = "ARROBA";

            vPreguntas[9] = "¿QUÉ NÚMERO TUVO LA LEY DE EMERGENCIA ECONÓMICA DE LA PROVINCIA DE BUENOS AIRES QUE AUTORIZÓ LA EMISIÓN DE LOS BONOS PATACONES EN 2001?"; //
            vRespuestas[9] = "LEY 12.727";

            vPreguntas[10] = "¿CÓMO SE LLAMA LA ESTRELLA MÁS CERCANA AL SOL?"; // 
            vRespuestas[10] = "PRÓXIMA CENTAURI";

            vPreguntas[11] = "¿QUÉ SIGNIFICA LA LETRA “I” EN LA SIGLA VIH?"; //
            vRespuestas[11] = "INMUNODEFICIENCIA";

            vPreguntas[12] = "¿CON QUÉ EQUIPO DE FÚTBOL GABRIEL BATISTUTA FUE CAMPEÓN DE SEGUNDA DIVISIÓN?"; //
            vRespuestas[12] = "FIORENTINA";

            vPreguntas[13] = "¿EN QUÉ AÑO SE EMITIÓ EL ESTRENO DEL PRIMER CAPÍTULO DE LA SERIE LOST?"; //
            vRespuestas[13] = "2004";

            vPreguntas[14] = "¿CÓMO SE LLAMÓ AL PROYECTO DE INVESTIGACIÓN Y DESARROLLO QUE PRODUJO LAS PRIMERAS BOMBAS ATÓMICAS?"; //
            vRespuestas[14] = "MANHATTAN";

            vPreguntas[15] = "¿CUÁL ES EL NOMBRE DE LA ESPOSA DEL PERSONAJE DE ANIMACIÓN ROGER RABBIT?"; //
            vRespuestas[15] = "JESSICA";

            vPreguntas[16] = "¿CON QUÉ SIGLA SE DENOMINÓ AL CANAL 7 DE BUENOS AIRES EN SUS PRIMEROS AÑOS DE TRANSMISIÓN A COLOR?"; //
            vRespuestas[16] = "ATC";

            vPreguntas[17] = "POR ORDEN ALFABÉTICO ¿QUE PREPOSICIÓN ESTÁ ENTRE “SO” Y “TRAS”?"; //
            vRespuestas[17] = "SOBRE";

            vPreguntas[18] = "¿CUÁNTOS EPISODIOS PARA TELEVISIÓN TUVO LA SERIE “BREAKING BAD”"; //
            vRespuestas[18] = "62";

            vPreguntas[19] = "SEGÚN LA CANCIÓN DE PALITO ORTEGA “YO TENGO FÉ” ¿QUE ES LO QUE TRIUNFARÁ POR SIEMPRE?"; //
            vRespuestas[19] = "EL AMOR";

            vPreguntas[20] = "¿QUÉ SE CONMEMORA EN TODO EL MUNDO EL 1 DE DICIEMBRE?"; //
            vRespuestas[20] = "EL DÍA DE LA LUCHA CONTRA EL SIDA";

        }

        private void Juego_Load(object sender, EventArgs e)
        {

            lblResultadoDeRespuesta.Visible = false;

        }

        private void btRetirarse_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            selectorPreguntas();
            btIniciar.Text = "Continuar";
            btIniciar.Enabled = false;
            lblPreguntasRestantes.Text = "20";
            lblResultadoDeRespuesta.Visible = false;
        }

        public void selectorPreguntas()
        {
            Random rnd = new Random();
            Random random = new Random();
            int btnResp = random.Next(4);
            int mIndex = rnd.Next(20);
            lblPregunta.Text = vPreguntas[mIndex];
            respuestaValida = vRespuestas[mIndex];
            
            switch (mIndex)
            {
                case 0:
                    btRespuesta1.Text = "LORENZO";
                    btRespuesta2.Text = "MARTIN";
                    btRespuesta3.Text = respuestaValida;
                    btRespuesta4.Text = "JIUSEPPE";
                    break;
                case 1:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = respuestaValida;
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 2:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = respuestaValida;
                    break;
                case 3:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = respuestaValida;
                    break;
                case 4:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = respuestaValida;
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 5:
                    btRespuesta1.Text = respuestaValida;
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 6:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = respuestaValida;
                    btRespuesta4.Text = "";
                    break;
                case 7:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = respuestaValida;
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 8:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = respuestaValida;
                    break;
                case 9:
                    btRespuesta1.Text = respuestaValida;
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 10:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = respuestaValida;
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 11:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = respuestaValida;
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 12:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = respuestaValida;
                    break;
                case 13:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = respuestaValida;
                    btRespuesta4.Text = "";
                    break;
                case 14:
                    btRespuesta1.Text = respuestaValida;
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 15:
                    btRespuesta1.Text = respuestaValida;
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 16:
                    btRespuesta1.Text = respuestaValida;
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 17:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = respuestaValida;
                    btRespuesta4.Text = "";
                    break;
                case 18:
                    btRespuesta1.Text = respuestaValida;
                    btRespuesta2.Text = "";
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
                case 19:
                    btRespuesta1.Text = "";
                    btRespuesta2.Text = respuestaValida;
                    btRespuesta3.Text = "";
                    btRespuesta4.Text = "";
                    break;
            }
        }

        public void validarRespuestas(string Respuesta)
        {
            if (Respuesta==respuestaValida)
            {
                lblResultadoDeRespuesta.Text = "¡Correcto!";
                lblResultadoDeRespuesta.Visible = true;
            }
            else
            {
                lblResultadoDeRespuesta.Text = "¡InCorrecto!";
                lblResultadoDeRespuesta.Visible = true;
            }
        }

        private void BtRespuesta1_Click(object sender, EventArgs e)
        {
            btIniciar.Enabled = true;
            validarRespuestas(btRespuesta1.Text);
        }

        private void BtRespuesta2_Click(object sender, EventArgs e)
        {
            btIniciar.Enabled = true;
            validarRespuestas(btRespuesta2.Text);
        }

        private void BtRespuesta3_Click(object sender, EventArgs e)
        {
            btIniciar.Enabled = true;
            validarRespuestas(btRespuesta3.Text);
        }

        private void BtRespuesta4_Click(object sender, EventArgs e)
        {
            btIniciar.Enabled = true;
            validarRespuestas(btRespuesta4.Text);
        }
    }
}
