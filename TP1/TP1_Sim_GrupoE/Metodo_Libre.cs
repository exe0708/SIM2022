using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TP1_Sim_GrupoE.Clases;

namespace TP1_Sim_GrupoE
{


    public partial class Metodo_Libre : Form
    {
        // El valor de x podria estar incluido dentro del vector de estado.
        private static int x;
        private static int x2;
        private static int a;
        private static int c;
        private static int m;


        private static int n;
        private int orden;
        private static int opcionCombo;
        private static int incluir1_libre;
        public static int intervalos;
        float[] limites;
        bool flag = true;


        private List<NumeroAleatorio> listaAleatorios { get; set; }
        private List<Double> listaRandom = new List<double>();
        private List<Frecuencia> listaFrecuenciaTabla = new List<Frecuencia>();
        public static List<Frecuencia> listaFrecuenciaGrafico = new List<Frecuencia>();
        public static VectorEstado vector = new VectorEstado();


        public Metodo_Libre()
        {
            InitializeComponent();
        }
        //Inicio Formulario
        private void Metodo_Libre_Load(object sender, EventArgs e)
        {
            condcionesIniciales();

        }


        #region "Botones del formulario"
        private void btn_calcular_libre_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                leerValores();
                NumeroAleatorio numero = new NumeroAleatorio();
                vector.N_1 = numero;
                dg_libre.Rows.Clear();
                dg_libre.Columns.Clear();
                generarIntervalos();
                CalcularMetodos(20, false);
                habilitarBotonesCalcular(true);

                // calcularIntervalos();

            }
        }
        //-----------UNO MAS--------------
        private void btn_unomas_libre_Click(object sender, EventArgs e)
        {
            if (orden > 0)
            {
                CalcularMetodos(1, false);
            }
            else
            {
                MessageBox.Show("Supero el tamaño de la muestra");
            }
        }
        //-----------20 MAS--------------
        private void btn_20nuevos_libre_Click(object sender, EventArgs e)
        {
            if (orden > 0)
            {
                CalcularMetodos(20, false);
            }
            else
            {
                MessageBox.Show("Supero el tamaño de la muestra");
            }
        }
        private void btn_ultimo_libre_Click(object sender, EventArgs e)
        {
            if (orden > 0)
            {
                CalcularMetodos(10000, true);
            }
            else
            {
                MessageBox.Show("Supero el tamaño de la muestra");
            }
        }
        //-----------DATOS SUGERIDOS--------------
        private void btn_sugerido_Click_1(object sender, EventArgs e)
        {
            txt_a.Text = "19";
            txt_c.Text = "7";
            txt_semilla.Text = "37";
            txt_m.Text = "53";
            txt_tamañoMuestra_libre.Text = "20";
        }
        //-----------LIMPIAR--------------
        private void btn_limpiar_libre_Click(object sender, EventArgs e)
        {
            limpiarValores();
            habilitarBotonesCalcular(false);
        }
        //-----------COMBO--------------
        private void cmb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            condicionesInicialesMetodo();
        }

        //-----------LLAMADO PARA GRAFICAR--------------
        private void btn_graficar_libre_Click(object sender, EventArgs e)
        {
            chi chi = new chi();
            chi.Show();
        }
        #endregion
        #region "Logica"
        //-----------LEER VALORES DE ENTRADA--------------
        private void leerValores()
        {

            if (cmb_metodo.SelectedIndex != 3)
            {
                x = int.Parse(txt_semilla.Text);
                m = int.Parse(txt_m.Text);
            }

            if (cmb_metodo.SelectedIndex == 0)
                c = int.Parse(txt_c.Text);
            if (cmb_metodo.SelectedIndex != 2 && cmb_metodo.SelectedIndex != 3)
                a = int.Parse(txt_a.Text);
            if (cmb_metodo.SelectedIndex == 2)
                x2 = int.Parse(txt_semilla2.Text);
            n = int.Parse(txt_tamañoMuestra_libre.Text);
            orden = n - 1;
            opcionCombo = cmb_metodo.SelectedIndex;
            intervalos = int.Parse(txt_intervalos_libre.Text);
            incluir1_libre = 0;
            if (chk_incluir1_libre.Checked)
                incluir1_libre = 1;
            // Crea la lista vacia de numeros aleatorios que necesitamos mostrar
            listaRandom = new List<double>();
            listaAleatorios = new List<NumeroAleatorio>();

        }
        //-----------REALIZAR LLAMDO AL METODO SELECCIONADO--------------
        private void CalcularMetodos(int m, bool band)
        {
            //Asignar calculo del metodo
            for (int i = 0; i < m; i++)
            {

                switch (opcionCombo)
                {
                    case 0:
                        vector.N = congruencialMixto();
                        break;
                    case 1:
                        vector.N = congruencialMultiplicativo();
                        break;
                    case 2:
                        vector.N = congruencialAditivo();
                        break;
                    case 3:
                        vector.N = aleatorioLenguaje();
                        break;
                }

                //calcularIntervalos();
                saberIntervalo();
                recalcularVector(vector.N.intervaloAnterior, false);
                calcularP();
                calcularChi();
                vector.N_1 = vector.N;
                orden--;
                if (i < 20 && !band)
                    agregarFila();
                if ((i == m - 2 || i == m - 1) && band)
                    agregarFila();
            }

        }
        //-----------MULTIPLICATIVO--------------
        private NumeroAleatorio congruencialMultiplicativo()
        {
            // Calculo de congruencial Multiplicativo
            x = (a * x) % m;
            return calcularRandom(x);
        }
        //-----------MIXTO--------------
        private NumeroAleatorio congruencialMixto()
        {
            int calculo = 0;
            //Calculo del congruencial Mixto
            calculo = (a * x) + c;
            //Nueva semilla
            x = (int)calculo % m;
            return calcularRandom(x);
        }
        //-----------ADITIVO--------------
        private NumeroAleatorio congruencialAditivo()
        {
            //Semilla nueva N
            int xN;
            xN = (x + x2) % m;
            x2 = x;
            x = xN;
            return calcularRandom(x);
        }
        //-----------CALCULAR ALEATORIO DE LENGUAJE C#--------------
        private NumeroAleatorio aleatorioLenguaje()
        {
            Random rnd = new Random(orden);
            double random = rnd.NextDouble();
            random = (float)Math.Round(random, 4);
            NumeroAleatorio numero = new NumeroAleatorio();
            numero.orden = n - orden;
            numero.semilla = 0;
            numero.semilla2 = 0;
            numero.random = (float)random;
            setearValoresIntervalos(numero);
            return numero;
        }
        //-----------CREAR Y ASIGNAR EL NUMERO ALEATORIO--------------
        private NumeroAleatorio calcularRandom(int x)
        {
            NumeroAleatorio numero = new NumeroAleatorio();
            float random = 0;
            if (orden == n - 1)
            {
                numero.semilla = int.Parse(txt_semilla.Text);
                if (cmb_metodo.SelectedIndex == 2)
                    numero.semilla2 = int.Parse(txt_semilla2.Text);
            }
            else
            {
                numero.semilla = x;
                if (cmb_metodo.SelectedIndex == 2)
                    numero.semilla2 = x2;
            }

            random = (float)x / (m - incluir1_libre);
            random = (float)Math.Round(random, 4);

            numero.orden = n - orden;
            numero.random = random;
            setearValoresIntervalos(numero);
            return numero;
        }

        //-----------SETEAR INTERVALOS--------------
        private void setearValoresIntervalos(NumeroAleatorio numero)
        {
            numero.intervalo1 = vector.N_1.intervalo1;
            numero.intervalo2 = vector.N_1.intervalo2;
            numero.intervalo3 = vector.N_1.intervalo3;
            numero.intervalo4 = vector.N_1.intervalo4;
            numero.intervalo5 = vector.N_1.intervalo5;
            numero.intervalo6 = vector.N_1.intervalo6;
            numero.intervalo7 = vector.N_1.intervalo7;
            numero.intervalo8 = vector.N_1.intervalo8;
            numero.intervalo9 = vector.N_1.intervalo9;
            numero.intervalo10 = vector.N_1.intervalo10;
        }
        //-----------SABER INTERVALO CAE EL RANDOM--------------
        private void saberIntervalo()
        {

            for (int i = 0; i < intervalos - 1; i++)
            {

                if (vector.N.random >= limites[i] && vector.N.random < limites[i + 1])
                {
                    calcularIntervaloRandom(i + 1, true);
                }
            }

        }

        //-----------CALCULAR VECTOR ESTADO --------------
        private void calcularIntervaloRandom(int i, bool band)
        {

            int simulacionAnterior = vector.N_1.orden;
            int objAcumula = 0;
            int simulacionActual = vector.N.orden;
            if (band)
            {
                vector.N.intervaloAnterior = i;
                objAcumula = 1;
            }
            switch (i)
            {
                //calculo=( ( (valor anterior * num.sim anterior) + num.objetos que acumula ) / num. simul actual )
                case 1:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 2:
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 3:
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 4:
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 5:
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 6:
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 7:
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 8:
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 9:
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 10:
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;

            }

        }
        //-----------CALCULAR SUMATORIA DE P()------------
        private void calcularP()
        {
            vector.N.sumatoria = vector.N.intervalo1 + vector.N.intervalo2 + vector.N.intervalo3 + vector.N.intervalo4 + vector.N.intervalo5 + vector.N.intervalo6 + vector.N.intervalo7 + vector.N.intervalo8 + vector.N.intervalo9 + vector.N.intervalo10;
        }
        //-----------RECALCULAR VECTOR ESTADO-------------
        private void recalcularVector(int i, bool band)
        {
            int simulacionAnterior = vector.N_1.orden;
            int objAcumula = 0;
            int simulacionActual = vector.N.orden;
            if (band)
            {
                vector.N.intervaloAnterior = i;
                objAcumula = 1;
            }
            switch (i)
            {
                //calculo=( ( (valor anterior * num.sim anterior) + num.objetos que acumula ) / num. simul actual )
                case 1:
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 2:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 3:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 4:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 5:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 6:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 7:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
                case 8:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 9:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo10 = (((vector.N_1.intervalo10 * simulacionAnterior) + objAcumula) / simulacionActual);

                    break;
                case 10:
                    vector.N.intervalo1 = (((vector.N_1.intervalo1 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo2 = (((vector.N_1.intervalo2 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo3 = (((vector.N_1.intervalo3 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo4 = (((vector.N_1.intervalo4 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo5 = (((vector.N_1.intervalo5 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo6 = (((vector.N_1.intervalo6 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo7 = (((vector.N_1.intervalo7 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo8 = (((vector.N_1.intervalo8 * simulacionAnterior) + objAcumula) / simulacionActual);
                    vector.N.intervalo9 = (((vector.N_1.intervalo9 * simulacionAnterior) + objAcumula) / simulacionActual);
                    break;
            }

        }
        private void calcularChi()
        {
            float chi = 0;
            float frecuenciaEsperada = vector.N.orden / intervalos;
            float frecuenciaObservada = 0;
            for (int i = 0; i < intervalos; i++)
            {
                frecuenciaObservada = (obtenerValorIntervalo(i) * vector.N.orden) / 100;
                chi = ((frecuenciaEsperada - frecuenciaObservada) * (frecuenciaEsperada - frecuenciaObservada)) / frecuenciaEsperada;
                chi = float.Parse(Math.Round(chi, 4).ToString());
                vector.N.sumChi = vector.N.sumChi + chi;
                vector.N.sumChi = float.Parse(Math.Round(vector.N.sumChi, 4).ToString());
            }
           
        }
        private float obtenerValorIntervalo(int i)
        {
            i++;
            switch (i)
            {
                case 1:
                    return vector.N.intervalo1 * 100;
                case 2:
                    return vector.N.intervalo2 * 100;
                case 3:
                    return vector.N.intervalo3 * 100;
                case 4:
                    return vector.N.intervalo4 * 100;
                case 5:
                    return vector.N.intervalo5 * 100;
                case 6:
                    return vector.N.intervalo6 * 100;
                case 7:
                    return vector.N.intervalo7 * 100;
                case 8:
                    return vector.N.intervalo8 * 100;
                case 9:
                    return vector.N.intervalo9 * 100;
                case 10:
                    return vector.N.intervalo10 * 100;
            }
            return 0;
        }
        //-----------CREAR COLUMNAS DE LA TABLA--------------
        private void generarIntervalos()
        {
            limites = new float[intervalos];
            Double Maximo = 1;
            Double Minimo = 0;
            Double Paso = (Maximo - Minimo) / intervalos;
            dg_libre.Columns.Add("orden", "Orden");
            dg_libre.Columns.Add("semilla", "Semilla 1");
            dg_libre.Columns.Add("semilla2", "Semilla 2");
            dg_libre.Columns.Add("random", "Random");
            for (int i = 0; i < intervalos; i++)
            {

                string nombre_intervalo = "intervalo" + (i + 1);
                Frecuencia frecuencia = new Frecuencia();
                frecuencia.LimInferior = 0;
                if (i != 0)
                {
                    frecuencia.LimInferior = Math.Round(Minimo, 4);
                }
                Maximo = Minimo + Paso;
                frecuencia.LimSuperior = Math.Round(Maximo, 4);
                if (i == intervalos - 1)
                {
                    Maximo = 1;
                }
                string nombre_comlumna = Minimo.ToString() + "-" + Maximo.ToString();
                limites[i] = float.Parse((Math.Round(Minimo, 4).ToString()));
                Minimo = Minimo + Paso;
                dg_libre.Columns.Add(nombre_intervalo, nombre_comlumna);

            }
            dg_libre.Columns.Add("sumChi", "Sumatoria Chi");
            dg_libre.Columns.Add("sumatoria", "P(X)");
        }
        //-----------AGREGAR FILA A GRILLA--------------
        private void agregarFila()
        {
            dg_libre.Rows.Add(vector.N.orden, vector.N.semilla, vector.N.semilla2, vector.N.random, vector.N.intervalo1, vector.N.intervalo2, vector.N.intervalo3, vector.N.intervalo4, vector.N.intervalo5, vector.N.intervalo6, vector.N.intervalo7, vector.N.intervalo8, vector.N.intervalo9, vector.N.intervalo10, vector.N.sumChi,vector.N.sumatoria);
        }
        private void calcularIntervalos()
        {

            listaRandom.Sort();
            Int32 CantidadAleatorios = listaAleatorios.Count;
            dg_intervalos.DataSource = null;
            dg_intervalos.Refresh();
            dg_intervalos.Rows.Clear();
            listaFrecuenciaTabla.Clear();


            Double Min = listaRandom.Min();
            Double Max = listaRandom.Max();
            Double Paso = (Max - Min) / intervalos;
            Double Frecuencia = CantidadAleatorios / intervalos;
            Double sumChi = 0;

            for (int i = 0; i < intervalos; i++)
            {
                Frecuencia frecuencia = new Frecuencia();
                frecuencia.LimInferior = Math.Round(Min, 4);
                Double Maximo = Min + Paso;
                frecuencia.LimSuperior = Math.Round(Maximo, 4);
                if (i == intervalos)
                {
                    frecuencia.FrecObservada = listaRandom.Count(p => (p >= frecuencia.LimInferior)
                    && (p <= frecuencia.LimSuperior));

                }
                else
                {
                    frecuencia.FrecObservada = listaRandom.Count(p => (p >= frecuencia.LimInferior)
                    && (p < frecuencia.LimSuperior));
                }
                frecuencia.FrecEsperado = Frecuencia;
                frecuencia.indice = i + 1;
                var chiTemp = ((frecuencia.FrecEsperado - frecuencia.FrecObservada) * (frecuencia.FrecEsperado - frecuencia.FrecObservada)) / frecuencia.FrecEsperado;
                frecuencia.Chi = Math.Round(chiTemp, 4);
                sumChi = sumChi + frecuencia.Chi;
                frecuencia.SumChi = Math.Round(sumChi, 4);
                listaFrecuenciaTabla.Add(frecuencia);
                Min = Min + Paso;
            }

            if (flag)
            {
                flag = false;
            }
            else
            {

                dg_intervalos.DataSource = null;
                dg_intervalos.Rows.Clear();
            }

            dg_intervalos.DataSource = listaFrecuenciaTabla;
            listaFrecuenciaGrafico = listaFrecuenciaTabla;
            dg_intervalos.Refresh();


        }

        #endregion
        #region "Condiciones de inicio y Validaciones"
        //-----------INICIO--------------
        private void condcionesIniciales()
        {
            btn_20nuevos_libre.Enabled = false;
            btn_calcular_libre.Enabled = false;
            btn_graficar_libre.Enabled = false;
            btn_ultimo_libre.Enabled = false;
            btn_unomas_libre.Enabled = false;
            btn_limpiar_libre.Enabled = false;
            btn_sugerido.Enabled = false;
            txt_a.Enabled = false;
            txt_c.Enabled = false;
            txt_intervalos_libre.Enabled = false;
            txt_m.Enabled = false;
            txt_semilla.Enabled = false;
            txt_semilla2.Enabled = false;
            txt_tamañoMuestra_libre.Enabled = false;
            chk_incluir1_libre.Enabled = false;
            dg_libre.Rows.Clear();
            dg_libre.Columns.Clear();
        }
        //-----------INICIO METODOS DE GENERACION--------------
        private void condicionesInicialesMetodo()
        {
            btn_calcular_libre.Enabled = true;
            btn_limpiar_libre.Enabled = true;
            btn_sugerido.Enabled = false;
            if (cmb_metodo.SelectedIndex == 0)
                btn_sugerido.Enabled = true;
            txt_a.Enabled = true;
            txt_c.Enabled = true;
            //txt_intervalos_libre.Enabled = true;
            txt_m.Enabled = true;
            txt_semilla.Enabled = true;
            txt_tamañoMuestra_libre.Enabled = true;
            chk_incluir1_libre.Enabled = true;
            if (cmb_metodo.SelectedIndex == 1)
            {
                txt_c.Enabled = false;
            }
            if (cmb_metodo.SelectedIndex == 2)
            {
                txt_a.Enabled = false;
                txt_c.Enabled = false;
                txt_semilla2.Enabled = true;
            }
            if (cmb_metodo.SelectedIndex == 3)
            {
                txt_a.Enabled = false;
                txt_c.Enabled = false;
                txt_m.Enabled = false;
                txt_semilla.Enabled = false;
            }
        }
        //-----------LIMPIAR--------------
        private void limpiarValores()
        {
            txt_a.Text = "";
            txt_c.Text = "";
            //txt_intervalos_libre.Text = "";
            txt_m.Text = "";
            txt_semilla.Text = "";
            txt_tamañoMuestra_libre.Text = "";
            txt_semilla2.Text = "";
            chk_incluir1_libre.Checked = false;
            cmb_metodo.SelectedIndex = -1;
            dg_libre.DataSource = null;
            dg_intervalos.DataSource = null;
            condcionesIniciales();
        }
        //-----------HABILITAR CONTROLES--------------
        private void habilitarBotonesCalcular(bool band)
        {
            btn_20nuevos_libre.Enabled = band;
            btn_ultimo_libre.Enabled = band;
            btn_unomas_libre.Enabled = band;
            btn_graficar_libre.Enabled = band;
            btn_sugerido.Enabled = false;
            if (cmb_metodo.SelectedIndex == 0)
                btn_sugerido.Enabled = true;
        }
        //-----------VALIDO CAMPOS VACIOS--------------
        private bool ValidarCamposVacios()
        {
            if (cmb_metodo.SelectedIndex == 0 && txt_c.Text == String.Empty)
            {
                MessageBox.Show("No se puede calcular con campos vacios");
                return false;
            }
            if ((cmb_metodo.SelectedIndex == 0 || cmb_metodo.SelectedIndex == 1) && txt_a.Text == String.Empty)
            {
                MessageBox.Show("No se puede calcular con campos vacios");
                return false;
            }

            if (txt_intervalos_libre.Text == String.Empty || ((txt_m.Text == String.Empty || txt_semilla.Text == String.Empty) && cmb_metodo.SelectedIndex != 3) || txt_tamañoMuestra_libre.Text == String.Empty)
            {
                MessageBox.Show("No se puede calcular con campos vacios");
                return false;
            }
            return true;

        }



        #endregion


    }
}
