using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    internal class AeronaveComercial : Aviao
    {
        private int _numeroVoosDia;
        private string _companhiaAerea;

        public int numeroVoosDia
        {
            get => _numeroVoosDia;
            set => _numeroVoosDia = value;
        }

        public string companhiaAerea
        {
            get => _companhiaAerea;
            set => _companhiaAerea = value;
        }

        public AeronaveComercial(int id, int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int numeroVoosDia, string companhiaAerea)
            : base(id, capacidade_passageiros, autonomia, data_ult_manutencao, estado, qtdMotores, marca, modelo, anoFabrico)
        {
            _numeroVoosDia = numeroVoosDia;
            _companhiaAerea = companhiaAerea;
        }
    }
}
