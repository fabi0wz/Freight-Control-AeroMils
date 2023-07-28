using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Modules;

namespace AeroMils___Controlo_de_Frota.Modules.Planes
{
    internal class Avioneta : Aviao
    {
        private int _areaDescolagem;
        private int _areaPouso;
        private Frete _valorFrete;

        public int areaDescolagem
        {
            get => _areaDescolagem;
            set => _areaDescolagem = value;
        }

        public int areaPouso
        {
            get => _areaPouso;
            set => _areaPouso = value;
        }

        public double valorFrete
        {
            get => _valorFrete.ValorFrete;
            set => _valorFrete = new Frete(value);
        }


        public Avioneta(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int areaDescolagem, int areaPouso, double valorFrete) : base(capacidade_passageiros, autonomia, data_ult_manutencao, estado, qtdMotores, marca, modelo, anoFabrico)
        {
            _areaDescolagem = areaDescolagem;
            _areaPouso = areaPouso;
            _valorFrete = new Frete(valorFrete);
        }
    }
}
