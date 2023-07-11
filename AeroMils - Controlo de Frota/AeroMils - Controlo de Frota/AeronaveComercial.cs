using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class AeronaveComercial
    {
        private int _numeroVoosDia;
        private string _companhiaAerea;

        public int numeroVoosDia { get; set; }
        public string companhiaAerea { get; set; }

        public AeronaveComercial(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool ativoInativo, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int numeroVoosDia, string companhiaAerea) : base(capacidade_passageiros, autonomia, data_ult_manutencao, ativoInativo, qtdMotores, marca, modelo, anoFabrico)
        {
            this._numeroVoosDia = numeroVoosDia;
            this._companhiaAerea = companhiaAerea;
        }
    }
}
