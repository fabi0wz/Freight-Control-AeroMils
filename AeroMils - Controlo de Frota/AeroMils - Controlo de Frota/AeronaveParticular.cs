using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class AeronaveParticular : Aviao
    {
        private int _numProprietarios;
        private double _valorFrete;

        public int numProprietarios { get; set; }
        public double valorFrete { get; set; }


        public AeronaveParticular(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool ativoInativo, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int numProprietarios, double valorFrete) : base(capacidade_passageiros, autonomia, data_ult_manutencao, ativoInativo, qtdMotores, marca, modelo, anoFabrico)
        {
            this._numProprietarios = numProprietarios;
            this._valorFrete = valorFrete;
        }

    }
}
