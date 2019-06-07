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
        string[] vRespuestasSenuelo0 = new string[3];
        string[] vRespuestasSenuelo1= new string[3];
        string[] vRespuestasSenuelo2= new string[3];
        string[] vRespuestasSenuelo3= new string[3];
        string[] vRespuestasSenuelo4= new string[3];
        string[] vRespuestasSenuelo5= new string[3];
        string[] vRespuestasSenuelo6= new string[3];
        string[] vRespuestasSenuelo7= new string[3];
        string[] vRespuestasSenuelo8= new string[3];
        string[] vRespuestasSenuelo9= new string[3];
        string[] vRespuestasSenuelo10= new string[3];
        string[] vRespuestasSenuelo11= new string[3];
        string[] vRespuestasSenuelo12 = new string[3];
        string[] vRespuestasSenuelo13 = new string[3];
        string[] vRespuestasSenuelo14 = new string[3];
        string[] vRespuestasSenuelo15 = new string[3];
        string[] vRespuestasSenuelo16 = new string[3];
        string[] vRespuestasSenuelo17 = new string[3];
        string[] vRespuestasSenuelo18 = new string[3];
        string[] vRespuestasSenuelo19 = new string[3];
        string[] vRespuestasSenuelo20 = new string[3];

        string respuestaValida;
        string RespA, RespB, RespC, RespD;



        public Juego()
        {


            InitializeComponent();
            lblPreguntasRestantes.Text = "20";
            lblPreguntasRestantes.Visible = false;
            vPreguntas[0] = "¿QUÉ POETA ROMANO ES EL GUÍA DE DANTE A TRAVÉS DEL INFIERNO EN LA DIVINA COMEDIA?"; //;
            vRespuestas[0] = "VIRGILIO";
            vRespuestasSenuelo0[0] = "MARTIN";
            vRespuestasSenuelo0[1] = "JOSEPH";
            vRespuestasSenuelo0[2] = "RAIMUND";

            vPreguntas[1] = "¿CUÁL FUE EL ÚNICO COMBATE EN TERRITORIO ARGENTINO QUE LIBRÓ EL REGIMIENTO DE GRANADEROS A CABALLO?"; //
            vRespuestas[1] = "SAN LORENZO";
            vRespuestasSenuelo1[0] = "GÜEMES";
            vRespuestasSenuelo1[1] = "COMBATE DE SAN NICOLAS";
            vRespuestasSenuelo1[2] = "COMBATE DE HUAQUI";

            vPreguntas[2] = "SEGÚN EL HIMNO NACIONAL ARGENTINO ¿QUIÉNES RESPONDEN “AL GRAN PUEBLO ARGENTINO SALUD”";//
            vRespuestas[2] = "LOS LIBRES DEL MUNDO";
            vRespuestasSenuelo2[0] = "LOS HOMBRES DEL MUNDO";
            vRespuestasSenuelo2[1] = "LOS ARGENTINOS";
            vRespuestasSenuelo2[2] = "LOS NATIVOS DEL MUNDO";

            vPreguntas[3] = "¿CÓMO SE LES DICE INFORMALMENTE A LOS MIEMBROS DEL MOVIMIENTO DE LOS SANTOS DE LOS ÚLTIMOS DÍAS?"; //
            vRespuestas[3] = "MORMONES";
            vRespuestasSenuelo3[0] = "MASONES";
            vRespuestasSenuelo3[1] = "SANSONES";
            vRespuestasSenuelo3[2] = "RAMONES";

            vPreguntas[4] = "¿CUÁL ES EL SIGNIFICADO DE LA FRASE EN LATÍN “HABEMUS PAPAM”"; //
            vRespuestas[4] = "TENEMOS PAPA";
            vRespuestasSenuelo4[0] = "HAY PAPAS";
            vRespuestasSenuelo4[1] = "HABLEMOS DE PAPAS";
            vRespuestasSenuelo4[2] = "QUEMAN LAS PAPAS";

            vPreguntas[5] = "¿CUÁL FUE LA PRIMER PELÍCULA ARGENTINA EN SER NOMINADA AL OSCAR COMO “MEJOR PELÍCULA EXTRANJERA”"; //
            vRespuestas[5] = "LA TREGUA";
            vRespuestasSenuelo5[0] = "MARTIN";
            vRespuestasSenuelo5[1] = "JOSEPH";
            vRespuestasSenuelo5[2] = "RAIMUND";

            vPreguntas[6] = "¿CUÁL ERA EL NOMBRE CÓDIGO EN IDIOMA INGLÉS DE LA BOMBA NUCLEAR QUE DETONÓ SOBRE LA CIUDAD DE NAGASAKI?"; //
            vRespuestas[6] = "FAT MAN";
            vRespuestasSenuelo6[0] = "MARTIN";
            vRespuestasSenuelo6[1] = "JOSEPH";
            vRespuestasSenuelo6[2] = "RAIMUND";

            vPreguntas[7] = "¿CUÁL ERA EL NOMBRE CÓDIGO EN IDIOMA INGLÉS DE LA BOMBA NUCLEAR QUE DETONÓ SOBRE LA CIUDAD DE HIROSHIMA?"; //
            vRespuestas[7] = "LITTLE BOY";
            vRespuestasSenuelo7[0] = "MARTIN";
            vRespuestasSenuelo7[1] = "JOSEPH";
            vRespuestasSenuelo7[2] = "RAIMUND";

            vPreguntas[8] = "EN LAS DIRECCIONES DE CORREO ELECTRÓNICO ¿QUÉ SIGNO SEPARA EL NOMBRE DEL USUARIO Y EL NOMBRE DEL ADMINISTRADOR DEL SERVICIO?"; //
            vRespuestas[8] = "ARROBA";
            vRespuestasSenuelo8[0] = "MARTIN";
            vRespuestasSenuelo8[1] = "JOSEPH";
            vRespuestasSenuelo8[2] = "RAIMUND";


            vPreguntas[9] = "¿QUÉ NÚMERO TUVO LA LEY DE EMERGENCIA ECONÓMICA DE LA PROVINCIA DE BUENOS AIRES QUE AUTORIZÓ LA EMISIÓN DE LOS BONOS PATACONES EN 2001?"; //
            vRespuestas[9] = "LEY 12.727";
            vRespuestasSenuelo9[0] = "MARTIN";
            vRespuestasSenuelo9[1] = "JOSEPH";
            vRespuestasSenuelo9[2] = "RAIMUND";

            vPreguntas[10] = "¿CÓMO SE LLAMA LA ESTRELLA MÁS CERCANA AL SOL?"; // 
            vRespuestas[10] = "PRÓXIMA CENTAURI";
            vRespuestasSenuelo10[0] = "MARTIN";
            vRespuestasSenuelo10[1] = "JOSEPH";
            vRespuestasSenuelo10[2] = "RAIMUND";

            vPreguntas[11] = "¿QUÉ SIGNIFICA LA LETRA “I” EN LA SIGLA VIH?"; //
            vRespuestas[11] = "INMUNODEFICIENCIA";
            vRespuestasSenuelo11[0] = "MARTIN";
            vRespuestasSenuelo11[1] = "JOSEPH";
            vRespuestasSenuelo11[2] = "RAIMUND";

            vPreguntas[12] = "¿CON QUÉ EQUIPO DE FÚTBOL GABRIEL BATISTUTA FUE CAMPEÓN DE SEGUNDA DIVISIÓN?"; //
            vRespuestas[12] = "FIORENTINA";
            vRespuestasSenuelo12[0] = "MARTIN";
            vRespuestasSenuelo12[1] = "JOSEPH";
            vRespuestasSenuelo12[2] = "RAIMUND";

            vPreguntas[13] = "¿EN QUÉ AÑO SE EMITIÓ EL ESTRENO DEL PRIMER CAPÍTULO DE LA SERIE LOST?"; //
            vRespuestas[13] = "2004";
            vRespuestasSenuelo13[0] = "MARTIN";
            vRespuestasSenuelo13[1] = "JOSEPH";
            vRespuestasSenuelo13[2] = "RAIMUND";

            vPreguntas[14] = "¿CÓMO SE LLAMÓ AL PROYECTO DE INVESTIGACIÓN Y DESARROLLO QUE PRODUJO LAS PRIMERAS BOMBAS ATÓMICAS?"; //
            vRespuestas[14] = "MANHATTAN";
            vRespuestasSenuelo14[0] = "MARTIN";
            vRespuestasSenuelo14[1] = "JOSEPH";
            vRespuestasSenuelo14[2] = "RAIMUND";

            vPreguntas[15] = "¿CUÁL ES EL NOMBRE DE LA ESPOSA DEL PERSONAJE DE ANIMACIÓN ROGER RABBIT?"; //
            vRespuestas[15] = "JESSICA";
            vRespuestasSenuelo15[0] = "MARTIN";
            vRespuestasSenuelo15[1] = "JOSEPH";
            vRespuestasSenuelo15[2] = "RAIMUND";

            vPreguntas[16] = "¿CON QUÉ SIGLA SE DENOMINÓ AL CANAL 7 DE BUENOS AIRES EN SUS PRIMEROS AÑOS DE TRANSMISIÓN A COLOR?"; //
            vRespuestas[16] = "ATC";
            vRespuestasSenuelo16[0] = "MARTIN";
            vRespuestasSenuelo16[1] = "JOSEPH";
            vRespuestasSenuelo16[2] = "RAIMUND";

            vPreguntas[17] = "POR ORDEN ALFABÉTICO ¿QUE PREPOSICIÓN ESTÁ ENTRE “SO” Y “TRAS”?"; //
            vRespuestas[17] = "SOBRE";
            vRespuestasSenuelo17[0] = "MARTIN";
            vRespuestasSenuelo17[1] = "JOSEPH";
            vRespuestasSenuelo17[2] = "RAIMUND";

            vPreguntas[18] = "¿CUÁNTOS EPISODIOS PARA TELEVISIÓN TUVO LA SERIE “BREAKING BAD”"; //
            vRespuestas[18] = "62";
            vRespuestasSenuelo18[0] = "MARTIN";
            vRespuestasSenuelo18[1] = "JOSEPH";
            vRespuestasSenuelo18[2] = "RAIMUND";

            vPreguntas[19] = "SEGÚN LA CANCIÓN DE PALITO ORTEGA “YO TENGO FÉ” ¿QUE ES LO QUE TRIUNFARÁ POR SIEMPRE?"; //
            vRespuestas[19] = "EL AMOR";
            vRespuestasSenuelo19[0] = "MARTIN";
            vRespuestasSenuelo19[1] = "JOSEPH";
            vRespuestasSenuelo19[2] = "RAIMUND";

            vPreguntas[20] = "¿QUÉ SE CONMEMORA EN TODO EL MUNDO EL 1 DE DICIEMBRE?"; //
            vRespuestas[20] = "EL DÍA DE LA LUCHA CONTRA EL SIDA";
            vRespuestasSenuelo20[0] = "MARTIN";
            vRespuestasSenuelo20[1] = "JOSEPH";
            vRespuestasSenuelo20[2] = "RAIMUND";
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
            lblPreguntasRestantes.Visible=true;
            lblResultadoDeRespuesta.Visible = false;
            btRespuesta1.Enabled = true;
            btRespuesta2.Enabled = true;
            btRespuesta3.Enabled = true;
            btRespuesta4.Enabled = true;
        }
        private void BtRespuesta1_Click(object sender, EventArgs e)
        {
            validarRespuestas(btRespuesta1.Text);
        }
        private void BtRespuesta2_Click(object sender, EventArgs e)
        {
            validarRespuestas(btRespuesta2.Text);
        }
        private void BtRespuesta3_Click(object sender, EventArgs e)
        {
            validarRespuestas(btRespuesta3.Text);
        }
        private void BtRespuesta4_Click(object sender, EventArgs e)
        {
            validarRespuestas(btRespuesta4.Text);
        }

        public void selectorPreguntas()
        {
            Random rnd = new Random();
            Random random = new Random();
            int mIndex = rnd.Next(20);
            lblPregunta.Text = vPreguntas[mIndex];
            respuestaValida = vRespuestas[mIndex];
            int btnResp = random.Next(3);
            string RespSenuelo1 = vRespuestasSenuelo0[0];
            string RespSenuelo2 = vRespuestasSenuelo0[1];
            string RespSenuelo3 = vRespuestasSenuelo0[2];

            switch (btnResp)
            {
                case 1:
                    RespA = respuestaValida;
                    RespB = RespSenuelo1;
                    RespC = RespSenuelo2;
                    RespD = RespSenuelo3;
                    break;
                case 2:
                    RespA = RespSenuelo1;
                    RespB = respuestaValida;
                    RespC = RespSenuelo2;
                    RespD = RespSenuelo3;
                    break;
                case 3:
                    RespA = RespSenuelo1;
                    RespB = RespSenuelo2;
                    RespC = respuestaValida;
                    RespD = RespSenuelo3;
                    break;
                case 4:
                    RespA = RespSenuelo1;
                    RespB = RespSenuelo2;
                    RespC = RespSenuelo3;
                    RespD = respuestaValida;
                    break;
            }

            switch (mIndex)
            {
                case 0:
                    
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 1:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 2:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 3:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 4:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 5:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 6:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 7:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 8:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 9:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 10:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 11:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 12:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 13:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 14:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 15:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 16:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 17:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 18:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
                case 19:
                    btRespuesta1.Text = RespA;
                    btRespuesta2.Text = RespB;
                    btRespuesta3.Text = RespC;
                    btRespuesta4.Text = RespD;
                    break;
            }
        }

        public void validarRespuestas(string Respuesta)
        {
            lblPreguntasRestantes.Text = (Convert.ToInt32(lblPreguntasRestantes.Text) - 1).ToString();
            btRespuesta1.Enabled = false;
            btRespuesta2.Enabled = false;
            btRespuesta3.Enabled = false;
            btRespuesta4.Enabled = false;
            btIniciar.Enabled = true;
            if (Respuesta == respuestaValida)
            {
                lblResultadoDeRespuesta.Text = "¡Correcto!";
                lblResultadoDeRespuesta.Visible = true;

            }
            else
            {
                lblResultadoDeRespuesta.Text = "¡Perdió el juego!";
                lblResultadoDeRespuesta.Visible = true;
            }
        }


    }
}
