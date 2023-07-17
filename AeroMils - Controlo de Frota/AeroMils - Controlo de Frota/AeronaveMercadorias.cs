using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class AeronaveMercadorias : Aviao
    {
        private int _capacidadeCarga;
        private double _valorFrete;

        public int capacidadeCarga 
        { 
            get => _capacidadeCarga;
            set => _capacidadeCarga = value;
        }
        public double valorFrete 
        {
            get => _valorFrete;
            set => _valorFrete = value;
        }

        public AeronaveMercadorias(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool ativoInativo, int qtdMotores, string marca, string modelo, DateTime anoFabrico, int capacidadeCarga, double valorFrete) : base(capacidade_passageiros, autonomia, data_ult_manutencao, ativoInativo, qtdMotores, marca, modelo, anoFabrico) 
        {
            this._capacidadeCarga = capacidade_passageiros;
            this._valorFrete = valorFrete;
        }
    }
}
