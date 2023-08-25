using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Modules;

namespace AeroMils___Controlo_de_Frota.Models
{
    internal class AeronaveParticular : Aviao
    {
        private int _numProprietarios;
        private Frete _valorFrete;
        public int numProprietarios
        {
            get => _numProprietarios;
            set => _numProprietarios = value;
        }
        public double valorFrete
        {
            get => _valorFrete.ValorFrete;
            set => _valorFrete = new Frete(value);
        }


        public AeronaveParticular(int id, int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int numProprietarios, double valorFrete)
        : base(id, capacidade_passageiros, autonomia, data_ult_manutencao, estado, qtdMotores, marca, modelo, anoFabrico)
        {
            _numProprietarios = numProprietarios;
            _valorFrete = new Frete(valorFrete);
        }

    }
}
