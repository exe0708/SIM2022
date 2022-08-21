using System;
using System.Windows.Forms;

namespace TP1_Sim_GrupoE
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_metodoLibre_Click(object sender, EventArgs e)
        {
            Metodo_Libre ML = new Metodo_Libre();
            ML.Show();
        }
    }
}
