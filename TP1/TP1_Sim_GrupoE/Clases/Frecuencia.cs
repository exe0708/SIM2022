using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Sim_GrupoE.Clases
{
    public class Frecuencia
    {
        public int indice { get; set; }
        public Double LimInferior { get; set; }
        public Double LimSuperior { get; set; }
        public int FrecObservada { get; set; }
        public Double FrecEsperado { get; set; }
        public Double Chi { get; set; }
        public Double SumChi { get; set; }
    }
}
