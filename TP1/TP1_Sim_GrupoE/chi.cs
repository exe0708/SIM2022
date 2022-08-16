using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP1_Sim_GrupoE.Clases;

namespace TP1_Sim_GrupoE
{
    public partial class chi : Form
    {
        private double[] valorTabulado = { 7.88, 10.6, 12.8, 14.9, 16.7, 18.5, 20.3, 22.0, 23.6, 25.2, 26.8, 28.3, 29.8, 31.3, 32.8, 34.3, 35.7, 37.2, 38.6, 40.0, 41.4, 42.8, 44.2, 45.6, 46.9, 48.3, 49.6, 51.0, 52.3, 53.7, 66.8, 79.5, 92.0, 104.2, 116.3, 128.3, 140.2 };
        private int gradosLibertad;
        private double sumChi;
        public chi()
        {
            InitializeComponent();
        }
        private void chi_Load(object sender, EventArgs e)
        {
            graficar(Metodo_Libre.listaFrecuenciaGrafico);
            hipotesis();
        }
        private void hipotesis()
        {
            gradosLibertad = Metodo_Libre.intervalos - 1;
            sumChi = Metodo_Libre.listaFrecuenciaGrafico[Metodo_Libre.listaFrecuenciaGrafico.Count - 1].SumChi;
            txt_xcalculado.Text = sumChi.ToString();
            txt_gradoslibertad.Text = gradosLibertad.ToString();
            if (Metodo_Libre.intervalos < 39 && Metodo_Libre.intervalos>1)
            {
                
                txt_gradoslibertad.Text = gradosLibertad.ToString();
                if (sumChi <= valorTabulado[gradosLibertad - 1])
                {
                    txt_hipotesis.Text = "<= NO RECHAZADA";
                    txt_hipotesis.ForeColor = System.Drawing.Color.DarkGreen;
                    txt_xcalculado.Text = sumChi.ToString();
                    txt_xtabulado.Text = valorTabulado[gradosLibertad - 1].ToString();
                }
                else
                {
                    txt_hipotesis.Text = " > RECHAZADA";
                    txt_hipotesis.ForeColor = System.Drawing.Color.Red;
                    txt_xcalculado.Text = sumChi.ToString();
                    txt_xtabulado.Text = valorTabulado[gradosLibertad - 1].ToString();
                }
            }
            else
            {
                
                txt_hipotesis.Text = "NO SE PUEDE CALCULAR HIPOTESIS";
            }
        }
        private void graficar(List<Frecuencia> listaFrecuenciaGrafico)
        {
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();

            //grafico.Titles.Add("Histograma");
            grafico.Series.Add("Esperada");
            grafico.Series.Add("Observada");
            grafico.Series["Esperada"].LegendText = "Esperada";
            grafico.Series["Observada"].LegendText = "Observada";

            int[] pointsArray = { };
            grafico.Titles.Add("Histograma");
            grafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            grafico.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -90;
            foreach (var item in listaFrecuenciaGrafico)
            {

                var cad1 = item.LimInferior.ToString() + " - " + item.LimSuperior.ToString();

                grafico.Series["Observada"].Points.Add(item.FrecObservada);
                grafico.Series["Esperada"].Points.Add(item.FrecEsperado);
                grafico.Series["Esperada"].Points[item.indice - 1].AxisLabel = cad1;
                grafico.Series["Observada"].Points[item.indice - 1].AxisLabel = cad1;
                grafico.Series["Esperada"].Points[item.indice - 1].IsValueShownAsLabel = true;
                grafico.Series["Observada"].Points[item.indice - 1].IsValueShownAsLabel = true;
            }

        }



    }
}
