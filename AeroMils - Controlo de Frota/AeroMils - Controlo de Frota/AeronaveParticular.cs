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

        public int numProprietarios 
        {
            get => _numProprietarios;
            set => _numProprietarios = value;
        }
        public double valorFrete 
        {
            get => _valorFrete;
            set => _valorFrete = value;
        }


        public AeronaveParticular(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int numProprietarios, double valorFrete) : base(capacidade_passageiros, autonomia, data_ult_manutencao, estado, qtdMotores, marca, modelo, anoFabrico)
        {
            this._numProprietarios = numProprietarios;
            this._valorFrete = valorFrete;
        }

    }
}
