using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP1_Sim_GrupoE.Clases;

namespace TP1_Sim_GrupoE
{
    public partial class chi : Form
    {
        public chi()
        {
            InitializeComponent();
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

        private void chi_Load(object sender, EventArgs e)
        {
            graficar(Metodo_Libre.listaFrecuenciaGrafico);
            
        }
    }
}
