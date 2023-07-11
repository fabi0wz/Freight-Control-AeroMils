using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class Avioneta
    {
        private int _areaDescolagem;
        private int _areaPouso;
        private double _valorFrete;

        public int areaDescolagem { get; set; }
        public int areaPouso { get; set; }
        public double valorFrete { get; set; }


        public Avioneta(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool ativoInativo, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int areaDescolagem, int areaPouso, double valorFrete) : base(capacidade_passageiros, autonomia, data_ult_manutencao, ativoInativo, qtdMotores, marca, modelo, anoFabrico)
        {
            this._areaDescolagem = areaDescolagem;
            this._areaPouso = areaPouso;
            this._valorFrete = valorFrete;
        }
    }
}
