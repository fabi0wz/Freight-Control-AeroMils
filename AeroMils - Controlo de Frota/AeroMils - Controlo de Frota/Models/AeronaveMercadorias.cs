using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Modules;

namespace AeroMils___Controlo_de_Frota.Models
{
    public class AeronaveMercadorias : Aviao
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

        public AeronaveMercadorias(int id, int capacidadeCarga, double valorFrete) 
            : base(id)
        {
            _capacidadeCarga = capacidadeCarga;
            _valorFrete = valorFrete;
        }
    }
}
