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
            set
            {
                if (value >= 0) // Validate that capacidadeCarga is non-negative
                {
                    _capacidadeCarga = value;
                }
                else
                {
                    throw new ArgumentException("Capacidade de carga must be non-negative.");
                }
            }
        }
        public double valorFrete
        {
            get => _valorFrete;
            set
            {
                if (value >= 0) // Validate that valorFrete is non-negative
                {
                    _valorFrete = value;
                }
                else
                {
                    throw new ArgumentException("Valor do frete must be non-negative.");
                }
            }
        }

        public AeronaveMercadorias(int id, int capacidadeCarga, double valorFrete) 
            : base(id)
        {
            _capacidadeCarga = capacidadeCarga;
            _valorFrete = valorFrete;
        }
    }
}
