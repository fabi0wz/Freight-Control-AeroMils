using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class Aviao
    {
        public int CapacidadePassageiros { get; set; }
        public int? Autonomia { get; set; }
        public DateTime DataUltimaManutencao { get; set; }
        public bool AtivoInativo { get; set; }
        public int QtdMotores { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabrico { get; set; }

    }
}
