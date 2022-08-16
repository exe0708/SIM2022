using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TP1_Sim_GrupoE.Clases;

namespace TP1_Sim_GrupoE
{


    public partial class Metodo_Libre : Form
    {
        private static int x;
        private static int a;
        private static int c;
        private static int m;
        private static int n;
        private static int opcionCombo;
        private static int incluir1_libre;
        public static int intervalos;
        private static int semillaAnterior = 34;
        bool flag = true;
        private List<NumeroAleatorio> listaAleatorios { get; set; }
        private List<Double> listaRandom = new List<double>();
        private List<Frecuencia> listaFrecuenciaTabla = new List<Frecuencia>();
        public static List<Frecuencia> listaFrecuenciaGrafico = new List<Frecuencia>();

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
                CalcularMetodos();
                habilitarBotonesCalcular(true);
                calcularIntervalos();
            }
        }
        private void btn_unomas_libre_Click(object sender, EventArgs e)
        {
            switch (opcionCombo)
            {
                case 0:
                    listaAleatorios.Add(congruencialMixto(listaAleatorios.Count));
                    break;
                case 1:
                    listaAleatorios.Add(congruencialMultiplicativo(listaAleatorios.Count));
                    break;
                case 2:
                    listaAleatorios.Add(congruencialAditivo(listaAleatorios.Count));
                    break;
                case 3:
                    listaAleatorios.Add(aleatorioLenguaje(listaAleatorios.Count));
                    break;
            }
            listaRandom.Add(listaAleatorios[listaAleatorios.Count - 1].random);
            dg_libre.DataSource = null;
            dg_libre.DataSource = listaAleatorios;
            calcularIntervalos();

        }
        private void btn_limpiar_libre_Click(object sender, EventArgs e)
        {
            limpiarValores();
            habilitarBotonesCalcular(false);
        }
        private void btn_sugerido_Click_1(object sender, EventArgs e)
        {
            txt_a.Text = "19";
            txt_c.Text = "7";
            txt_semilla.Text = "37";
            txt_m.Text = "53";
            txt_tamañoMuestra_libre.Text = "20";
        }
        private void btn_20nuevos_libre_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                switch (opcionCombo)
                {
                    case 0:
                        listaAleatorios.Add(congruencialMixto(listaAleatorios.Count));
                        break;
                    case 1:
                        listaAleatorios.Add(congruencialMultiplicativo(listaAleatorios.Count));
                        break;
                    case 2:
                        listaAleatorios.Add(congruencialAditivo(listaAleatorios.Count));
                        break;
                    case 3:
                        listaAleatorios.Add(aleatorioLenguaje(listaAleatorios.Count));
                        break;
                }
                listaRandom.Add(listaAleatorios[listaAleatorios.Count - 1].random);
            }
            dg_libre.DataSource = null;
            dg_libre.DataSource = listaAleatorios;
            calcularIntervalos();
        }

        private void btn_ultimo_libre_Click(object sender, EventArgs e)
        {
            listaAleatorios = new List<NumeroAleatorio>();
            listaRandom = new List<double>();
            List<NumeroAleatorio> ultimoElemento = new List<NumeroAleatorio>();
            for (int i = 0; i < 10000; i++)
            {
                switch (opcionCombo)
                {
                    case 0:
                        listaAleatorios.Add(congruencialMixto(listaAleatorios.Count));
                        break;
                    case 1:
                        listaAleatorios.Add(congruencialMultiplicativo(listaAleatorios.Count));
                        break;
                    case 2:
                        listaAleatorios.Add(congruencialAditivo(listaAleatorios.Count));
                        break;
                    case 3:
                        listaAleatorios.Add(aleatorioLenguaje(listaAleatorios.Count));
                        break;
                }
                listaRandom.Add(listaAleatorios[listaAleatorios.Count-1].random);
            }
            ultimoElemento.Add(listaAleatorios[listaAleatorios.Count - 1]);
            dg_libre.DataSource = null;
            dg_libre.DataSource = ultimoElemento;
        }
        private void cmb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            condicionesInicialesMetodo();
        }
        //LLAMADO AL GRAFICO
        private void btn_graficar_libre_Click(object sender, EventArgs e)
        {
            chi chi = new chi();
            chi.Show();
        }
        #endregion
        #region "Logica"
        private void leerValores()
        {
            //Lee todos los valores

            if (cmb_metodo.SelectedIndex != 3)
            {
                x = int.Parse(txt_semilla.Text);
                m = int.Parse(txt_m.Text);
            }

            if (cmb_metodo.SelectedIndex == 0)
                c = int.Parse(txt_c.Text);
            if (cmb_metodo.SelectedIndex != 2 && cmb_metodo.SelectedIndex !=3)
                a = int.Parse(txt_a.Text);

            n = int.Parse(txt_tamañoMuestra_libre.Text);
            opcionCombo = cmb_metodo.SelectedIndex;
            intervalos = int.Parse(txt_intervalos_libre.Text);
            incluir1_libre = 0;
            if (chk_incluir1_libre.Checked)
                incluir1_libre = 1;
            // Crea la lista vacia de numeros aleatorios que necesitamos mostrar
            listaRandom = new List<double>();
            listaAleatorios = new List<NumeroAleatorio>();

        }
        private void CalcularMetodos()
        {
            //Asignar calculo del metodo
            for (int i = 0; i < n; i++)
            {
                switch (opcionCombo)
                {
                    case 0:
                        listaAleatorios.Add(congruencialMixto(i));
                        break;
                    case 1:
                        listaAleatorios.Add(congruencialMultiplicativo(i));
                        break;
                    case 2:
                        listaAleatorios.Add(congruencialAditivo(i));
                        break;
                    case 3:
                        listaAleatorios.Add(aleatorioLenguaje(i));
                        break;
                }
                listaRandom.Add(listaAleatorios[i].random);
            }
            dg_libre.DataSource = null;
            dg_libre.DataSource = listaAleatorios;

        }
        private NumeroAleatorio aleatorioLenguaje(int i)
        {
            Random rnd = new Random(i);
            double random = rnd.NextDouble();
            random = (float)Math.Round(random, 4);
            NumeroAleatorio numero = new NumeroAleatorio();
            numero.orden = i + 1;
            numero.semilla = 0;
            numero.random =(float) random;
            return numero;
        }
        private NumeroAleatorio congruencialMultiplicativo(int i)
        {
            // Calculo de congruencial Multiplicativo
            x = (a * x) % m;
            return calcularRandom(x, i);
        }
        private NumeroAleatorio congruencialMixto(int i)
        {
            int calculo = 0;
            //Calculo del congruencial Mixto
            calculo = (a * x) + c;
            //Nueva semilla
            x = (int)calculo % m;
            return calcularRandom(x, i);
        }
        private NumeroAleatorio congruencialAditivo(int i)
        {
            int calculoSemillas;
            calculoSemillas = (x + semillaAnterior) % m;
            semillaAnterior = calculoSemillas;
            return calcularRandom(calculoSemillas, i);
        }
        private NumeroAleatorio calcularRandom(int x, int i)
        {
            NumeroAleatorio numero = new NumeroAleatorio();
            float random = 0;
            if (i == 0)
            { numero.semilla = int.Parse(txt_semilla.Text); }
            else
            { numero.semilla = x; }

            random = (float)x / (m - incluir1_libre);
            random = (float)Math.Round(random, 4);

            numero.orden = i + 1;
            numero.random = random;
            return numero;
        }
        #endregion
        #region "Condiciones de inicio y Validaciones"
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
            txt_tamañoMuestra_libre.Enabled = false;
            chk_incluir1_libre.Enabled = false;
        }
        private void condicionesInicialesMetodo()
        {
            btn_calcular_libre.Enabled = true;
            btn_limpiar_libre.Enabled = true;
            btn_sugerido.Enabled = false;
            if (cmb_metodo.SelectedIndex == 0)
                btn_sugerido.Enabled = true;
            txt_a.Enabled = true;
            txt_c.Enabled = true;
            txt_intervalos_libre.Enabled = true;
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
            }
            if (cmb_metodo.SelectedIndex == 3)
            {
                txt_a.Enabled = false;
                txt_c.Enabled = false;
                txt_m.Enabled = false;
                txt_semilla.Enabled = false;
            }
        }
        private void limpiarValores()
        {
            txt_a.Text = "";
            txt_c.Text = "";
            txt_intervalos_libre.Text = "";
            txt_m.Text = "";
            txt_semilla.Text = "";
            txt_tamañoMuestra_libre.Text = "";
            chk_incluir1_libre.Checked = false;
            cmb_metodo.SelectedIndex = -1;
            dg_libre.DataSource = null;
            dg_intervalos.DataSource = null;
            condcionesIniciales();
        }
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

            //lblSumChi.Text = "La sumatoria de Chi Cuadrado es: " + sumChi;

        }


    }
}
